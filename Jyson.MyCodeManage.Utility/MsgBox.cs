using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jyson.MyCodeManage.Utility
{
    public class MsgBox
    {
        public static void MsgBoxErrors(string MsgStr)
        {
            MessageBox.Show(MsgStr, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void MsgBoxInfo(string MsgStr)
        {
            MessageBox.Show(MsgStr, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static void MsgBoxOK(string MsgStr)
        {
            MessageBox.Show(MsgStr, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// true则是删除，执行相应的操作
        /// </summary>
        /// <param name="MsgStr"></param>
        /// <returns></returns>
        public static bool MsgBoxQuestion(string MsgStr)
        {
            if (MessageBox.Show(MsgStr, "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                return false;
            else
                return true;
        }

    }
}
