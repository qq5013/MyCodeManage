using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Jyson.MyCodeManage.Utility
{
    public class Common
    {

        #region  数据绑定ComboBox控件
        /// <summary>
        /// 数据绑定ComboBox控件
        /// </summary>
        /// <param name="dt">要绑定的表</param>
        /// <param name="cboname">绑定的ComboBox控件的名称</param>
        /// <param name="bindid">要绑定的数据表中的字段ID</param>
        /// <param name="bindmember">要绑定的数据表中的字段</param>
        public static void BindComboBox(DataTable dt, ComboBox cboname, string bindid, string bindmember)
        {
            cboname.BeginUpdate();
            cboname.DataSource = dt;
            cboname.ValueMember = bindid;
            cboname.DisplayMember = bindmember;
            cboname.EndUpdate();
        }
        #endregion
    }
}
