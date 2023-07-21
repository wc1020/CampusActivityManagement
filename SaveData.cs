using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusActivityManagementSystem
{
    internal class SaveData
    {
        public static Login login;  //用于保存登录窗体，便于退出登录返回登录页面
        public static Student student;//用于保存学生窗体，便于随时返回至学生页面
        public static SqlDataReader SqlDataReaderLogin;         //用于保存上一个窗体的查询信息
        public static SqlDataReader SqlDataReaderStuActInfo;    //用于保存学生界面的个人信息,将查询结果传给学生个人信息窗体
        public static SqlDataReader SqlDataReaderSingleInfo;    //用于保存学生界面的个人信息
        //public static SqlDataReader SqlDataReader
        public static string saveStr;
    }
}
