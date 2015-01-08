using System;
using System.Configuration;
using System.Windows.Forms;
namespace Jyson.MyCodeManage.DBUtility
{
    
    public class PubConstant
    {           
        /// <summary>
        /// 获取连接字符串,默认
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["connStr_PPMoney"].ConnectionString;
                return _connectionString;
            }
        }

        /// <summary>
        /// ppmoney_sms_log 连接字符串
        /// </summary>
        public static string ConnectionStringForSMSLog
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["connStr_PPMoney_SMS_Log"].ConnectionString;
                return _connectionString;
            }
        }
     
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string SQLConnectionString
        {           
            get 
            {
                string _connectionString = ConfigurationManager.AppSettings["SQLConnectionString"];       
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString; 
            }
        }

        /// <summary>
        /// 获取OleDb连接字符串
        /// </summary>
        public static string OleDbConnectionString
        {
            get
            {
                string _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\" + ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;//ConfigurationManager.AppSettings["OleDbConnectionString"];
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
