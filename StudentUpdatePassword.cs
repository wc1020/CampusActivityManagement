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
    public partial class StudentUpdatePassword : Form
    {
        public StudentUpdatePassword()
        {
            InitializeComponent();
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            //修改的密码要大于等于6位
            //两次输入的密码必须相同
            if (tbNewPwd.Text == tbNewPwdAgain.Text)
            {
                string newPwd = tbNewPwd.Text;
                string studentID = Student.studentID;
                string sql = "update StudentIdentified set studentPassword = @password where studentID = @studentid";
                SqlParameter[] pms = new[]
                {
                    new SqlParameter("@password", newPwd),
                    new SqlParameter("@studentid", studentID)
                };
                SqlConnection sqlConn = Dao.MySqlConnection();
                SqlCommand sqlComm = Dao.MySqlCommand(sql, sqlConn, pms);
                //int result = sqlComm.ExecuteNonQuery();
                if (Convert.ToInt32(sqlComm.ExecuteNonQuery()) > 0)//判断ExecuteNonQuery方法返回的参数是否大于0，大于0表示更改成功
                {
                    MessageBox.Show("更改成功！请重新登录");
                    this.Close();
                    SaveData.student.Close();
                    SaveData.login.Show();
                }
                else
                {
                    MessageBox.Show("更改失败！");
                }
                sqlConn.Close();

            }
            //有文本栏没输入密码
            else if (tbNewPwd.Text == "" || tbNewPwdAgain.Text == "")
            {
                tbNewPwd.Clear();
                tbNewPwdAgain.Clear();
                tbNewPwd.Focus();
                MessageBox.Show("新密码不能为空，请重新输入！");
            }

            //两次输入的新密码不相同
            else
            {
                tbNewPwd.Clear();
                tbNewPwdAgain.Clear();
                tbNewPwd.Focus();
                MessageBox.Show("两次输入的新密码不相同，请重新输入！");

            }
        }

        private void checkShowPwd1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPwd1.Checked)
            {
                tbNewPwd.PasswordChar = default(char);
            }
            else
            {
                tbNewPwd.PasswordChar = '*';
            }
        }

        private void checkShowPwd2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPwd2.Checked)
            {
                tbNewPwdAgain.PasswordChar = default(char);
            }
            else
            {
                tbNewPwdAgain.PasswordChar = '*';
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已退出修改密码界面！");
            this.Close();
        }

        private void StudentUpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
