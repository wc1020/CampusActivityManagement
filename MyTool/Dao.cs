using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CampusActivityManagementSystem
{
    public static class Dao
    {
        public static SqlConnection MySqlConnection()
        {
            // 连接数据库，连接本地数据库时每个人String不同
            string mSqlConStr = "Data Source=WC_LAPTOP;Initial Catalog=ActivityManager;Integrated Security=True";
            SqlConnection mSqlConn = new SqlConnection(mSqlConStr);
            mSqlConn.Open();
            return mSqlConn;
        }

        public static SqlCommand MySqlCommand(string sql, SqlConnection mSqlConn)
        {   
            // 获得sql命令
            SqlCommand mSqlCom = new SqlCommand(sql, mSqlConn);
            return mSqlCom;
        }

        public static SqlDataReader MySqlDateReader(string sql, SqlConnection mSqlConn)
        {
            // 获取数据
            return MySqlCommand(sql, mSqlConn).ExecuteReader();
        }

        public static SqlCommand MySqlCommand(string sql, SqlConnection mSqlConn, SqlParameter[] parameters)
        {
            // 获得sql命令，参数赋值版本
            SqlCommand mSqlCom = new SqlCommand(sql, mSqlConn);
            mSqlCom.Parameters.AddRange(parameters);
            return mSqlCom;
        }

        public static SqlDataReader MySqlDateReader(string sql, SqlConnection mSqlConn, SqlParameter[] parameters) 
        {
            // 获取数据，参数赋值版本
            return MySqlCommand(sql, mSqlConn, parameters).ExecuteReader();
        }
    }
}
