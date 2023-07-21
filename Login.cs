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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //仅登陆页面 登录失败时调用该函数
        //清空输入框内容和已勾选的按钮 并且 将输入指针聚焦在账号栏中
        private void MyClear()
        {
            tbxUser.Clear();//将用户输入框内容清空
            tbxPwd.Clear();
            radSch.Checked = false;//将三个按钮已勾选状态清空
            radOrg.Checked = false;
            radStu.Checked = false;
            tbxUser.Focus();//用户关闭MessageBox弹窗后输入指针会自动聚焦在 账号输入栏 中
        }
        private void MyTipInformation(string tipInfor)
        {
            MessageBox.Show(tipInfor);//错误时弹出提示窗口信息
            MyClear();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string userName = tbxUser.Text.Trim();//用户输入的账号
            string passWord = tbxPwd.Text.Trim();//用户输入的密码
            
            //输入框都不为空
            if (this.tbxUser.Text != "" && this.tbxPwd.Text != "")
            {
                //选择校方登录
                if (radSch.Checked)
                {   //用 @变量名和创建数组 的方式使用sql语句可以 防止注入
                    string sql = "select * from Administration where adminID = @username" +
                        " and adminPassword = @password";
                    //防注入
                    SqlParameter[] pms = new[]
                    {
                        new SqlParameter("@username", userName),
                        new SqlParameter("@password", passWord)
                    };
                    SqlConnection sqlConn = Dao.MySqlConnection();//连接数据库 已打开连接
                    SqlDataReader mysqlDataReader = Dao.MySqlDateReader(sql, sqlConn, pms);
                    //sqlConn.Close();

                    //登录成功
                    if (mysqlDataReader.HasRows)//判断sql语句是否查找到一行或多行结果
                    {
                        MyTipInformation("以校方身份登录成功！");
                        Form form = new Admin();//跳转至 学校端窗体
                        form.Show();

                        //xxxForm.show();   //学校窗体show
                        //this.Hide();      //登录窗体隐藏

                    }
                    //失败
                    else
                    {
                        MyTipInformation("账号或密码错误! ");                    
                    }
                }

                //选择组织登录
                else if (radOrg.Checked)
                {
                    string sql = "select * from Organization where organizationID = @username" +
                        " and organizationPassword = @password";
                    //防注入
                    SqlParameter[] pms = new[]
                    {
                        new SqlParameter("@username", userName),
                        new SqlParameter("@password", passWord)
                    };
                    SqlConnection sqlConn = Dao.MySqlConnection();//连接数据库 已打开连接
                    SqlDataReader mysqlDataReader = Dao.MySqlDateReader(sql, sqlConn, pms);
                    //sqlConn.Close();

                    //登录成功
                    if (mysqlDataReader.HasRows)//判断sql语句是否查找到一行或多行结果
                    {
                        mysqlDataReader.Read();
                        MyTipInformation("以组织身份登录成功！");
                        //跳转至 组织端窗体
                        Form form = new Org(mysqlDataReader[0].ToString(), mysqlDataReader[1].ToString());
                        form.Show();
                        //xxxForm.show();   //组织窗体show
                        //this.Hide();      //登录窗体隐藏

                    }
                    //失败
                    else
                    {
                        MyTipInformation("账号或密码错误! ");
                    }
                }

                //选择学生登录
                else if (radStu.Checked)
                {
                    string sql = "select * from StudentIdentified where studentID = @username" +
                        " and studentPassword = @password";
                    //防注入
                    SqlParameter[] pms = new[]
                    {
                        new SqlParameter("@username", userName),
                        new SqlParameter("@password", passWord)
                    };
                    SqlConnection sqlConn = Dao.MySqlConnection();//连接数据库 已打开连接
                    SqlDataReader mysqlDataReader = Dao.MySqlDateReader(sql, sqlConn, pms);
                    //sqlConn.Close();

                    //登录成功
                    if (mysqlDataReader.HasRows)//判断sql语句是否查找到一行或多行结果
                    {
                        MyTipInformation("以学生身份登录成功！");
                        //跳转至 学生端窗体
                        SaveData.login = this;
                        SaveData.SqlDataReaderLogin = mysqlDataReader;
                        
                        Student studentForm = new Student();
                        studentForm.Show();   //学生窗体show
                        
                        //StudentSingleInformation studentSingleInformation = new StudentSingleInformation();
                        //studentSingleInformation.Show();
                        //this.Hide();      //登录窗体隐藏
                    }
                    //失败
                    else
                    {
                        MyTipInformation("账号或密码错误! ");
                    }

                    sqlConn.Close();
                }
                //都没选
                else
                {
                    MyTipInformation("请选择一种身份登录！");                   
                }

            }
            //输入为空
            else
            {
                MyTipInformation("账号或密码不能为空！");                
            }
                

        }

        private void btnIde_Click(object sender, EventArgs e)
        {
            Form form = new StudentIdentified();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //退出系统并关闭登录窗体
            this.Close();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
