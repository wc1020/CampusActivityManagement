using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    public partial class ApplyActivity : Form
    {
        // mode == 1时用activityID获取activity
        private int mode;
        private String activityID;
        Activity activity;
        private int placeID;
        private Org form;
        public ApplyActivity(int mode, String activityID, Org form)
        {
            InitializeComponent();
            this.Select();
            this.mode = mode;
            this.activityID = activityID;
            this.form = form;

            HintLabelName.SetText("活动名称");
            HintLabelIntro.SetText("活动介绍");
            HintLabelPlace.SetText("举办地点");
            HintLabelHold.SetText("举办时间");
            HintLabelSign.SetText("报名时间");
            HintLabelVolume.SetText("人数上限");
            HintLabelCredit.SetText("活动学分");

            /*HoldDate.MinDate = DateTime.Now.AddDays(3);
            SignStart.MinDate = DateTime.Now.AddDays(1);
            SignEnd.MinDate = DateTime.Now.AddDays(2);*/

            HoldDate.Value = DateTime.Now.AddDays(3);
            SignStart.Value = DateTime.Now.AddDays(1);
            SignEnd.Value = DateTime.Now.AddDays(2);
        }

        private void ApplyActivity_Load(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                Text = "活动信息修改";

                SqlConnection conn = Dao.MySqlConnection();
                String sql = "select * from Activity where activityID = @activityID";
                SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("activityID", activityID) });
                reader.Read();
                activity = new Activity(reader);
                conn.Close();

                // 存放活动名称和活动介绍
                AName.Text = activity.ActivityName;
                Intro.Text = activity.ActivityIntro;

                // 获取活动地点
                placeID = Convert.ToInt32(activity.ActivityPlaceID);

                SqlConnection connPlace = Dao.MySqlConnection();
                sql = "select placeName from Place where placeID = @placeID";
                SqlDataReader onceReader = Dao.MySqlDateReader(sql, connPlace, new SqlParameter[] { new SqlParameter("placeID", Convert.ToInt32(activity.ActivityPlaceID))});
                onceReader.Read();
                Place.Text = onceReader[0].ToString();
                connPlace.Close();

                // 获取举办日期
                HoldDate.Value = Convert.ToDateTime(activity.HoldDate);

                // 获取举办时间
                HoldStart.Text = activity.HoldStart + ":00";
                HoldEnd.Text = activity.HoldEnd + ":00";

                // 获取报名起止日期
                SignStart.Value = Convert.ToDateTime(activity.SignStartDate);
                SignEnd.Value = Convert.ToDateTime(activity.SignEndDate);

                // 获取人数限制
                Volume.Value = Convert.ToInt32(activity.MaxSigned);

                // 获取学分
                Credit.Value = Convert.ToInt32(activity.AvailableCredit);

                HintName.Hide();
                HintIntro.Hide();
                HoldDate.Enabled = true;
                HoldStart.Enabled = true;
                HoldEnd.Enabled = true;
                SignStart.Enabled = true;
                SignEnd.Enabled = true;

                if (activity.ActivityState == "3" || activity.ActivityState == "4")
                {
                    SubmitButton.Text = "重新提交";
                }
            }
        }

        private void AName_TextChanged(object sender, EventArgs e)
        {
            String text = AName.Text;
            NameCount.Text = text.Length + "/15";

            if (text.Length > 15)
                NameCount.ForeColor = MyPara.warningTextColor;
            else
                NameCount.ForeColor = Color.Black;
        }

        private void Intro_TextChanged(object sender, EventArgs e)
        {
            String text = Intro.Text;
            IntroCount.Text = text.Length + "/200";

            if (text.Length > 200)
                IntroCount.ForeColor = MyPara.warningTextColor; 
            else
                IntroCount.ForeColor = Color.Black;
        }

        private void AName_Enter(object sender, EventArgs e)
        {
            HintName.Hide();
        }

        private void AName_Leave(object sender, EventArgs e)
        {
            AName.Text = AName.Text.Trim();
            if (AName.Text == "")           
                HintName.Show();
            else
                HintName.Hide();
        }

        private void Intro_Enter(object sender, EventArgs e)
        {
            HintIntro.Hide();
        }

        private void Intro_Leave(object sender, EventArgs e)
        {
            Intro.Text = Intro.Text.Trim();
            if (Intro.Text == "")
                HintIntro.Show();
            else
                HintIntro.Hide();
        }

        private void HintName_Click(object sender, EventArgs e)
        {
            HintName.Hide();
            AName.Select();
        }

        private void HintIntro_Click(object sender, EventArgs e)
        {
            HintIntro.Hide();
            Intro.Select();
        }

        private void Place_Enter(object sender, EventArgs e)
        {
            Place.Items.Clear();

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from Place";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn);

            while (reader.Read())
            {
                Place.Items.Add(reader[1].ToString());
            }

            conn.Close();
        }

        private void Place_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HoldStart.Enabled = true;
            HoldStart.SelectedItem = null;
            HoldStart.Text = "开始";

            HoldEnd.Enabled = false;
            HoldEnd.SelectedItem = null;
            HoldEnd.Text = "结束";

            SqlConnection connPlace = Dao.MySqlConnection();
            String sqlPlace = "select placeID from Place where placeName = @placeName";
            SqlDataReader readerPlace = Dao.MySqlDateReader(sqlPlace, connPlace,
                new SqlParameter[] { new SqlParameter("placeName", Place.SelectedItem.ToString()) });

            readerPlace.Read();
            placeID = Convert.ToInt32(readerPlace[0]);
            connPlace.Close();
        }

        private void HoldDate_ValueChanged(object sender, EventArgs e)
        {
            if (Place.SelectedItem != null)
                HoldStart.Enabled = true;
            HoldStart.SelectedItem = null;
            HoldStart.Text = "开始";

            HoldEnd.Enabled = false;
            HoldEnd.SelectedItem = null;
            HoldEnd.Text = "结束";
        }

        private void HoldDate_Leave(object sender, EventArgs e)
        {
           
        }

        private void HoldStart_Enter(object sender, EventArgs e)
        {
            HoldStart.Items.Clear();

            List<int> hours = new List<int>();
            for (int i = 0; i <= 11; ++i)
                hours.Add(i + 10);

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select holdStart, holdEnd from Activity " +
                "where activityPlaceID = @placeID and holdDate = @holdDate";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn,
                new SqlParameter[] { new SqlParameter("placeID", placeID), new SqlParameter("holdDate", HoldDate.Value.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)) }); 

            while (reader.Read())
            {
                int start = Convert.ToInt32(reader[0]);
                int end = Convert.ToInt32(reader[1]);

                for (int i = start; i < end; ++i)
                {
                    if (hours.Contains(i))
                    {
                        hours.Remove(i);
                    }
                }
            }

            if (hours.Count == 0)
            {
                // 弹出提示 该场地该日已被占满
                HoldStart.Text = "开始";
                HoldStart.Enabled = false;
                Place.Select();
                conn.Close();
                return;
            }

            foreach (int hour in hours)
            {
                HoldStart.Items.Add(hour + ":00");
            }

            conn.Close();
        }

        private void HoldStart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HoldEnd.Enabled = true;
            HoldEnd.Text = "结束";
            HoldEnd.SelectedItem = null;
        }

        private void HoldEnd_Enter(object sender, EventArgs e)
        {
            HoldEnd.Items.Clear();

            List<int> hours = new List<int>();
            for (int i = 0; i <= 11; ++i)
                hours.Add(i + 11);

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select holdStart, holdEnd from Activity " +
                "where activityPlaceID = @placeID and holdDate = @holdDate";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn,
                new SqlParameter[] { new SqlParameter("placeID", placeID), new SqlParameter("holdDate", HoldDate.Value.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)) });

            int minStart = 24;
            int maxEnd = 0;
            while (reader.Read())
            {
                int start = Convert.ToInt32(reader[0]);
                int end = Convert.ToInt32(reader[1]);

                minStart = Math.Min(minStart, start);
                maxEnd = Math.Max(maxEnd, end);
            }

            int holdStart = Convert.ToInt32(HoldStart.SelectedItem.ToString().Substring(0, 2));

            for (int i = 11; i <= holdStart; ++i)
            {
                if (hours.Contains(i))
                {
                    hours.Remove(i);
                }
            }

            if (holdStart < minStart)
            {
                for (int i = minStart + 1; i <= 22; ++i)
                {
                    if (hours.Contains(i))
                        hours.Remove(i);
                }  
            }

            foreach (int hour in hours)
            {
                HoldEnd.Items.Add(hour + ":00");
            }

            conn.Close();
        }

        private bool CheckDate()
        {
            if (HoldDate.Value <= SignStart.Value || HoldDate.Value <= SignEnd.Value || SignStart.Value >= SignEnd.Value)
            {
                MessageBox.Show("日期之间有冲突，请重新选择！", "DATE CONFLICT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (SignStart.Value <= DateTime.Now || SignEnd.Value <= DateTime.Now || HoldDate.Value <= DateTime.Now)
            {
                MessageBox.Show("任何日期不得早于今日，请重新选择！", "DATE CONFLICT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool AllCheck()
        {
            if (AName.Text.Trim() == "" || Intro.Text.Trim() == "" || 
                HoldStart.Enabled == false || HoldEnd.Enabled == false || Volume.Value == 0 || Credit.Value == 0)
            {
                MessageBox.Show("信息填写不完整！", "NOT INTEGRATED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (AName.Text.Length > 15 || Intro.Text.Length > 200)
            {
                MessageBox.Show("信息填写有误，请检查！", "WORDAGE OVERFLOW", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }   

            return CheckDate();
        }

        private void SaveActivity()
        {
            if (mode == 0)
                activity = new Activity();

            activity.ActivityName = AName.Text.Trim();
            activity.ActivityIntro = Intro.Text.Trim();
            activity.ActivityPlaceID = placeID.ToString();
            activity.ActivityOrgID = Org.orgID;
            activity.AvailableCredit = Credit.Value.ToString();
            activity.MaxSigned = Volume.Value.ToString();
            activity.SignStartDate = Convert.ToDateTime(SignStart.Value).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            activity.SignEndDate = Convert.ToDateTime(SignEnd.Value).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            activity.HoldDate = Convert.ToDateTime(HoldDate.Value).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            activity.HoldStart = HoldStart.Text.ToString().Substring(0, 2);
            activity.HoldEnd = HoldEnd.Text.ToString().Substring(0, 2);

            if (mode == 1)
                activity.Update();
            else if (mode == 0)
            {
                activity.Create();
                mode = 1;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AllCheck())
            {
                SaveActivity();
                MessageBox.Show("保存成功！", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.LoadActivity();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (AllCheck())
            {
                SaveActivity();
                activity.SubmitTime = DateTime.Now.ToString();
                activity.ActivityState = "2";
                activity.Update();

                if (MessageBox.Show("提交成功！", "SUBMIT", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    form.LoadActivity();
                    Close();
                }
            }          
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
