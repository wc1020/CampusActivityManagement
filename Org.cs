using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    public partial class Org : Form
    {
        public static String orgID;
        private String orgName;

        public Org(string orgID, string orgName)
        {
            Org.orgID = orgID;
            this.orgName = orgName;
            InitializeComponent();
            
            sideBar1.HideItem2();
            sideBar1.HideItem3();
            sideBar1.HideItem4();
            sideBar1.HideItem5();

            OrgName.Text = orgName;
            Exit.ForeColor = MyPara.exitColor;
        }

        private void Org_Load(object sender, EventArgs e)
        {
            resetQuery();
            LoadActivity();
        }

        public void LoadActivity()
        {
            AddLabel.RemoveLabel(Activities);
            Activities.Items.Clear();
            String name = QueryName.Text;
            String start = QueryDateStart.Value.ToString(), end = QueryDateEnd.Value.ToString();

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from Activity where activityOrgID = @orgID and activityName like @activityName and (submitTime between @start and @end or submitTime = '') order by activityState, submitTime";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("orgID", Org.orgID), new SqlParameter("activityName", "%" + name + "%"), new SqlParameter("start", start.Split(' ')[0]), new SqlParameter("end", end.Split(' ')[0]) };
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, paras);
            
            while (reader.Read())
            {
                Activity activity = new Activity(reader);
                ListViewItem item = new ListViewItem();

                activity.UpdateState();

                item.Text = activity.ActivityID;
                // 添加活动名称，一行最多8个字
                String AName = activity.ActivityName;
                if (AName.Length >= 8)
                {
                    int x = (AName.Length + 1) / 2;
                    AName = AName.Substring(0, x) + "\n" + AName.Substring(x, AName.Length - x);
                }
                item.SubItems.Add(AName);
                
                // 添加活动申请时间，日期与时间不同行
                String submit = activity.SubmitTime.Substring(0, 10) + "\n" + activity.SubmitTime.Substring(11, 8);
                if (activity.SubmitTime.Substring(0, 4) == "1900")
                    submit = "/";
                item.SubItems.Add(submit);

                // 添加活动举办地点
                SqlConnection connPlace = Dao.MySqlConnection();
                sql = "select placeName from Place where placeID = @placeID";
                SqlDataReader onceReader = Dao.MySqlDateReader(sql, connPlace, new SqlParameter[] { new SqlParameter("placeID", Convert.ToInt32(activity.ActivityPlaceID)) });
                onceReader.Read();
                item.SubItems.Add(onceReader[0].ToString());
                connPlace.Close();

                // 添加活动报名时间段
                String sign = activity.SignStartDate + " 12:00 至\n" + activity.SignEndDate + " 12:00";
                item.SubItems.Add(sign);

                // 添加活动举办时间段
                String hold = activity.HoldDate + " " + activity.HoldStart + ":00 至\n" + activity.HoldDate + " " + activity.HoldEnd + ":00";
                item.SubItems.Add(hold);

                // 添加活动状态
                int state = Convert.ToInt32(activity.ActivityState);
                item.SubItems.Add(MyPara.states[state].ToString());
                
                // 添加活动报名人数
                item.SubItems.Add(activity.Signed + "/" + activity.MaxSigned);

                Activities.Items.Add(item);
            }

            conn.Close();

            Paging.ToOrganization(Activities, PageUp, PageDown, this);
            /*foreach (ListViewItem item in Activities.Items)
            {
                if (item.SubItems[6].Text == "未通过" || item.SubItems[6].Text == "审核过期")
                {
                    item.UseItemStyleForSubItems = false;
                    item.SubItems[6].ForeColor = MyPara.warningTextColor;
                }
            }*/
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Form applyActivity = new ApplyActivity(0, "2022121801", this);
            applyActivity.Show();
        }

        private void Query_Click(object sender, EventArgs e)
        { 
            LoadActivity();
        }

        private void QueryDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (QueryDateEnd.Value < QueryDateStart.Value)
                QueryDateEnd.Value = QueryDateStart.Value.AddDays(1);

            QueryDateEnd.MinDate = QueryDateStart.Value.AddDays(1);
        }

        private void QueryName_Enter(object sender, EventArgs e)
        {
            QueryNameHint.Hide();
        }

        private void QueryName_Leave(object sender, EventArgs e)
        {
            QueryName.Text = QueryName.Text.Trim();
            String text = QueryName.Text;
            if (text == "")
                QueryNameHint.Show();
            else
                QueryNameHint.Hide();
        }

        private void QueryNameHint_Click(object sender, EventArgs e)
        {
            QueryNameHint.Hide();
            QueryName.Select();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            resetQuery();
            LoadActivity();
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {
            sideBar1.GetItem1().Click += sideBarItem1_Click;
        }

        private void sideBarItem1_Click(object sender, EventArgs e)
        {
            resetQuery();
            LoadActivity();
        }

        private void resetQuery()
        {
            QueryName.ResetText();
            QueryNameHint.Show();
            QueryDateStart.Value = DateTime.Now.AddYears(-4);
            QueryDateStart.MinDate = DateTime.Now.AddYears(-4);
            QueryDateEnd.Value = DateTime.Now.AddDays(1);
            sideBar1.Select();
        }

        private void QueryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                LoadActivity();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
