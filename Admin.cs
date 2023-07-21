using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    public partial class Admin : Form
    {
        private int state = 1;
        public Admin()
        {
            InitializeComponent();
            sideBar1.HideItem3();
            sideBar1.HideItem4();
            sideBar1.HideItem5();
            sideBar1.SetItem1("活动管理");
            sideBar1.SetItem2("场地管理");

            Exit.ForeColor = MyPara.exitColor;

            SelectUnder1.BackColor = MyPara.listButtonColor;
            SelectUnder2.BackColor = MyPara.listButtonColor;
            SelectUnder3.BackColor = MyPara.listButtonColor;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ActivityPanel.Show();
            PlacePanel.Hide();
            ActivityPanel.Select();

            resetActivityQuery();

            LoadActivity();
        }

        private void setSelectStyle()
        {
            SelectItem1.ForeColor = Color.Black;
            SelectItem2.ForeColor = Color.Black;
            SelectItem3.ForeColor = Color.Black;
            SelectUnder1.Hide();
            SelectUnder2.Hide();
            SelectUnder3.Hide();
        }

        private void setSelectText()
        {
            SelectItem1.Text = "全部活动";

            SqlConnection conn1 = Dao.MySqlConnection();
            String sql1 = "select count(*) from Activity where activityState = @state";
            SqlDataReader reader1 = Dao.MySqlDateReader(sql1, conn1, new SqlParameter[]{ new SqlParameter("state", 2)});
            if (reader1.Read())
                SelectItem2.Text = "待审核(" + reader1[0].ToString() + ")";
            else
                SelectItem2.Text = "待审核(0)";
            conn1.Close();

            SqlConnection conn2 = Dao.MySqlConnection();
            String sql2 = "select count(*) from Activity where activityState = @state";
            SqlDataReader reader2 = Dao.MySqlDateReader(sql2, conn2, new SqlParameter[] { new SqlParameter("state", 10) });
            if (reader2.Read())
                SelectItem3.Text = "待完成(" + reader2[0].ToString() + ")";
            else
                SelectItem3.Text = "待完成(0)";
            conn2.Close();
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {
            sideBar1.GetItem1().Click += sideBarItem1_Click;
            sideBar1.GetItem2().Click += sideBarItem2_Click;
            
        }

        private void sideBarItem1_Click(object sender, EventArgs e)
        {
            ActivityPanel.Show();
            PlacePanel.Hide();

            resetActivityQuery();
           
        }

        private void sideBarItem2_Click(object sender, EventArgs e)
        {
            ActivityPanel.Hide();
            PlacePanel.Show();

            resetPlaceQuery();

            LoadPlace();
        }

        public void LoadActivity()
        {
            AddLabel.RemoveLabel(AdminActivityView);
            if (AdminActivityView.Columns.Count == 0)
            {
                AdminActivityView.Clear();
                AdminActivityView.Columns.Add("");
                AdminActivityView.Columns.Add("活动名称");
                AdminActivityView.Columns.Add("申请组织");
                AdminActivityView.Columns.Add("申请时间");
                AdminActivityView.Columns.Add("举办地点");
                AdminActivityView.Columns.Add("报名时间段");
                AdminActivityView.Columns.Add("举办时间段");
                AdminActivityView.Columns.Add("活动状态");
                AdminActivityView.Columns.Add("操作");
                AdminActivityView.Columns[0].Width = 0;
                AdminActivityView.Columns[1].Width = 120;
                AdminActivityView.Columns[2].Width = 92;
                AdminActivityView.Columns[3].Width = 90;
                AdminActivityView.Columns[4].Width = 90;
                AdminActivityView.Columns[5].Width = 150;
                AdminActivityView.Columns[6].Width = 150;
                AdminActivityView.Columns[7].Width = 90;
                AdminActivityView.Columns[8].Width = 100;
                foreach (ColumnHeader column in AdminActivityView.Columns)
                {
                    column.TextAlign = HorizontalAlignment.Center;
                }
            }
           
            AdminActivityView.Items.Clear();
            String name = QueryActivityName.Text.Trim();
            String place = QueryActivityPlace.Text.Trim();

            SqlConnection conn = Dao.MySqlConnection();
            String sql;
            if (state == 1)
                sql = "select * from Activity where activityName like @activityName and activityState > @state";
            else
                sql = "select * from Activity where activityName like @activityName and activityState = @state";
            sql += " order by activityState, signStartDate";
            SqlParameter[] paras = new SqlParameter[] { new SqlParameter("activityName", "%" + name + "%"), new SqlParameter("state", state)};
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, paras);

            while (reader.Read())
            {
                //用reader初始化一个Activity对象，可以直接获取相关信息
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

                // 添加活动申请组织
                SqlConnection connOrg = Dao.MySqlConnection();
                sql = "select organizationName from Organization where organizationID = @orgID";
                SqlDataReader orgReader = Dao.MySqlDateReader(sql, connOrg, new SqlParameter[] { new SqlParameter("orgID", activity.ActivityOrgID) });
                orgReader.Read();
                String orgName = orgReader[0].ToString();
                if (orgName.Length >= 5)
                {
                    int x = (orgName.Length + 1) / 2;
                    orgName = orgName.Substring(0, x) + "\n" + orgName.Substring(x, orgName.Length - x);
                }
                item.SubItems.Add(orgName);
                connOrg.Close();

                // 添加活动申请时间，日期与时间不同行
                String submit = activity.SubmitTime.Substring(0, 10) + "\n" + activity.SubmitTime.Substring(11, 8);
                item.SubItems.Add(submit);

                // 添加活动举办地点
                SqlConnection connPlace = Dao.MySqlConnection();
                sql = "select placeName from Place where placeID = @placeID";
                SqlDataReader placeReader = Dao.MySqlDateReader(sql, connPlace, new SqlParameter[] { new SqlParameter("placeID", Convert.ToInt32(activity.ActivityPlaceID)) });
                placeReader.Read();
                item.SubItems.Add(placeReader[0].ToString());
                if (!placeReader[0].ToString().Contains(place))
                {
                    connPlace.Close();
                    continue;
                }
                connPlace.Close();

                // 添加活动报名时间段
                String sign = activity.SignStartDate + " 12:00 至\n" + activity.SignEndDate + " 12:00";
                item.SubItems.Add(sign);

                // 添加活动举办时间段
                String hold = activity.HoldDate + " " + activity.HoldStart + ":00 至\n" + activity.HoldDate + " " + activity.HoldEnd + ":00";
                item.SubItems.Add(hold);

                // 添加活动状态
                item.SubItems.Add(MyPara.states[Convert.ToInt32(activity.ActivityState)].ToString());

                AdminActivityView.Items.Add(item);
            }

            conn.Close();

            Paging.ToSchool(AdminActivityView, PageUp1, PageDown1, this);

            /*foreach (ListViewItem item in AdminActivityView.Items)
            {
                if (item.SubItems[7].Text == "未通过" || item.SubItems[7].Text == "审核过期")
                {
                    item.UseItemStyleForSubItems = false;
                    item.SubItems[7].ForeColor = MyPara.warningTextColor;
                }
            }*/

        }

        public void LoadPlace()
        {
            AddLabel.RemoveLabel(AdminPlaceView);
            AdminPlaceView.Items.Clear();

            String name = QueryPlaceName.Text.Trim();

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from Place where placeName like @placeName";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("placeName", '%' + name + '%') });
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = reader[0].ToString();

                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());

                String start = Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                String end = Convert.ToDateTime(reader[4]).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);

                item.SubItems.Add(start + " 至 " + end);

                item.SubItems.Add("10:00 - 22:00");

                AdminPlaceView.Items.Add(item);
            }
            conn.Close();

            Paging.ToPlace(AdminPlaceView, PageUp2, PageDown2, this);
        }

        private void Query_Click(object sender, EventArgs e)
        {
            LoadActivity();
        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = QueryState.SelectedIndex + 2;
        }

        private void resetActivityQuery()
        {
            ActivityPanel.Select();
            QueryActivityName.ResetText();
            ActivityNameHint.Show();
            QueryActivityPlace.ResetText();
            ActivityPlaceHint.Show();
            QueryState.SelectedItem = null;
            QueryState.Text = "请选择活动状态";

            setSelectText();
            setSelectStyle();
            SelectItem1.ForeColor = MyPara.listButtonColor;
            SelectUnder1.Show();
            state = 1;
            LoadActivity();
            QueryState.Enabled = true;
        }

        private void Flush_Click(object sender, EventArgs e)
        {
            resetActivityQuery();
            state = 1;
            LoadActivity();
        }

        private void ActivityNameHint_Click(object sender, EventArgs e)
        {
            ActivityNameHint.Hide();
            QueryActivityName.Select();
        }

        private void QueryActivityName_Enter(object sender, EventArgs e)
        {
            ActivityNameHint.Hide();
        }

        private void QueryActivityName_Leave(object sender, EventArgs e)
        {
            QueryActivityName.Text = QueryActivityName.Text.Trim();
            String text = QueryActivityName.Text;
            if (text == "")
                ActivityNameHint.Show();
            else
                ActivityNameHint.Hide();
        }

        private void QueryActivityPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActivityPlaceHint_Click(object sender, EventArgs e)
        {
            ActivityPlaceHint.Hide();
            QueryActivityPlace.Select();
        }

        private void QueryActivityPlace_Enter(object sender, EventArgs e)
        {
            ActivityPlaceHint.Hide();
        }

        private void QueryActivityPlace_Leave(object sender, EventArgs e)
        {
            QueryActivityPlace.Text = QueryActivityPlace.Text.Trim();
            String text = QueryActivityPlace.Text;
            if (text == "")
                ActivityPlaceHint.Show();
            else
                ActivityPlaceHint.Hide();
        }

        private void SelectItem1_Click(object sender, EventArgs e)
        {
            resetActivityQuery();
            setSelectStyle();
            SelectItem1.ForeColor = MyPara.listButtonColor;
            SelectUnder1.Show();
            state = 1;
            LoadActivity();
            QueryState.Enabled = true;
        }

        private void SelectItem2_Click(object sender, EventArgs e)
        {
            resetActivityQuery();
            setSelectStyle();
            SelectItem2.ForeColor = MyPara.listButtonColor;
            SelectUnder2.Show();
            state = 2;
            LoadActivity();
            QueryState.Enabled = false;
        }

        private void SelectItem3_Click(object sender, EventArgs e)
        {
            resetActivityQuery();
            setSelectStyle();
            SelectItem3.ForeColor = MyPara.listButtonColor;
            SelectUnder3.Show();
            state = 10;
            LoadActivity();
            QueryState.Enabled = false;
        }

        private void QueryPlaceNameHint_Click(object sender, EventArgs e)
        {
            QueryPlaceNameHint.Hide();
            QueryPlaceName.Select();
        }

        private void QueryPlaceName_Enter(object sender, EventArgs e)
        {
            QueryPlaceNameHint.Hide();
        }

        private void QueryPlaceName_Leave(object sender, EventArgs e)
        {
            QueryPlaceName.Text = QueryPlaceName.Text.Trim();
            String text = QueryPlaceName.Text;
            if (text == "")
                QueryPlaceNameHint.Show();
            else
                QueryPlaceNameHint.Hide();
        }

        private void QueryPlace_Click(object sender, EventArgs e)
        {
            LoadPlace();
        }

        private void resetPlaceQuery()
        {
            PlacePanel.Select();
            QueryPlaceName.ResetText();
            QueryPlaceNameHint.Show();
            
        }

        private void FlushPlace_Click(object sender, EventArgs e)
        {
            resetPlaceQuery();

            LoadPlace();
        }

        private void QueryPlaceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                QueryPlace_Click(sender, e);
        }

        private void QueryActivityPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Query_Click(sender, e);
        }

        private void PlacePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
