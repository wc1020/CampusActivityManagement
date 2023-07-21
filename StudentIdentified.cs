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
    public partial class StudentIdentified : Form
    {
        public StudentIdentified()
        {
            InitializeComponent();
        }

        private void StudentIdentified_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已取消认证!");
            this.Close();
            //Login login = new Login();
            //SaveData.login.Show();
            
        }

        private void btnIde_Click(object sender, EventArgs e)
        {
            //
            
            String textboxID = this.tbID.Text;
            string textboxName = this.tbName.Text;
            string radSex;
            //获取男或女字符
            if (radMan.Checked ) 
            {
                radSex = radMan.Text;
            }
            else
            {
                radSex = radWomen.Text;
            }
            string major = this.cbMajor.SelectedItem.ToString();
            string stuClass = this.cbClass.SelectedItem.ToString();
            string phone = this.tbPhone.Text;

            
            string sqlIsStu = "select * from Student where studentID = @studentid and studentName = @stuname and gender = @gender and major = @major and class = @class";
            SqlParameter[] pmsIsStu = new[]
            {
                new SqlParameter("@studentid", textboxID),
                new SqlParameter("@stuname", textboxName),
                new SqlParameter("@gender", radSex),
                new SqlParameter("@major", major),
                new SqlParameter("@class", stuClass)
            };
            SqlConnection sqlConn = Dao.MySqlConnection();
            SqlDataReader sqlDataReaderIsStu = Dao.MySqlDateReader(sqlIsStu, sqlConn, pmsIsStu);
            //验证是否为学校学生
            //是
            if (sqlDataReaderIsStu.HasRows)
            {
                //是在校生，将认证学生的数据插入到已认证学生的表中
                string sqlInsert = "insert into StudentIdentified(studentID, studentPassword, studentName, gender, major, class, phone, credit, signedActivity, likedActivity) " +
                    "values(@studentid, @stuPwd, @stuName, @gender, @major, @class, @phone, @credit, @signedA, @likedA)";
                SqlParameter[] pmsInsert = new[]
                {
                    new SqlParameter("@studentid", textboxID),
                    new SqlParameter("@stuPwd", "123456"),
                    new SqlParameter("@stuName", textboxName),
                    new SqlParameter("@gender", radSex),
                    new SqlParameter("@major", major),
                    new SqlParameter("@class", stuClass),
                    new SqlParameter("@phone", phone),
                    new SqlParameter("@credit", "0"),
                    new SqlParameter("@signedA", ""),
                    new SqlParameter("@likedA", "")
                };
                SqlConnection sqlConnInsert = Dao.MySqlConnection();
                SqlCommand sqlcmdInsert = Dao.MySqlCommand(sqlInsert, sqlConnInsert, pmsInsert);
                
                if (Convert.ToInt32(sqlcmdInsert.ExecuteNonQuery()) > 0)//判断ExecuteNonQuery方法返回的参数是否大于0，大于0表示插入成功
                {
                    MessageBox.Show("学生认证成功，请进行登录！\n密码默认为：123456\n请尽快前往个人信息修改默认密码！");
                    this.Close();
                    //SaveData.login.Show();
                }
                else
                {
                    MessageBox.Show("学生认证信息添加失败！");
                }
            }

            //不是
            else
            {
                //不清空已输入的数据
                MessageBox.Show("该学生不是我校学生，请重新修改认证信息！");
            }

        }
    }
}
