using System;
using System.Data;
using System.Collections.Generic;
using Jyson.MyCodeManage.Model;
namespace Jyson.MyCodeManage.BLL
{
	/// <summary>
	/// CodeType
	/// </summary>
	public partial class CodeType
	{
		private readonly Jyson.MyCodeManage.DAL.CodeType dal=new Jyson.MyCodeManage.DAL.CodeType();
		public CodeType()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Jyson.MyCodeManage.Model.CodeType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Jyson.MyCodeManage.Model.CodeType model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Jyson.MyCodeManage.Model.CodeType GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Jyson.MyCodeManage.Model.CodeType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Jyson.MyCodeManage.Model.CodeType> DataTableToList(DataTable dt)
		{
			List<Jyson.MyCodeManage.Model.CodeType> modelList = new List<Jyson.MyCodeManage.Model.CodeType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Jyson.MyCodeManage.Model.CodeType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Jyson.MyCodeManage.Model.CodeType();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["TypeName"]!=null && dt.Rows[n]["TypeName"].ToString()!="")
					{
					model.TypeName=dt.Rows[n]["TypeName"].ToString();
					}
                    if (dt.Rows[n]["OrderNo"] != null && dt.Rows[n]["OrderNo"].ToString() != "")
					{
                        model.OrderNo = int.Parse(dt.Rows[n]["OrderNo"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string OrderNoby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  OrderNoby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

