using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    internal class LabelClick
    {
        // 可以获取到当前行的活动ID，方便进行后续操作
        static public void ActCheck(string activityID)
        {
            SqlConnection connReason = Dao.MySqlConnection();
            String sqlReason = "select * from FailReason where activityID = @activityID";
            SqlDataReader reader = Dao.MySqlDateReader(sqlReason, connReason, new SqlParameter[] { new SqlParameter("activityID", activityID) });

            String msg = "";
            if (reader.Read())
            {
                msg = reader[1].ToString();
            }

            Form form = new DisplayActivity(activityID, msg);
            form.ShowDialog();
        }

        static public void ActEdit(string activityID, Org form) 
        {
            Form editForm = new ApplyActivity(1, activityID, form);
            editForm.ShowDialog();
        }

        static public void ActDelete(string activityID, Org form)
        {
            if (MessageBox.Show("确定要删除这条活动记录吗？", "DELETE CONFIRM",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Dao.MySqlConnection();
                string sql = "delete from Activity where activityID = @activityID";
                SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("activityID", activityID) });
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("删除成功！", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.LoadActivity();
            }
        }

        static public void ActWithdraw(string activityID, Label label, Org form)
        {
            if (MessageBox.Show("确定要撤回这条活动申请吗？", "WITHDRAW CONFIRM",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Dao.MySqlConnection();
                string sql = "update Activity set activityState = @state where activityID = @activityID";
                int state = 1;
                SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("state", state), new SqlParameter("activityID", activityID) });
                cmd.ExecuteNonQuery();
                conn.Close();
                //label.Text = "未提交";

                form.LoadActivity();
            }
        }

        static public void ActResubmit(string activityID, Org form)
        {
            Form editForm = new ApplyActivity(1, activityID, form);
            editForm.ShowDialog();
        }

        static public void ActExport(string activityID)
        {
            MemberTableManage.ExportTable(activityID);
            MessageBox.Show("导出成功", "EXPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static public void ActReport(string activityID, Org form)
        {
            SqlConnection conn = Dao.MySqlConnection();
            string sql = "update Activity set activityState = 10 where activityID = @activityID";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@activityID", activityID) });
            cmd.ExecuteNonQuery();
            conn.Close();
            form.LoadActivity();
        }

        static public void ActComplete(string activityID, Admin form)
        {
            SqlConnection conn = Dao.MySqlConnection();
            string sql = "update Activity set activityState = 11 where activityID = @activityID";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@activityID", activityID) });
            cmd.ExecuteNonQuery();
            conn.Close();
            form.LoadActivity();


            // 完成后给学生加学分
            // 先获取活动的学分
            SqlConnection connAct = Dao.MySqlConnection();
            String sqlAct = "select availableCredit from Activity where activityID = @activityID";
            SqlDataReader readerAct = Dao.MySqlDateReader(sqlAct, connAct, new SqlParameter[] {new SqlParameter("activityID", activityID)});
            readerAct.Read();
            int credit = Convert.ToInt32(readerAct[0].ToString());
            connAct.Close();

            String table = "Enrolled" + activityID;
            SqlConnection connSign = Dao.MySqlConnection();
            String sqlSign = string.Format("update StudentIdentified set credit += @credit " +
                "where studentID in (select studentID from {0})", table);
            SqlCommand cmdSign = Dao.MySqlCommand(sqlSign, connSign, new SqlParameter[] { new SqlParameter("credit", credit) });
            cmdSign.ExecuteNonQuery();
            connSign.Close();
        }

        static public void PlaceEdit(int placeID)
        {
            MessageBox.Show("现在不可以编辑场地信息！", "NOT NOW", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        static public void PlaceDelete(int placeID, Admin form)
        {
            if (MessageBox.Show("确定要删除这个场地吗？", "DELETE CONFIRM",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Dao.MySqlConnection();
                string sql = "delete from Place where placeID = @placeID";
                SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@placeID", placeID) });
                try
                { 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception) {
                    MessageBox.Show("因该场地有日程安排，无法删除！", "DELETE FAIL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                    form.LoadPlace();
                }
            }
        }

        static public void StudentCheckAct(string activityID)
        {
            // 学生界面查看活动信息 (被替代)
            MessageBox.Show(activityID);
        }

        static public void StudentLike(string activityID, Label label, Student form)
        {
            //string studentID = SaveData.SqlDataReaderStuActInfo["studentID"].ToString(); // 获取当前学生ID
            string studentID = Student.studentID; // 测试用ID

            //Console.WriteLine(activityID);

            // 学生界面收藏活动
            SqlConnection conn = Dao.MySqlConnection();
            string sql = "update StudentIdentified set likedActivity = concat(@activityID , likedActivity) where studentID = @studentID";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@activityID", activityID + ','), new SqlParameter("@studentID", studentID) });

            //string sql = "update StudentIdentified set likedActivity = CONCAT('" + activityID + ",', likedActivity) where studentID = '" + studentID + "'";

            //Console.WriteLine(sql);
            //SqlCommand cmd = Dao.MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            if (Student.queryMode == 1)
                form.LoadAllActivity();
            if (Student.queryMode == 2)
                form.LoadMyActivity();

            // 更改绑定事件
            label.Text = "取消\n收藏";
            AddLabel.RemoveClickEvent(label); // 去除当前事件
            label.Click += (e, a) => StudentLikeCancel(activityID, label, form); //绑定取消收藏的事件
        }

        static public void StudentLikeCancel(string activityID, Label label, Student form)
        {
            //string studentID = SaveData.SqlDataReaderStuActInfo["studentID"].ToString(); // 获取当前学生ID
            string studentID = Student.studentID; // 测试用ID

            // 学生界面取消收藏活动
            string[] strID = { };
            string likedActivity = "";

            SqlConnection conn = Dao.MySqlConnection();
            string sqlSelect = "select likedActivity from StudentIdentified where studentID = @studentID";
            SqlDataReader readerSelect = Dao.MySqlDateReader(sqlSelect, conn, new SqlParameter[] {new SqlParameter("@studentID", studentID)});
            if (readerSelect.Read())
                strID = readerSelect[0].ToString().Split(',');
            readerSelect.Close();

            foreach (string str in strID)
            {
                if (str.Equals(activityID) || str.Equals("")) continue;
                else
                    likedActivity += str + ",";
            }

            string sqlUpdate = "update StudentIdentified set likedActivity = @likedActivity where studentID = @studentID";
            SqlCommand cmd = Dao.MySqlCommand(sqlUpdate, conn, new SqlParameter[] { new SqlParameter("@likedActivity", likedActivity), new SqlParameter("@studentID", studentID) });
            cmd.ExecuteNonQuery();
            conn.Close();

            if (Student.queryMode == 1)
                form.LoadAllActivity();
            if (Student.queryMode == 2)
                form.LoadMyActivity();

            // 更改绑定事件
            label.Text = "收藏";
            AddLabel.RemoveClickEvent(label); // 去除当前事件
            label.Click += (e, a) => StudentLike(activityID, label, form); //绑定收藏的事件
        }

        static public void StudentSign(string activityID, Label label, Student form)
        {
            //string studentID = SaveData.SqlDataReaderStuActInfo["studentID"].ToString(); // 获取当前学生ID
            //string studentName = SaveData.SqlDataReaderStuActInfo["studentName"].ToString();
            //string phone = SaveData.SqlDataReaderStuActInfo["phone"].ToString();
            string studentName = "";
            string studentID = Student.studentID; // 测试用ID
            string phone = "";

            SqlConnection connText = Dao.MySqlConnection();

            // 获取本行活动信息
            string sqlActivity = "select * from Activity where activityID = @activityID";
            SqlDataReader readerActivity = Dao.MySqlDateReader(sqlActivity, connText, new SqlParameter[] { new SqlParameter("@activityID", activityID) });
            readerActivity.Read();
            Activity activity = new Activity(readerActivity);
            readerActivity.Close();

            // 获取学生信息
            string sqlStudent = "select * from StudentIdentified where studentID = @studentID";
            SqlDataReader readerStudent = Dao.MySqlDateReader(sqlStudent, connText, new SqlParameter[] { new SqlParameter("@studentID", studentID) });
            readerStudent.Read();
            studentName = readerStudent["studentName"].ToString();
            phone = readerStudent["phone"].ToString();
            
            string[] studentInfo = { readerStudent[0].ToString(), readerStudent[1].ToString(), 
                readerStudent[2].ToString(), readerStudent[3].ToString(), readerStudent[4].ToString(), 
                readerStudent[5].ToString(), readerStudent[6].ToString(),readerStudent[7].ToString(), 
                readerStudent[8].ToString(), readerStudent[9].ToString()};
            
            readerStudent.Close();

            // 判断是否可以报名（基于人数）
            int signed = int.Parse(activity.Signed); //已报名的人数
            int maxSigned = int.Parse(activity.MaxSigned); // 最大报名人数

            if (signed >= maxSigned)
            {
                MessageBox.Show("抱歉！此活动人数已满！", "提示");
                return;
            }
            else signed++;

            string sqlPlace = "select placeName from Place where placeID = @placeID";
            SqlDataReader readerPlace = Dao.MySqlDateReader(sqlPlace, connText, new SqlParameter[] { new SqlParameter("@placeID", activity.ActivityPlaceID) });
            string placeName = "";
            if (readerPlace.Read())
                placeName = readerPlace[0].ToString();
            readerPlace.Close();

            connText.Close();

            string Text =
                "活动名称：" + activity.ActivityName + "\n" +
                "举办地点：" + placeName + "\n" +
                "举办时间：" + activity.HoldDate + " " + activity.HoldStart + ":00 至 " + activity.HoldDate + " " + activity.HoldEnd + ":00\n" +
                "报名者姓名：" + studentName + "\n" +
                "报名者学号：" + studentID + "\n" +
                "报名者联系方式：" + phone;

            // Console.WriteLine(Text);

            if (MessageBox.Show(Text, "活动报名确认",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                // 学生界面报名活动
                SqlConnection conn = Dao.MySqlConnection();
                string sqlStu = "update StudentIdentified set signedActivity = concat(@activityID , signedActivity) where studentID = @studentID";
                SqlCommand cmdStu = Dao.MySqlCommand(sqlStu, conn, new SqlParameter[] { new SqlParameter("@activityID", activityID + ','), new SqlParameter("@studentID", studentID) });
                cmdStu.ExecuteNonQuery();

                string sqlAct = "update Activity set signed = @signed where activityID = @activityID";
                SqlCommand cmdAct = Dao.MySqlCommand(sqlAct, conn, new SqlParameter[] {new SqlParameter("@signed", signed.ToString()), new SqlParameter("@activityID", activityID) });
                cmdAct.ExecuteNonQuery();
                //conn.Close();

                string table = "Enrolled" + activityID;
                String sqlSign = string.Format("insert into {0} " +
                    "values(@id, @name, @gender, @major, @class, @phone, 0)", table);
                SqlCommand cmdSign = Dao.MySqlCommand(sqlSign, conn, new SqlParameter[]
                {
                    new SqlParameter("id", studentInfo[0]),
                    new SqlParameter("name", studentInfo[2]),
                    new SqlParameter("gender", studentInfo[3]),
                    new SqlParameter("major", studentInfo[4]),
                    new SqlParameter("class", studentInfo[5]),
                    new SqlParameter("phone", studentInfo[6])
                });
                cmdSign.ExecuteNonQuery();
                conn.Close();

                if (Student.queryMode == 1)
                    form.LoadAllActivity();
                if (Student.queryMode == 2)
                    form.LoadMyActivity();

                label.Text = "取消\n报名";
                AddLabel.RemoveClickEvent(label); // 去除当前事件
                label.Click += (e, a) => StudentSignCancel(activityID, label, form); //绑定报名取消的事件

                //Load位置
            }
        }

        static public void StudentSignCancel(string activityID, Label label, Student form)
        {
            //string studentID = SaveData.SqlDataReaderStuActInfo["studentID"].ToString(); // 获取当前学生ID
            string studentID = Student.studentID; // 测试用ID

            // 学生界面取消报名活动
            string[] strID = { };
            string signedActivity = "";

            // 获取学生已报名的活动ID
            SqlConnection conn = Dao.MySqlConnection();
            string sqlSelect = "select signedActivity from StudentIdentified where studentID = @studentID";
            SqlDataReader readerSelect = Dao.MySqlDateReader(sqlSelect, conn, new SqlParameter[] {new SqlParameter("@studentID", studentID)});
            if (readerSelect.Read())
                strID = readerSelect[0].ToString().Split(',');
            readerSelect.Close();

            // 获取当前活动报名人数
            string sqlSign = "select signed from Activity where activityID = @activityID";
            SqlDataReader readerSign = Dao.MySqlDateReader(sqlSign, conn, new SqlParameter[] { new SqlParameter("@activityID", activityID) });
            int signed = -1;
            if (readerSign.Read())
                signed = int.Parse(readerSign[0].ToString()) - 1;
            readerSign.Close();

            // 将本活动ID除去
            foreach(string str in strID)
            {
                if (str.Equals(activityID) || str.Equals("")) continue;
                else 
                    signedActivity += str + ",";
            }

            // 更新信息
            string sqlStu = "update StudentIdentified set signedActivity = @signedActivity where studentID = @studentID";
            SqlCommand cmd = Dao.MySqlCommand(sqlStu, conn, new SqlParameter[] { new SqlParameter("@signedActivity", signedActivity) , new SqlParameter("@studentID", studentID) });
            cmd.ExecuteNonQuery();

            string sqlAct = "update Activity set signed = @signed where activityID = @activityID";
            SqlCommand cmdAct = Dao.MySqlCommand(sqlAct, conn, new SqlParameter[] { new SqlParameter("@signed", signed.ToString()), new SqlParameter("@activityID", activityID) });
            cmdAct.ExecuteNonQuery();

            string table = "Enrolled" + activityID;
            String sqlCancel = string.Format("delete from {0} where studentID = @studentID", table);
            SqlCommand cmdCancel = Dao.MySqlCommand(sqlCancel, conn, new SqlParameter[] { new SqlParameter("studentID", studentID) });
            cmdCancel.ExecuteNonQuery();

            conn.Close();

            if (Student.queryMode == 1)
                form.LoadAllActivity();
            if (Student.queryMode == 2)
                form.LoadMyActivity();

            label.Text = "报名";
            AddLabel.RemoveClickEvent(label); // 去除当前事件
            label.Click += (e, a) => StudentSign(activityID, label, form); //绑定报名取消的事件

            //Load位置
        }

        static public void ActAudit(string activityID, Admin form)
        {
            // 已包含创建报名表
            Form verify = new VerifyActivity(activityID, form);
            verify.ShowDialog();
        }

        static public void ActExportFinalList(string activityID)
        {
            MemberTableManage.ExportTable(activityID);
            MessageBox.Show("导出成功", "EXPORT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
