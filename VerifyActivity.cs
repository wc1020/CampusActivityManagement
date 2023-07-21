using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    public partial class VerifyActivity : Form
    {
        private String activityID;
        private Admin form;
        public VerifyActivity(String activityID, Admin form)
        {
            this.activityID = activityID;
            this.form = form;
            InitializeComponent();
            
        }

        private void VerifyActivity_Load(object sender, EventArgs e)
        {
            ReasonLabel.SetText("不通过原因：");
            ReasonLabel.HideIcon();
        }

        private void ReasonHint_Click(object sender, EventArgs e)
        {
            ReasonHint.Hide();
            Reason.Select();
        }

        private void Reason_Enter(object sender, EventArgs e)
        {
            ReasonHint.Hide();
        }

        private void Reason_Leave(object sender, EventArgs e)
        {
            Reason.Text = Reason.Text.Trim();
            String text = Reason.Text;

            if (text == "")
                ReasonHint.Show();
            else
                ReasonHint.Hide();
        }

        private void Reason_TextChanged(object sender, EventArgs e)
        {
            String text = Reason.Text;
            ReasonCount.Text = text.Length + "/25";

            if (text.Length > 25)
                ReasonCount.ForeColor = MyPara.warningTextColor;
            else
                ReasonCount.ForeColor = Color.Black;
        }

        private void Pass_CheckedChanged(object sender, EventArgs e)
        {
            ReasonLabel.HideIcon();
        }

        private void Fail_CheckedChanged(object sender, EventArgs e)
        {
            ReasonLabel.ShowIcon();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from Activity where activityID = @activityID";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("activityID", activityID) });
            reader.Read();
            Activity activity = new Activity(reader);
            conn.Close();

            if (Fail.Checked)
            {
                if (Reason.Text.Trim() == "")
                {
                    MessageBox.Show("请填写审核不通过原因！", "NOT INTEGRATED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Reason.Text.Length > 25)
                {
                    MessageBox.Show("原因的字数过多！", "WORDAGE OVERFLOW", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection connCount = Dao.MySqlConnection();
                    String sqlCount = "select count(*) from FailReason where activityID = @activityID";
                    SqlDataReader readerCount = Dao.MySqlDateReader(sqlCount, connCount, 
                        new SqlParameter[] { new SqlParameter("activityID", activityID) });
                    readerCount.Read();

                    // 该活动还未有审核不通过记录
                    if (Convert.ToInt32(readerCount[0]) == 0)
                    {
                        connCount.Close();

                        SqlConnection connReason = Dao.MySqlConnection();
                        String sqlReason = "insert into FailReason values(@activityID, @reason)";
                        SqlCommand cmdReason = Dao.MySqlCommand(sqlReason, connReason, 
                            new SqlParameter[] { new SqlParameter("activityID", activityID), new SqlParameter("reason", Reason.Text.Trim()) });
                        cmdReason.ExecuteNonQuery();
                        connReason.Close();
                    }
                    else
                    {
                        SqlConnection connUpdate = Dao.MySqlConnection();
                        String sqlUpdate = "update FailReason set reason = @reason where activityID = @activityID";
                        SqlCommand cmdReason = Dao.MySqlCommand(sqlUpdate, connUpdate,
                            new SqlParameter[] { new SqlParameter("activityID", activityID), new SqlParameter("reason", Reason.Text.Trim()) });
                        cmdReason.ExecuteNonQuery();
                        connUpdate.Close();
                    }

                    activity.ActivityState = "3";
                    activity.Update();
                    MessageBox.Show("不通过理由已反馈！", "VERIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else if (Pass.Checked)
            {
                activity.ActivityState = "5";
                activity.Update();
                CreateSignTable();
                MessageBox.Show("审核成功！", "VERIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }

            form.LoadActivity();
        }

        private void CreateSignTable()
        {
            String tableName = "Enrolled" + activityID;

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "create table " + tableName +
                "(studentID char(10) check (len(studentID) = 10) primary key," +
                "studentName varchar(22) not null," +
                "gender char(2) check (gender in ('男', '女'))," +
                "major varchar(26)," +
                "class varchar(10)," +
                "phone char(11) check (len(phone) = 11) unique," +
                "checked int default 0 check(checked = 0 or checked = 1))";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("tableName", tableName)});
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
