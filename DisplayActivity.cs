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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Globalization;

namespace CampusActivityManagementSystem
{
    public partial class DisplayActivity : Form
    {
        private String idNum;
        private String message;
        public DisplayActivity(String idNum, String message)
        {
            this.idNum = idNum;
            this.message = message;
            InitializeComponent();

            labelNo.Hide();
            labReason.Hide();
        }

        //输入想查询的对应字段名 返回查询结果 以string类型返回
        //rowName为想查询的某个列的信息  
        //dateList为要查询的表名
        //keyName为某表的主键，用于定位到某个具体行的
        //idNum

        //比如: MyQueryResult(activityName, Activity, activityID, "2022121701")
        //为 查找Activity表中的 activityID = "2022121701"(即第一行)的activityName所在列的信息
        //返回 线下党史答题活动(string类型)
        private string MyQueryResult(string rowName, string dateList, string keyName, string idNum)
        {
            string sql = "select " + @rowName + " from " + @dateList + " where " + @keyName + " = @idNum";
            SqlParameter[] pms = new[]
                    {
                        new SqlParameter("@rowName", rowName),
                        new SqlParameter("@dateList", dateList),
                        new SqlParameter("@keyName", keyName),
                        //ID为接口，接受其他页面传递来的id，则显示该id的对应数据
                        new SqlParameter("@idNum", idNum)   //以ID:2022121701举例                      
                    };
            
            SqlConnection sqlConn = Dao.MySqlConnection();//连接数据库 已打开连接
            SqlDataReader mysqlDataReader = Dao.MySqlDateReader(sql, sqlConn, pms);
            mysqlDataReader.Read();
            string result =  mysqlDataReader[rowName].ToString();//将查询的数据转成string类型
            sqlConn.Close();
            return result;
        }

        //未提交1，待审核2，未通过3，审核过期4，待报名5，报名中6，
        //待开始7，活动中8，已结束9，已上报10，已完成11
        private void MyActivityState(string activityState)
        {
            if ("1" == activityState)
            {
                labState.Text = "未提交";
            }
            else if ("2" == activityState)
            {
                labState.Text = "待审核";
            }
            else if ("3" == activityState)
            {
                labState.Text = "未通过";
                labState.ForeColor = MyPara.warningTextColor;
                labelNo.Show();
                labReason.Show();
                labReason.Text = message;
            }
            else if ("4" == activityState)
            {
                labState.Text = "审核过期";
                labState.ForeColor = MyPara.warningTextColor;
            }
            else if ("5" == activityState)
            {
                labState.Text = "待报名";
            }
            else if ("6" == activityState)
            {
                labState.Text = "报名中";
            }
            else if ("7" == activityState)
            {
                labState.Text = "待开始";
            }
            else if ("8" == activityState)
            {
                labState.Text = "活动中";
            }
            else if ("9" == activityState)
            {
                labState.Text = "已结束";
            }
            else if ("10" == activityState)
            {
                labState.Text = "已上报";
            }
            else if ("11" == activityState)
            {
                labState.Text = "已完成";
            }
            else
            {
                //错误提示信息，方便快速定位错误文件位置
                labState.Text = "ActivityApplicationDetails.cs Error!";
            }

        }

        private void ActivityApplicationDetails_Load(object sender, EventArgs e)
        {
            //谁调用这个窗体，就要先将 要显示的那张表 的keyName(任意一字段 只做识别参数)传递过来
            //从其他窗体传递来的idNum数据，这里以2022121701举例
            
            labName.Text = MyQueryResult("activityName", "Activity", "activityID", idNum); 
            //活动介绍
            //可设置成 每隔n个字符就在Label中换行， 防止介绍文本过长
            String text = MyQueryResult("activityIntro", "Activity", "activityID", idNum); 
            if (text.Length > 25)
            {
                labIntroduce.Height *= (text.Length / 25 + 1);
            }
            labIntroduce.Text = text;
            //报名时间
            labApplyTime_begin.Text = Convert.ToDateTime(MyQueryResult("signStartDate", "Activity", "activityID", idNum)).ToString("yyyy-MM-dd 12:00:00", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            labApplyTime_end.Text = Convert.ToDateTime(MyQueryResult("signEndDate", "Activity", "activityID", idNum)).ToString("yyyy-MM-dd 12:00:00", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            //举办时间
            //使用字符串裁剪str.Substring()方法将多余的 0:00:00裁掉
            string holdDateStr = Convert.ToDateTime(MyQueryResult("holdDate", "Activity", "activityID", idNum))
                .ToString("yyyy-MM-dd HH:00:00", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            labHoldTime_begin.Text = holdDateStr.Substring(0, 11) + MyQueryResult("holdStart", "Activity", "activityID", idNum) + ":00:00";
            labHoldTime_end.Text = holdDateStr.Substring(0, 11) + MyQueryResult("holdEnd", "Activity", "activityID", idNum) + ":00:00";

            //人数上限
            labNumLimit.Text = MyQueryResult("maxSigned", "Activity", "activityID", idNum);
            //学分上限
            labCredit.Text = MyQueryResult("availableCredit", "Activity", "activityID", idNum);

            //举办地点
            labPlace.Text = MyQueryResult("placeName", "Place", "placeID", MyQueryResult("activityPlaceID", "Activity", "activityID", idNum));

            //当前状态  
            string activityState = MyQueryResult("activityState", "Activity", "activityID", idNum);
            MyActivityState(activityState);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //结束当前窗体，返回上一个窗体，前提是得保存上一个窗体的对象 
            Close();
            //xxxForm.show();
        }
    }
}
