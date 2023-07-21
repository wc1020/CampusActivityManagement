using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace CampusActivityManagementSystem
{
    class Activity
    {
        private string activityID = "";
        private string activityName;
        private string activityIntro;
        private string activityPlaceID;
        private string activityOrgID;
        private string availableCredit = "1";
        private string maxSigned;
        private string signed = "0";
        private string activityState = "1";
        private string signStartDate;
        private string signEndDate;
        private string holdDate;
        private string holdStart;
        private string holdEnd;
        private string submitTime = "1900-01-01 00:00:00";

        public Activity() { }  

        public Activity(SqlDataReader reader)
        {
            activityID = reader[0].ToString();
            activityName = reader[1].ToString();
            activityIntro = reader[2].ToString();
            activityPlaceID = reader[3].ToString();
            activityOrgID = reader[4].ToString();
            availableCredit = reader[5].ToString();
            maxSigned = reader[6].ToString();
            signed = reader[7].ToString();
            activityState = reader[8].ToString();
            signStartDate = Convert.ToDateTime(reader[9]).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            signEndDate = Convert.ToDateTime(reader[10]).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            holdDate = Convert.ToDateTime(reader[11]).ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            holdStart = reader[12].ToString();
            holdEnd = reader[13].ToString();
            submitTime = Convert.ToDateTime(reader[14]).ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public string ActivityID { get => activityID; set => activityID = value; }
        public string ActivityName { get => activityName; set => activityName = value; }
        public string ActivityIntro { get => activityIntro; set => activityIntro = value; }
        public string ActivityPlaceID { get => activityPlaceID; set => activityPlaceID = value; }
        public string ActivityOrgID { get => activityOrgID; set => activityOrgID = value; }
        public string AvailableCredit { get => availableCredit; set => availableCredit = value; }
        public string MaxSigned { get => maxSigned; set => maxSigned = value; }
        public string Signed { get => signed; set => signed = value; }
        public string ActivityState { get => activityState; set => activityState = value; }
        public string SignStartDate { get => signStartDate; set => signStartDate = value; }
        public string SignEndDate { get => signEndDate; set => signEndDate = value; }
        public string HoldDate { get => holdDate; set => holdDate = value; }
        public string HoldStart { get => holdStart; set => holdStart = value; }
        public string HoldEnd { get => holdEnd; set => holdEnd = value; }
        public string SubmitTime { get => submitTime; set => submitTime = value; }

        public void Create()
        {
            // 根据保存时间与顺序计算activityID
            //submitTime = DateTime.Now.ToString("yyyy-MM-dd"); // 时间格式
            string submitTimePro = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string[] strTime = submitTimePro.Split('-');
            submitTimePro = "";
            foreach (var str in strTime) submitTimePro += str;

            string sqlIndex = "select count(*) from Activity where activityID like @submitTimePro";
            SqlConnection connIndex = Dao.MySqlConnection();
            SqlDataReader readerIndex = Dao.MySqlDateReader(sqlIndex, connIndex, 
                new SqlParameter[] { new SqlParameter("@submitTimePro", submitTimePro + '%') });

            readerIndex.Read();
            if (int.Parse(readerIndex[0].ToString()) + 1 < 10)
                activityID = "0";
            activityID = submitTimePro + activityID + (int.Parse(readerIndex[0].ToString()) + 1).ToString();

            connIndex.Close();

            // 处理数据格式
            int intActivityPlaceID = int.Parse(activityPlaceID);
            int intAvailableCredit = int.Parse(availableCredit);
            int intMaxSigned = int.Parse(maxSigned);
            int intSigned = int.Parse(signed);
            int intActivityState = int.Parse(activityState);

            /*DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            DateTime dtSignStartDate = Convert.ToDateTime(signStartDate, dtFormat);
            DateTime dtSignEndDate = Convert.ToDateTime(signEndDate, dtFormat);
            DateTime dtHoldDate = Convert.ToDateTime(holdDate, dtFormat);
            DateTime dtSubmitTime = Convert.ToDateTime(submitTime);*/

            int intHoldStart = int.Parse(holdStart);
            int intHoldEnd = int.Parse(holdEnd);

            // 插入
            string sqlCreate = "insert into Activity values(@activityID, @activityName, @activityIntro, @activityPlaceID, @activityOrgID, @availableCredit, @maxSigned, @signed, @activityState, @signStartDate, @signEndDate, @holdDate, @holdStart, @holdEnd, @submitTime)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@activityID", activityID),
                new SqlParameter("@activityName", activityName),
                new SqlParameter("@activityIntro", activityIntro),
                new SqlParameter("@activityPlaceID", intActivityPlaceID),
                new SqlParameter("@activityOrgID", activityOrgID),
                new SqlParameter("@availableCredit", intAvailableCredit),
                new SqlParameter("@maxSigned", intMaxSigned),
                new SqlParameter("@signed", intSigned),
                new SqlParameter("@activityState", intActivityState),
                new SqlParameter("@signStartDate", signStartDate),
                new SqlParameter("@signEndDate", signEndDate),
                new SqlParameter("@holdDate", holdDate),
                new SqlParameter("@holdStart", intHoldStart),
                new SqlParameter("@holdEnd", intHoldEnd),
                new SqlParameter("@submitTime", submitTime)
            };
            SqlConnection connCreate = Dao.MySqlConnection();
            SqlCommand cmdCreate = Dao.MySqlCommand(sqlCreate, connCreate, sp);
            cmdCreate.ExecuteNonQuery();

            connCreate.Close();
        }

        public void Update()
        {
            SqlConnection conn = Dao.MySqlConnection();
            String sql = "update Activity " +
                "set activityName = @activityName, " +
                "activityIntro = @activityIntro, " +
                "activityPlaceID = @activityPlaceID, " +
                "availableCredit = @availableCredit, " +
                "maxSigned = @maxSigned, " +
                "activityState = @activityState, "  +
                "signStartDate = @signStartDate, signEndDate = @signEndDate, " +
                "holdDate = @holdDate, holdStart = @holdStart, holdEnd = @holdEnd, " +
                "submitTime = @submitTime where activityID = @activityID";
            SqlParameter[] paras = new SqlParameter[] { 
                new SqlParameter("activityName", activityName), 
                new SqlParameter("activityIntro", activityIntro), 
                new SqlParameter("activityPlaceID", Convert.ToInt32(activityPlaceID)), 
                new SqlParameter("availableCredit", Convert.ToInt32(availableCredit)), 
                new SqlParameter("maxSigned", Convert.ToInt32(maxSigned)),
                new SqlParameter("activityState", Convert.ToInt32(activityState)), 
                new SqlParameter("signStartDate", signStartDate), 
                new SqlParameter("signEndDate", signEndDate), 
                new SqlParameter("holdDate", holdDate), 
                new SqlParameter("holdStart", Convert.ToInt32(holdStart)), 
                new SqlParameter("holdEnd", Convert.ToInt32(holdEnd)), 
                new SqlParameter("submitTime", submitTime),
                new SqlParameter("activityID", activityID)
            };
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, paras);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete()
        {
            SqlConnection conn = Dao.MySqlConnection();
            String sql = "delete from Activity where activityID = @activityID";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("activityID", activityID) });
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateState()
        {
            // 根据当前时间更改活动关于时间的状态（待报名5，报名中6，待开始7，活动中8，已结束9）

            // 获取当前时间
            string nowTime = DateTime.Now.ToString("yyyy-MM-dd HH", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //string nowTime = "2028-04-04 14";
            int nowHour = int.Parse(nowTime.Substring(11));
            nowTime = nowTime.Substring(0, 10);

/*            Console.WriteLine(nowTime);
            Console.WriteLine(nowHour);*/

            int state = -1;
            string sql = "update Activity set activityState = @state where activityID = @activityID";
            SqlConnection conn = Dao.MySqlConnection();

            if (int.Parse(activityState) >= 5 && int.Parse(activityState) <= 9)
            {
                //审核通过
                if (Lesser(nowTime, SignStartDate))
                {
                    // 待报名5
                    // Console.WriteLine(signStartDate);
                    state = 5;
                }
                else if (Lesser(nowTime, SignEndDate))
                {
                    // 报名中6
                    //Console.WriteLine(signEndDate);
                    state = 6;
                }
                else if (Lesser(nowTime, HoldDate))
                {
                    // 待开始7
                    //Console.WriteLine(HoldDate);
                    state = 7;
                }
                else if (Equals(nowTime, HoldDate))
                {
                    if (nowHour < int.Parse(holdStart))
                    {
                        // 待开始7
                        state = 7;
                    }
                    else if (nowHour <= int.Parse(holdEnd))
                    {
                        // 活动中8
                        state = 8;
                    }
                    else
                    {
                        // 已结束9
                        state = 9;
                    }
                }
                else 
                {
                    // 已结束9
                    state = 9;
                }
                SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@state", state), new SqlParameter("@activityID", activityID) });
                cmd.ExecuteNonQuery();
                conn.Close();

                activityState = state.ToString();
            }
        }

        public bool Lesser(string nowTime, string comparedTime)
        {
            bool lesser = false;

            string[] strNowTime = nowTime.Split('-');
            string[] strComTime = comparedTime.Split('-');

            if (int.Parse(strNowTime[0]) < int.Parse(strComTime[0])) lesser = true;
            else if (int.Parse(strNowTime[0]) == int.Parse(strComTime[0]))
            {
                if (int.Parse(strNowTime[1]) < int.Parse(strComTime[1])) lesser = true;
                else if (int.Parse(strNowTime[1]) == int.Parse(strComTime[1]))
                {
                    if (int.Parse(strNowTime[2]) < int.Parse(strComTime[2])) lesser = true;
                    else lesser = false;
                }
                else lesser = false;
            }
            else lesser = false;

            return lesser;
        }
    }
}
