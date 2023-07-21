using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;

namespace CampusActivityManagementSystem
{
    internal class MemberTableManage
    {
        public static void CreateTabel(string activityID)
        {
            string tableName = "Enrolled" + activityID;
            SqlConnection conn = Dao.MySqlConnection();
            string sql = "create table @tableName (studentID char(10) check(len(studentID) = 10) primary key," + 
                " studentName varchar(22) not null, gender char(2) check(gender in ('男','女')), major varchar(26),"+ 
                " class varchar(10), phone char(11) check(len(phone) = 11) unique, checked int default 0 check(checked = 0 or checked =1))";
            SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@tableName", tableName) });
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ExportTable(string activityID)
        {   
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            string foldPath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath + @"\";
            }

            // 获取数据库数据
            string tableName = "Enrolled" + activityID;
            System.Data.DataTable dataTable = new System.Data.DataTable();

            SqlConnection conn = Dao.MySqlConnection();
            string sql = "select * from " + tableName;
            //SqlCommand cmd = Dao.MySqlCommand(sql, conn, new SqlParameter[] { new SqlParameter("@tableName", tableName) });
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
            sqlDataAdapter.Fill(dataTable);
            conn.Close();

            // 转存为Excel
            ApplicationClass excel = new ApplicationClass(); //Excel的实例
            Workbook workBook = excel.Workbooks.Add(true); // 新建一张Excel工作薄
            Worksheet workSheet = (Worksheet)workBook.Worksheets.get_Item(1); // 第一个sheet页

            // 获取数据库列名称
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                Console.WriteLine(dataTable.Columns[i].ColumnName);
                workSheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
            }
            
            for (int i =0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++) 
                {
                    // 从Excel表第二行第一列开始写入
                    workSheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            // 保存文件
            string tablePath = foldPath + tableName; // 文件完整地址
            workBook.SaveAs(Filename:tablePath, ReadOnlyRecommended:true);
            excel.Quit();
        }
    }
}
