using System;
using System.Data;
using System.Collections.Generic;
using Jyson.MyCodeManage.Model;
namespace Jyson.MyCodeManage.BLL
{
    /// <summary>
    /// CodeContent
    /// </summary>
    public partial class CodeContent
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(int ContentId)
        {
            return dal.GetList(ContentId);
        }
    }
}
