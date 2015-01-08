/**  版本信息模板在安装目录下，可自行修改。
* SMSRecord.cs
*
* 功 能： N/A
* 类 名： SMSRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/8 11:16:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Jyson.MyCodeManage.DBUtility;

namespace Jyson.MyCodeManage.DAL
{
    /// <summary>
    /// 数据访问类:SMSRecord
    /// </summary>
    public partial class SMSRecord
    {
        public SMSRecord()
        {
            //重新给字符串
            DbHelperSQL.connectionString = PubConstant.ConnectionStringForSMSLog;
        }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "SMSRecord");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long Phone, DateTime CreateDate, int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SMSRecord");
            strSql.Append(" where Phone=@Phone and CreateDate=@CreateDate and Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Phone", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Phone;
            parameters[1].Value = CreateDate;
            parameters[2].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.SMSRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SMSRecord(");
            strSql.Append("Phone,CreateDate,VerifyCode,Content,SendType,Priority)");
            strSql.Append(" values (");
            strSql.Append("@Phone,@CreateDate,@VerifyCode,@Content,@SendType,@Priority)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Phone", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Content", SqlDbType.NVarChar,500),
					new SqlParameter("@SendType", SqlDbType.Int,4),
					new SqlParameter("@Priority", SqlDbType.Int,4)};
            parameters[0].Value = model.Phone;
            parameters[1].Value = model.CreateDate;
            parameters[2].Value = model.VerifyCode;
            parameters[3].Value = model.Content;
            parameters[4].Value = model.SendType;
            parameters[5].Value = model.Priority;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.SMSRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SMSRecord set ");
            strSql.Append("VerifyCode=@VerifyCode,");
            strSql.Append("Content=@Content,");
            strSql.Append("SendType=@SendType,");
            strSql.Append("Priority=@Priority");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@VerifyCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Content", SqlDbType.NVarChar,500),
					new SqlParameter("@SendType", SqlDbType.Int,4),
					new SqlParameter("@Priority", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime)};
            parameters[0].Value = model.VerifyCode;
            parameters[1].Value = model.Content;
            parameters[2].Value = model.SendType;
            parameters[3].Value = model.Priority;
            parameters[4].Value = model.Id;
            parameters[5].Value = model.Phone;
            parameters[6].Value = model.CreateDate;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SMSRecord ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long Phone, DateTime CreateDate, int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SMSRecord ");
            strSql.Append(" where Phone=@Phone and CreateDate=@CreateDate and Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Phone", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Phone;
            parameters[1].Value = CreateDate;
            parameters[2].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SMSRecord ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.SMSRecord GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Phone,CreateDate,VerifyCode,Content,SendType,Priority from SMSRecord ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            Model.SMSRecord model = new Model.SMSRecord();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.SMSRecord DataRowToModel(DataRow row)
        {
            Model.SMSRecord model = new Model.SMSRecord();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Phone"] != null && row["Phone"].ToString() != "")
                {
                    model.Phone = long.Parse(row["Phone"].ToString());
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["VerifyCode"] != null)
                {
                    model.VerifyCode = row["VerifyCode"].ToString();
                }
                if (row["Content"] != null)
                {
                    model.Content = row["Content"].ToString();
                }
                if (row["SendType"] != null && row["SendType"].ToString() != "")
                {
                    model.SendType = int.Parse(row["SendType"].ToString());
                }
                if (row["Priority"] != null && row["Priority"].ToString() != "")
                {
                    model.Priority = int.Parse(row["Priority"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Phone,CreateDate,VerifyCode,Content,SendType,Priority ");
            strSql.Append(" FROM SMSRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,Phone,CreateDate,VerifyCode,Content,SendType,Priority ");
            strSql.Append(" FROM SMSRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM SMSRecord ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from SMSRecord T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "SMSRecord";
            parameters[1].Value = "Id";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
    }
}

