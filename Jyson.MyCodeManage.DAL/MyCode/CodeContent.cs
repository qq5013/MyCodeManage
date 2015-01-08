using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Jyson.MyCodeManage.Utility;
using Jyson.MyCodeManage.DBUtility;
namespace Jyson.MyCodeManage.DAL
{
    /// <summary>
    /// 数据访问类:CodeContent
    /// </summary>
    public partial class CodeContent
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int ContentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.*,b.TypeName");
            strSql.Append(" FROM CodeContent a");
            strSql.Append(" INNER JOIN CodeType b ON a.CodeTypeId=b.Id");
            strSql.Append(" WHERE a.Id="+ContentId);
            return DbHelperOleDb.Query(strSql.ToString());
        }
    }
}
