using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusActivityManagementSystem
{
    internal class AddLabel
    {
        static public ListView ToOrganization(ListView listView, Org form)
        {
            // 前置样式
            listView.GridLines = false; // 框线类型
            listView.View = View.Details; // 显示细节
            listView.FullRowSelect = true; // 选择
            listView.AllowColumnReorder = false; // 不允许拖动列

            int startX = 0;
            int colIndex = 0;
            int stateIndex = 0; // 活动状态的列序号
            int orgIndex = 0; // 举办方的列序号
            int placeIndex = 0; // 举办地点的列序号
            int actIndex = 0; // 活动名称的列序号

            // 确定特定列序号及起始x
            foreach (ColumnHeader col in listView.Columns)
            {
                if (col.Text == "活动状态") stateIndex = colIndex;
                if (col.Text == "主办组织" || col.Text == "申请组织") orgIndex = colIndex;
                if (col.Text == "举办地点") placeIndex = colIndex;
                if (col.Text == "活动名称") actIndex = colIndex;
                if (col.Text == "操作") break;
                colIndex++;
                startX += col.Width;
            }

            // 对每行进行操作
            foreach (ListViewItem item in listView.Items)
            {
                // 获取当前行的活动ID，方法为用活动名称、活动地点、举办方确定，有一定风险
                string activityID = "";
                //activityID = GetActID(item.SubItems[actIndex].Text, item.SubItems[orgIndex].Text, item.SubItems[placeIndex].Text);
                activityID = item.SubItems[0].Text;

                Rectangle rectangle = item.GetBounds(ItemBoundsPortion.Entire);

                // 实例化
                Label label_1 = new Label();
                Label label_2 = new Label();

                label_1.Parent = listView; label_2.Parent = listView;


                label_1.AutoSize = false; label_2.AutoSize = false; // 自动换行
                label_1.TextAlign = ContentAlignment.MiddleCenter; // 居中对齐
                label_2.TextAlign = ContentAlignment.MiddleCenter;
                label_1.ForeColor = MyPara.listButtonColor;
                label_2.ForeColor = MyPara.listButtonColor;


                rectangle.X = startX;
                rectangle.Width = (listView.Columns[colIndex].Width) / 2;



                label_1.Bounds = rectangle; // 确定第一个label的位置

                rectangle.X = startX + label_1.Width;

                label_2.Bounds = rectangle; // 确定第二个label的位置

                if (item.SubItems[stateIndex].Text == "未提交")
                {
                    label_1.Text = "编辑";
                    label_1.Click += (e, a) => LabelClick.ActEdit(activityID, form);

                    label_2.Text = "删除";
                    label_2.ForeColor = MyPara.warningTextColor;
                    label_2.Click += (e, a) => LabelClick.ActDelete(activityID, form);

                }
                else if (item.SubItems[stateIndex].Text == "待审核")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "撤回";
                    label_2.ForeColor = MyPara.warningTextColor;
                    label_2.Click += (e, a) => LabelClick.ActWithdraw(activityID, label_2, form);

                }
                else if (item.SubItems[stateIndex].Text == "未通过")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "重新\n提交";
                    label_2.Click += (e, a) => LabelClick.ActResubmit(activityID, form);
                }
                else if (item.SubItems[stateIndex].Text == "审核过期")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "重新\n提交";
                    label_2.Click += (e, a) => LabelClick.ActResubmit(activityID, form);
                }
                else if (item.SubItems[stateIndex].Text == "待报名")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "";
                }
                else if (item.SubItems[stateIndex].Text == "报名中")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "";
                }
                else if (item.SubItems[stateIndex].Text == "待开始")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "导出报名名单";
                    label_2.Click += (e, a) => LabelClick.ActExport(activityID);
                }
                else if (item.SubItems[stateIndex].Text == "活动中")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "导出报名名单";
                    label_2.Click += (e, a) => LabelClick.ActExport(activityID);
                }
                else if (item.SubItems[stateIndex].Text == "已结束")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "上报";
                    label_2.Click += (e, a) => LabelClick.ActReport(activityID, form);
                }
                else if (item.SubItems[stateIndex].Text == "已上报")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "";
                }
                else if (item.SubItems[stateIndex].Text == "已完成")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "";
                }
                else
                {
                    label_1.Hide();
                    label_2.Hide();
                }
            }

            // 将各单元格转换为label
            /*            foreach(ListViewItem item in listView.Items)
                        {
                            Rectangle rectangle = item.GetBounds(ItemBoundsPortion.Entire);
                            startX = rectangle.Left;
                            colIndex = 0;
                            foreach (ColumnHeader col in listView.Columns)
                            {
                                if (colIndex == listView.Columns.Count - 1) break;
                                if (col.Width > 0)
                                {
                                    Label label = new Label();
                                    label.AutoSize = false;

                                    rectangle.X = startX;
                                    rectangle.Width = col.Width;
                                    label.Bounds = rectangle;

                                    label.Text = item.SubItems[colIndex].Text;
                                    label.Tag = item.SubItems[colIndex];
                                }

                                colIndex++;
                                startX += col.Width;
                            }
                        }*/

            return listView;
        }

        static public ListView ToPlace(ListView listView, Admin form)
        {
            // 前置样式
            listView.GridLines = false; // 框线类型
            listView.View = View.Details; // 显示细节
            listView.FullRowSelect = true; // 选择
            listView.AllowColumnReorder = false; // 不允许拖动列

            int startX = 0;
            int colIndex = 0;
            int placeIndex = 0; // 场地名称列序号

            // 确定特定列序号及起始x
            foreach (ColumnHeader col in listView.Columns)
            {
                if (col.Text == "活动状态") placeIndex = colIndex;
                if (col.Text == "操作") break;
                colIndex++;
                startX += col.Width;
            }

            foreach (ListViewItem item in listView.Items)
            {
                string placeName = item.SubItems[placeIndex].Text; // 获取场地名称
                int placeID = -1;

                // 获取场地ID
                /*                SqlConnection conn = Dao.MySqlConnection();
                                string sql = "select placeID from Place where placeName = @placeName";
                                SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] { new SqlParameter("@placeName", placeName) });
                                if (reader.Read())
                                    placeID = int.Parse(reader[0].ToString());
                                conn.Close();*/
                placeID = int.Parse(item.SubItems[0].Text);

                // 创建label
                Rectangle rectangle = item.GetBounds(ItemBoundsPortion.Entire);
                rectangle.Width = (listView.Columns[colIndex].Width) / 2;

                Label label_1 = new Label();
                Label label_2 = new Label();

                label_1.Parent = listView; label_2.Parent = listView;

                label_1.AutoSize = false; label_2.AutoSize = false; // 自动换行
                label_1.TextAlign = ContentAlignment.MiddleCenter; // 居中对齐
                label_2.TextAlign = ContentAlignment.MiddleCenter;

                rectangle.X = startX;
                label_1.Bounds = rectangle;

                rectangle.X = startX + label_1.Width;
                label_2.Bounds = rectangle;

                // 具体内容及点击事件
                label_1.Text = "编辑";
                label_1.ForeColor = MyPara.listButtonColor;
                label_2.Text = "删除";
                label_2.ForeColor = MyPara.warningTextColor;

                label_1.Click += (e, a) => LabelClick.PlaceEdit(placeID);
                label_2.Click += (e, a) => LabelClick.PlaceDelete(placeID, form);
            }

            return listView;
        }

        static public ListView ToStudent(ListView listView, Student form)
        {
            // 前置样式
            listView.GridLines = false; // 框线类型
            listView.View = View.Details; // 显示细节
            listView.FullRowSelect = true; // 选择
            listView.AllowColumnReorder = false; // 不允许拖动列

            int startX = 0;
            int colIndex = 0;
            int stateIndex = 0; // 活动状态的列序号
            int orgIndex = 0; // 举办方的列序号
            int placeIndex = 0; // 举办地点的列序号
            int actIndex = 0; // 活动名称的列序号

            // 确定特定列序号及起始x
            foreach (ColumnHeader col in listView.Columns)
            {
                if (col.Text == "活动状态") stateIndex = colIndex;
                if (col.Text == "主办组织") orgIndex = colIndex;
                if (col.Text == "举办地点") placeIndex = colIndex;
                if (col.Text == "活动名称") actIndex = colIndex;
                if (col.Text == "操作") break;
                colIndex++;
                startX += col.Width;
            }

            foreach(ListViewItem item in listView.Items)
            {
                // 获取活动ID
                string activityID = "";
                //activityID = GetActID(item.SubItems[actIndex].Text, item.SubItems[orgIndex].Text, item.SubItems[placeIndex].Text);
                activityID = item.SubItems[0].Text;

                // 创建label
                Rectangle rectangle = item.GetBounds(ItemBoundsPortion.Entire);
                rectangle.Width = (listView.Columns[colIndex].Width) / 3;

                Label label_1 = new Label();
                Label label_2 = new Label();
                Label label_3 = new Label();

                label_1.Parent = listView; label_2.Parent = listView; label_3.Parent = listView;

                label_1.AutoSize = false; // 自动换行
                label_2.AutoSize = false;
                label_3.AutoSize = false;
                label_1.TextAlign = ContentAlignment.MiddleCenter; // 居中对齐
                label_2.TextAlign = ContentAlignment.MiddleCenter;
                label_3.TextAlign = ContentAlignment.MiddleCenter;
                label_1.ForeColor = MyPara.listButtonColor;
                label_2.ForeColor = MyPara.listButtonColor;
                label_3.ForeColor = MyPara.listButtonColor;

                rectangle.X = startX;
                label_1.Bounds = rectangle;

                rectangle.X = startX + label_1.Width;
                label_2.Bounds = rectangle;

                rectangle.X = startX + label_1.Width + label_2.Width;
                label_3.Bounds = rectangle;

                // 设置具体label和点击事件
                label_1.Text = "查看";
                label_1.Click += (e, a) => LabelClick.ActCheck(activityID); // StudentCheckAct(activityID);

                // 判断是否已经收藏
                if (IsLiked(activityID))
                {
                    label_2.Text = "取消\n收藏";
                    label_2.Click += (e, a) => LabelClick.StudentLikeCancel(activityID, label_2, form);
                }
                else
                {
                    label_2.Text = "收藏";
                    label_2.Click += (e, a) => LabelClick.StudentLike(activityID, label_2, form);
                }

                // 判断是否已经报名
                if (item.SubItems[stateIndex].Text == "报名中")
                {
                    if (IsSigned(activityID))
                    {
                        label_3.Text = "取消\n报名";
                        label_3.Click += (e, a) => LabelClick.StudentSignCancel(activityID, label_3, form);
                    }
                    else
                    {
                        label_3.Text = "报名";
                        label_3.Click += (e, a) => LabelClick.StudentSign(activityID, label_3, form);
                    }
                }
                else label_3.Text = "";
            }

            return listView;
        }

        static public ListView ToSchool (ListView listView, Admin form)
        {
            // 前置样式
            listView.GridLines = false; // 框线类型
            listView.View = View.Details; // 显示细节
            listView.FullRowSelect = true; // 选择
            listView.AllowColumnReorder = false; // 不允许拖动列

            int startX = 0;
            int colIndex = 0;
            int stateIndex = 0; // 活动状态的列序号
            int orgIndex = 0; // 举办方的列序号
            int placeIndex = 0; // 举办地点的列序号
            int actIndex = 0; // 活动名称的列序号

            // 确定特定列序号及起始x
            foreach (ColumnHeader col in listView.Columns)
            {
                if (col.Text == "活动状态") stateIndex = colIndex;
                if (col.Text == "主办组织" || col.Text == "申请组织") orgIndex = colIndex;
                if (col.Text == "举办地点") placeIndex = colIndex;
                if (col.Text == "活动名称") actIndex = colIndex;
                if (col.Text == "操作") break;
                colIndex++;
                startX += col.Width;
            }

            // 对每行进行操作
            foreach (ListViewItem item in listView.Items)
            {
                // 获取当前行的活动ID，方法为用活动名称、活动地点、举办方确定，有一定风险
                string activityID = "";
                //activityID = GetActID(item.SubItems[actIndex].Text, item.SubItems[orgIndex].Text, item.SubItems[placeIndex].Text);
                activityID = item.SubItems[0].Text;

                Rectangle rectangle = item.GetBounds(ItemBoundsPortion.Entire);

                // 实例化
                Label label_1 = new Label();
                Label label_2 = new Label();

                label_1.Parent = listView; label_2.Parent = listView;


                label_1.AutoSize = false; label_2.AutoSize = false; // 自动换行
                label_1.TextAlign = ContentAlignment.MiddleCenter; // 居中对齐
                label_2.TextAlign = ContentAlignment.MiddleCenter;
                label_1.ForeColor = MyPara.listButtonColor;
                label_2.ForeColor = MyPara.listButtonColor;


                rectangle.X = startX;
                rectangle.Width = (listView.Columns[colIndex].Width) / 2;


                label_1.Bounds = rectangle; // 确定第一个label的位置

                rectangle.X = startX + label_1.Width;

                label_2.Bounds = rectangle; // 确定第二个label的位置

                if (item.SubItems[stateIndex].Text == "待审核")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "审核";
                    label_2.Click += (e, a) => LabelClick.ActAudit(activityID, form);
                }
                else if (item.SubItems[stateIndex].Text == "已上报")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "完成";
                    label_2.Click += (e, a) => LabelClick.ActComplete(activityID, form);
                }
                else if (item.SubItems[stateIndex].Text == "已完成")
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);

                    label_2.Text = "导出完成名单";
                    label_2.Click += (e, a) => LabelClick.ActExportFinalList(activityID);
                }
                else
                {
                    label_1.Text = "查看";
                    label_1.Click += (e, a) => LabelClick.ActCheck(activityID);
                }
            }

            return listView;
        }

        static public string GetActID(string activityName, string orgName, string placeName)
        {
            string activityID = "";
            string organizationID = "";
            string placeID = "";
/*            Console.WriteLine(activityName);
            Console.WriteLine(orgName);
            Console.WriteLine(placeName);*/

            SqlConnection conn = Dao.MySqlConnection();

            string sqlOrg = "select organizationID from Organization where organizationName = @organizationName";
            SqlDataReader readerOrg = Dao.MySqlDateReader(sqlOrg, conn, new SqlParameter[] { new SqlParameter("@organizationName", orgName) });
            if (readerOrg.Read())
                organizationID = readerOrg[0].ToString();
            readerOrg.Close();

            string sqlPlace = "select placeID from Place where placeName = @placeName";
            SqlDataReader readerPlace = Dao.MySqlDateReader(sqlPlace, conn, new SqlParameter[] { new SqlParameter("@placeName", placeName) });
            if (readerPlace.Read())
                placeID = readerPlace[0].ToString();
            readerPlace.Close();

            string sqlAct = "select activityID from Activity where activityName = @activityName and activityOrgID = @activityOrgID and activityPlaceID = @activityPlaceID";
            SqlParameter[] sp = new SqlParameter[]
            {
                    new SqlParameter("@activityName", activityName),
                    new SqlParameter("@activityOrgID", organizationID),
                    new SqlParameter("@activityPlaceID", placeID),
            };
            SqlDataReader readerAct = Dao.MySqlDateReader(sqlAct, conn, sp);
            if (readerAct.Read())
                activityID = readerAct[0].ToString();
            readerAct.Close();
            conn.Close();

/*            Console.WriteLine(activityID);
            Console.WriteLine(organizationID);
            Console.WriteLine(placeID);*/

            return activityID;
        }

        static public bool IsLiked(string activityID)
        {
            string studentID = Student.studentID;

            string[] strID = { };
            bool isLiked = false;

            SqlConnection conn = Dao.MySqlConnection();
            string sql = "select likedActivity from StudentIdentified where studentID = @studentID";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] {new SqlParameter("@studentID", studentID)});
            if (reader.Read()) strID = reader[0].ToString().Split(',');
            conn.Close();

            foreach(string ID in strID)
            {
                if (ID.Equals (activityID)) { isLiked = true; break; }
            }

            return isLiked;
        }

        static public bool IsSigned(string activityID)
        {
            string studentID = Student.studentID;

            string[] strID = { };
            bool isSigned = false;

            SqlConnection conn = Dao.MySqlConnection();
            string sql = "select signedActivity from StudentIdentified where studentID = @studentID";
            SqlDataReader reader = Dao.MySqlDateReader(sql, conn, new SqlParameter[] {new SqlParameter("@studentID", studentID)});
            if (reader.Read()) strID = reader[0].ToString().Split(',');
            conn.Close();

            foreach(string ID in strID)
            {
                if (ID.Equals (activityID)) { isSigned = true; break; }
            }

            return isSigned;
        }

        static public ListView RemoveLabel(ListView listView)
        {
            List<Control> controls = new List<Control>();
            foreach (Control ctr in listView.Controls) controls.Add(ctr);
            for (int i = listView.Controls.Count - 1; i >= 0; i--)
            {
               if (controls[i] is Label)
                listView.Controls.Remove(controls[i]);
            }

            return listView;
        }

        public static void RemoveClickEvent(Label label)
        {
            FieldInfo fieldInfo = typeof(Control).GetField("EventClick", BindingFlags.Static | BindingFlags.NonPublic);

            object obj = fieldInfo.GetValue(label);

            PropertyInfo propertyInfo = label.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)propertyInfo.GetValue(label, null);
            list.RemoveHandler(obj, list[obj]);
        }
    }
}
