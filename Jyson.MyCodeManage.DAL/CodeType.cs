using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Jyson.MyCodeManage.Utility;
using Jyson.MyCodeManage.DBUtility;

namespace Jyson.MyCodeManage.DAL
{
	/// <summary>
	/// 数据访问类:CodeType
	/// </summary>
	public partial class CodeType
	{
		public CodeType()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("Id", "CodeType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CodeType");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jyson.MyCodeManage.Model.CodeType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CodeType(");
			strSql.Append("TypeName,OrderNo)");
			strSql.Append(" values (");
			strSql.Append("@TypeName,@OrderNo)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@TypeName", OleDbType.VarChar,50),
					new OleDbParameter("@OrderNo", OleDbType.Integer,4)};
			parameters[0].Value = model.TypeName;
			parameters[1].Value = model.OrderNo;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Jyson.MyCodeManage.Model.CodeType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CodeType set ");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("OrderNo=@OrderNo");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@TypeName", OleDbType.VarChar,50),
					new OleDbParameter("@OrderNo", OleDbType.Integer,4),
					new OleDbParameter("@Id", OleDbType.Integer,4)};
			parameters[0].Value = model.TypeName;
			parameters[1].Value = model.OrderNo;
			parameters[2].Value = model.Id;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CodeType ");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CodeType ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
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
		public Jyson.MyCodeManage.Model.CodeType GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TypeName,OrderNo from CodeType ");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

			Jyson.MyCodeManage.Model.CodeType model=new Jyson.MyCodeManage.Model.CodeType();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TypeName"]!=null && ds.Tables[0].Rows[0]["TypeName"].ToString()!="")
				{
					model.TypeName=ds.Tables[0].Rows[0]["TypeName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["OrderNo"]!=null && ds.Tables[0].Rows[0]["OrderNo"].ToString()!="")
				{
					model.OrderNo=int.Parse(ds.Tables[0].Rows[0]["OrderNo"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,TypeName,OrderNo ");
			strSql.Append(" FROM CodeType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM CodeType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperOleDb.GetSingle(strSql.ToString());
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
		public DataSet GetListByPage(string strWhere, string OrderNoby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(OrderNoby.Trim()))
			{
				strSql.Append("OrderNo by T." + OrderNoby );
			}
			else
			{
				strSql.Append("OrderNo by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from CodeType T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderNoType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "CodeType";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

