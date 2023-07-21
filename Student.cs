using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampusActivityManagementSystem
{
    public partial class Student : Form
    {
        // 由于两个子页共用一组搜索框
        public static int queryMode = 1;

        // 用于"全部活动"和"可报名"的切换
        private int state = 5;
        public static string studentID;

        public Student()
        {
            InitializeComponent();
            labReturn.ForeColor = MyPara.exitColor;

            setSelectStyle();
            SelectItem1.ForeColor = MyPara.listButtonColor;
            SelectUnder1.Show();

            panelSignActivity.Show();
            panelSingleInfo.Hide();
        }

        private void labReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            SaveData.login.Show();
           
            //Form form = new Login();
            //form.Show();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            

            SaveData.student = this;//保存student界面至静态类中，方便后续操作
            SaveData.SqlDataReaderLogin.Read();//这里已经将查询结果read了一次
            labStuName.Text = SaveData.SqlDataReaderLogin["studentName"].ToString() + "同学，欢迎!";
            studentID = SaveData.SqlDataReaderLogin["studentID"].ToString();

            ResetQuery();
            LoadAllActivity();

            this.panelSignActivity.Show();
            this.panelSignedActivity.Hide();
            this.panelSingleInfo.Hide();

            // 获取学生学分
            /*SqlConnection conn = Dao.MySqlConnection();
            String sql = "select signedActivity from StudentIdentified where studentID = @studentID";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("studentID", studentID) });

            String signed = "1";
            if (reader.Read())
            {
                if (reader[8].ToString() != "")
                    signed = reader[8].ToString() + "0";
            }

            conn.Close();
*/
            //一加载学生界面就默认自动实现一次sidebarItem1的点击事件
            //sideBarItem1_Click(sender, e);
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {
            //设置Student页面的sideBar样式
            this.sideBar1.SetItem1("活动总览");
            this.sideBar1.SetItem2("我的活动");
            this.sideBar1.SetItem3("个人信息");
            this.sideBar1.HideItem4();
            this.sideBar1.HideItem5();

            sideBar1.GetItem1().Click += sideBarItem1_Click;
            sideBar1.GetItem2().Click += sideBarItem2_Click;
            sideBar1.GetItem3().Click += sideBarItem3_Click;    //sidebar的label3添加点击事件
        }

        /*private void isForm()
        {
            //**如果panel有窗体正在显示，则先关闭该窗体**    
            //因为容器中一次只能打开一个窗口,使用点击按钮的时候需要先判断
            //是否已经有窗口打开了,有就关闭，不然只能打开一次在点击其他没反应
            foreach (Control isForm in this.panelInfo.Controls)
            {
                if (isForm is Form)
                {
                    ((Form)isForm).Close();
                }
            }
        }*/

        private void sideBarItem1_Click(object sender, EventArgs e)
        {
            this.panelSignActivity.Show();
            this.panelSingleInfo.Hide();

            queryMode = 1;
            ResetQuery();
            LoadAllActivity();

            sideBar1.Select();

            SelectItem1.Show();
            SelectItem2.Show();
            setSelectStyle();
            SelectItem1.ForeColor = MyPara.listButtonColor;
            SelectUnder1.Show();
        }

       /* private void sideBarItem1_Click(object sender, EventArgs e)
        {
            //报名活动页面
            this.panelSignActivity.Show();
            this.labSignTitle.Text = "可报名活动";
            //this.panelSignedActivity.Hide();
            this.panelSingleInfo.Hide();
            this.lvSignActivity.Items.Clear();//每次跳转至其他小页面时清空listview的数据


            //this.lvSignActivity = AddLabel.ToStudent(this.lvSignActivity);
            //this.lvSignActivity = Paging.ToStudent(this.lvSignActivity, this.btnUp, this.btnDown);

            string sql = "select * from Activity where activityState between 5 and 8 order by signStartDate";
            SqlConnection sqlConn = Dao.MySqlConnection();
            SqlDataReader mysqlDataReader = Dao.MySqlDateReader(sql, sqlConn);

            while (mysqlDataReader.Read())
            {
                //构建一个ListView的数据，存入数据库数据，以便添加到listView1的行数据中
                ListViewItem lt = new ListViewItem();
                //将数据库数据转变成ListView类型的一行数据
                //ID
                lt.Text = mysqlDataReader["activityID"].ToString();

                //活动名字
                string activityName = mysqlDataReader["activityName"].ToString();
                //活动名称 字符长度限制
                if (activityName.Length >= 8)
                {
                    int x = (activityName.Length + 1) / 2;
                    activityName = activityName.Substring(0, x) + "\n" + activityName.Substring(x, activityName.Length - x);
                }
                lt.SubItems.Add(activityName);

                //举办组织
                string orgID = mysqlDataReader["activityOrgID"].ToString();
                string sqlOrgID = "select organizationName from Organization where organizationID = @orgid";

                SqlConnection sqlConnOrg = Dao.MySqlConnection();
                SqlDataReader sqlDataReaderOrgID = Dao.MySqlDateReader(sqlOrgID, sqlConnOrg, new SqlParameter[] { new SqlParameter("@orgid", orgID) });
                sqlDataReaderOrgID.Read();
                string orgName = sqlDataReaderOrgID["organizationName"].ToString();
                //组织名字 每行字符长度限制
                if (orgName.Length >= 5)
                {
                    int x = (orgName.Length + 1) / 2;
                    orgName = orgName.Substring(0, x) + "\n" + orgName.Substring(x, orgName.Length - x);
                }

                lt.SubItems.Add(orgName);

                //举办地点
                string placeID = mysqlDataReader["activityPlaceID"].ToString();//获取举办地点的ID
                string sqlPlaceID = "select placeName from Place where placeID = @placeid";//再用ID去对应表进行搜索

                SqlConnection sqlConnPlace = Dao.MySqlConnection();
                SqlDataReader sqlDataReaderPlaceID = Dao.MySqlDateReader(sqlPlaceID, sqlConnPlace, new SqlParameter[] {new SqlParameter ("@placeid", Convert.ToInt32(placeID)) });
                sqlDataReaderPlaceID.Read();
                string place = sqlDataReaderPlaceID["placeName"].ToString();//搜索出的结果加入ListView中
                lt.SubItems.Add(place);

                //报名时间
                string signDate = mysqlDataReader["signStartDate"].ToString().Substring(0,9) + " 12:00 至\n" + mysqlDataReader["signEndDate"].ToString().Substring(0, 9) + " 12:00";
                lt.SubItems.Add(signDate);

                //举办时间
                string holdDate = mysqlDataReader["holdDate"].ToString().Substring(0, 9) + " " + mysqlDataReader["holdStart"].ToString() + ":00 至\n" + mysqlDataReader["holdDate"].ToString().Substring(0, 9) + " " + mysqlDataReader["holdEnd"].ToString() + ":00";
                lt.SubItems.Add(holdDate);

                //活动状态，学生端只能看到 >=5 的状态
                lt.SubItems.Add(MyPara.states[Convert.ToInt32(mysqlDataReader["activityState"].ToString())].ToString());

                //学分
                lt.SubItems.Add(mysqlDataReader["availableCredit"].ToString());

                //报名人数
                string signedNum = mysqlDataReader["signed"].ToString() + "/" + mysqlDataReader["maxSigned"].ToString();
                lt.SubItems.Add(signedNum);
                

                //将lt数据添加到listView1控件中
                this.lvSignActivity.Items.Add(lt);
            }
            sqlConn.Close();

            Paging.ToStudent(lvSignActivity, btnUp, btnDown, this);
        }
*/

        private void sideBarItem2_Click(object sender, EventArgs e)
        {
            this.panelSignActivity.Show();
            //this.panelSignedActivity.Hide();
            this.panelSingleInfo.Hide();
            //this.lvSignActivity.Items.Clear();//每次点击已报名活动按钮时自动清空listview里面的数据

            queryMode = 2;
            ResetQuery();
            LoadMyActivity();

            sideBar1.Select();

            SelectItem1.Hide();
            SelectItem2.Hide();
            SelectUnder1.Hide();
            SelectUnder2.Hide();
        }

        private void Query_Click(object sender, EventArgs e)
        {
            if (queryMode == 1)
                LoadAllActivity();

            if (queryMode == 2)
                LoadMyActivity();
        }

        public void LoadAllActivity()
        {
            // 获取搜索条件，其中时间只取日期部分
            String name = QueryName.Text.Trim();
            String org = QueryOrg.Text.Trim();
            String orgID = "%";
            String holdStart = HoldStart.Value.ToString().Split(' ')[0];
            String holdEnd = HoldEnd.Value.ToString().Split(' ')[0];

            if (org != "请选择校组织")
            {
                SqlConnection connOrg = Dao.MySqlConnection();
                String sqlOrg = "select * from Organization where organizationName = @orgName";
                SqlDataReader readerOrg = Dao.MySqlDateReader(sqlOrg, connOrg, 
                    new SqlParameter[] { new SqlParameter("orgName", org) });
                readerOrg.Read();
                orgID = readerOrg[0].ToString();
                connOrg.Close();
            }

            int state1 = 5, state2 = 8;
            if (state == 6)
                state1 = state2 = 6;

            String orderBy = "signStartDate";
            if (OrderBy.Text != "报名开始时间")
            {
                String text = OrderBy.Text;
                if (text == "活动开始时间")
                    orderBy = "holdDate, holdStart";
                if (text == "活动学分")
                    orderBy = "availableCredit";
                if (text == "活动名称")
                    orderBy = "activityName";
            }

            string sql = string.Format("select * from Activity where (activityState between @state1 and @state2) " +
                "and activityName like @activityName and activityOrgID like @orgID " +
                "and (holdDate between @start and @end) order by {0}", orderBy);
            SqlConnection conn = Dao.MySqlConnection();
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { 
                new SqlParameter("state1", state1), new SqlParameter("state2", state2),
                new SqlParameter("activityName", '%' + name + '%'),
                new SqlParameter("orgID", orgID),
                new SqlParameter("start", holdStart),
                new SqlParameter("end", holdEnd) });

            LoadListView(reader);
            conn.Close();
        }

        public void LoadMyActivity()
        {
            // 可以直接用SaveData里面的变量，但那个看不太懂，先用这个
            SqlConnection connMy = Dao.MySqlConnection();
            String sqlMy = "select * from StudentIdentified where studentID = @stuID";
            SqlDataReader readerMy = Dao.MySqlDateReader(sqlMy, connMy,
                new SqlParameter[] { new SqlParameter("stuID", studentID) });   // 仅测试

            String signed = "1", liked = "1";
            if (readerMy.Read())
            {
                if (readerMy[8].ToString() != "")
                    signed = readerMy[8].ToString() + "0";

                if (readerMy[9].ToString() != "")
                    liked = readerMy[9].ToString() + "0";
            }     

            connMy.Close();

            // 获取搜索条件，其中时间只取日期部分
            String name = QueryName.Text.Trim();
            String org = QueryOrg.Text.Trim();
            String orgID = "%";
            String holdStart = HoldStart.Value.ToString().Split(' ')[0];
            String holdEnd = HoldEnd.Value.ToString().Split(' ')[0];

            if (org != "请选择校组织")
            {
                SqlConnection connOrg = Dao.MySqlConnection();
                String sqlOrg = "select * from Organization where organizationName = @orgName";
                SqlDataReader readerOrg = Dao.MySqlDateReader(sqlOrg, connOrg,
                    new SqlParameter[] { new SqlParameter("orgName", org) });
                readerOrg.Read();
                orgID = readerOrg[0].ToString();
                connOrg.Close();
            }

            String orderBy = "signStartDate";
            if (OrderBy.Text != "报名开始时间")
            {
                String text = OrderBy.Text;
                if (text == "活动开始时间")
                    orderBy = "holdDate, holdStart";
                if (text == "活动学分")
                    orderBy = "availableCredit";
                if (text == "活动名称")
                    orderBy = "activityName";
            }

            string sql = string.Format("select * from Activity where (activityState between 5 and 11) " +
                "and activityName like @activityName and activityOrgID like @orgID " +
                "and (holdDate between @start and @end) " +
                "and (activityID in ({1}) or activityID in ({2})) order by {0}", orderBy, signed, liked);
            SqlConnection conn = Dao.MySqlConnection();
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] {
                new SqlParameter("activityName", '%' + name + '%'),
                new SqlParameter("orgID", orgID),
                new SqlParameter("start", holdStart),
                new SqlParameter("end", holdEnd) });

            LoadListView(reader);
            conn.Close();
        }

        // 将reader中的数据装载到listview中
        private void LoadListView(SqlDataReader reader)
        {
            AddLabel.RemoveLabel(lvSignActivity);
            lvSignActivity.Items.Clear();

            while (reader.Read())
            {
                Activity activity = new Activity(reader);
                ListViewItem item = new ListViewItem();

                activity.UpdateState();
                // activity.UpdateState();

                item.Text = activity.ActivityID;
                // 添加活动名称，一行最多8个字
                String AName = activity.ActivityName;
                if (AName.Length >= 8)
                {
                    int x = (AName.Length + 1) / 2;
                    AName = AName.Substring(0, x) + "\n" + AName.Substring(x, AName.Length - x);
                }
                item.SubItems.Add(AName);

                //添加主办组织
                SqlConnection connOrg = Dao.MySqlConnection();
                String sqlOrg = "select organizationName from Organization where organizationID = @orgID";
                SqlDataReader readerOrg = Dao.MySqlDateReader(sqlOrg, connOrg, 
                    new SqlParameter[] { new SqlParameter("orgID", activity.ActivityOrgID) });
                readerOrg.Read();
                String orgName = readerOrg[0].ToString();
                if (orgName.Length >= 5)
                {
                    int x = (orgName.Length + 1) / 2;
                    orgName = orgName.Substring(0, x) + "\n" + orgName.Substring(x, orgName.Length - x);
                }
                item.SubItems.Add(orgName);
                connOrg.Close();

                // 添加活动举办地点
                SqlConnection connPlace = Dao.MySqlConnection();
                String sql = "select placeName from Place where placeID = @placeID";
                SqlDataReader onceReader = Dao.MySqlDateReader(sql, connPlace, 
                    new SqlParameter[] { new SqlParameter("placeID", Convert.ToInt32(activity.ActivityPlaceID)) });
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

                int credit = Convert.ToInt32(activity.AvailableCredit);
                item.SubItems.Add(credit.ToString());

                // 添加活动报名人数
                item.SubItems.Add(activity.Signed + "/" + activity.MaxSigned);

                lvSignActivity.Items.Add(item);
            }

            Paging.ToStudent(lvSignActivity, btnUp, btnDown, this);
        }

        private void ResetQuery()
        {
            QueryName.Text = "";
            NameHint.Show();
            QueryOrg.Text = "请选择校组织";
            HoldStart.Value = DateTime.Now;
            HoldEnd.Value = DateTime.Now.AddYears(1);
            OrderBy.Text = "报名开始时间";

            state = 5;
        }

        private void setSelectStyle()
        {
            SelectItem1.ForeColor = Color.Black;
            SelectItem2.ForeColor = Color.Black;
            SelectUnder1.Hide();
            SelectUnder2.Hide();
        }

        private void SelectItem1_Click(object sender, EventArgs e)
        {
            sideBar1.Select();

            ResetQuery();
            setSelectStyle();
            SelectItem1.ForeColor = MyPara.listButtonColor;
            SelectUnder1.Show();
            state = 5;
            LoadAllActivity();
        }

        private void SelectItem2_Click(object sender, EventArgs e)
        {
            sideBar1.Select();

            ResetQuery();
            setSelectStyle();
            SelectItem2.ForeColor = MyPara.listButtonColor;
            SelectUnder2.Show();
            state = 6;
            LoadAllActivity();
        }

        private void NameHint_Click(object sender, EventArgs e)
        {
            NameHint.Hide();
            QueryName.Select();
        }

        private void QueryName_Leave(object sender, EventArgs e)
        {
            QueryName.Text = QueryName.Text.Trim();
            String text = QueryName.Text;

            if (text == "")
                NameHint.Show();
            else
                NameHint.Hide();
        }

        private void QueryName_Enter(object sender, EventArgs e)
        {
            NameHint.Hide();
        }

        private void Flush_Click(object sender, EventArgs e)
        {
            ResetQuery();

            if (queryMode == 1)
            {
                LoadAllActivity();
                setSelectStyle();
                SelectItem1.ForeColor = MyPara.listButtonColor;
                SelectUnder1.Show();
            }

            if (queryMode == 2)
                LoadMyActivity();
        }

        private void QueryOrg_Enter(object sender, EventArgs e)
        {
            QueryOrg.Items.Clear();

            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from Organization";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn);

            while (reader.Read())
            {
                QueryOrg.Items.Add(reader[1].ToString());
            }
        }

        private void OrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (queryMode == 1)
                LoadAllActivity();

            if (queryMode == 2)
                LoadMyActivity();
        }

        private void HoldStart_ValueChanged(object sender, EventArgs e)
        {
            if (HoldEnd.Value < HoldStart.Value)
                HoldEnd.Value = HoldStart.Value.AddDays(1);

            HoldEnd.MinDate = HoldStart.Value.AddDays(1);
        }

        private void sideBarItem3_Click(object sender, EventArgs e)
        {
            //浏览学生个人信息panel加载
            //this.panelInfo.Show();
            //isForm();         

            /*StudentSingleInformation studentSingleInformation = new StudentSingleInformation();  //实例化
            studentSingleInformation.TopLevel = false;                        //窗体是否顶层
            studentSingleInformation.Parent = this.panelInfo;           //设置该窗体的父容器
            this.panelInfo.Controls.Add(studentSingleInformation);      //将该窗体加入父容器中
            studentSingleInformation.Show();  */
            //创建需要跳转出来的panel控件


            this.panelSignActivity.Hide();
            //this.panelSignedActivity.Hide();
            this.panelSingleInfo.Show();
            /*SaveData.SqlDataReaderStuActInfo = SaveData.SqlDataReaderLogin;
            //SaveData.SqlDataReaderStuActInfo.Read();  //在学生主窗体加载时已经Read了一次
            //学号
            labID.Text = SaveData.SqlDataReaderStuActInfo["studentID"].ToString();
            //姓名
            labName.Text = SaveData.SqlDataReaderStuActInfo["studentName"].ToString();
            //班级
            labClass.Text = SaveData.SqlDataReaderStuActInfo["class"].ToString();
            //性别
            labGender.Text = SaveData.SqlDataReaderStuActInfo["gender"].ToString();
            //联系方式
            labPhone.Text = SaveData.SqlDataReaderStuActInfo["phone"].ToString();
            //学科
            labMaj.Text = SaveData.SqlDataReaderStuActInfo["major"].ToString();
            //学分
            labCredit.Text = SaveData.SqlDataReaderStuActInfo["credit"].ToString();
            //密码
            tbPwd.Text = SaveData.SqlDataReaderStuActInfo["studentPassword"].ToString();*/


            String picPath = @"../../Resources/" + studentID + ".png";
            Picture.Image = Image.FromFile(picPath);
            
            SqlConnection conn = Dao.MySqlConnection();
            String sql = "select * from StudentIdentified where studentID = @studentID";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("studentID", studentID) } );
            reader.Read();

            //学号
            labID.Text = reader[0].ToString();
            //姓名
            labName.Text = reader[2].ToString();
            //班级
            labClass.Text = reader[5].ToString();
            //性别
            labGender.Text = reader[3].ToString();
            //联系方式
            labPhone.Text = reader[6].ToString();
            //学科
            labMaj.Text = reader[4].ToString();
            //学分
            labCredit.Text = reader[7].ToString();
            //密码
            tbPwd.Text = reader[1].ToString(); 
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            StudentUpdatePassword studentUpdatePassword = new StudentUpdatePassword();
            studentUpdatePassword.ShowDialog();
            //修改的密码要大于等于6位
            //两次输入的密码必须相同
            /*if (tbNewPwd.Text == tbNewPwdAgain.Text)
            {
                string newPwd = tbNewPwd.Text;
                string studentID = SaveData.SqlDataReaderStuActInfo["studentID"].ToString();
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
                    MessageBox.Show("更改成功！");
                }
                else
                {
                    MessageBox.Show("更改失败！");
                }
                sqlConn.Close();

            }
            //否则清空输入栏并重新输入
            else
            {
                tbNewPwd.Clear();
                tbNewPwdAgain.Clear();
                tbNewPwd.Focus();
                MessageBox.Show("两次输入的新密码不相同，请重新输入！");
                
            }*/



        }
   
        private void checkShowOldPwd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkShowOldPwd.Checked)
            {
                tbPwd.PasswordChar = default;
            }
            else
            {
                tbPwd.PasswordChar = '*';
            }
        }

        private void panelSignActivity_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
