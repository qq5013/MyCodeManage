using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jyson.MyCodeManage.UI
{
    public partial class frmEditOrAddCodeByHtml : Form
    {
        public frmEditOrAddCodeByHtml()
        {
            InitializeComponent();
            //this.wbEdit.Url = new Uri("/kindeditor/asp.net/edit.html", UriKind.Relative);
            this.wbEdit.Url = new Uri(Application.StartupPath + "\\web\\edit.html", UriKind.Absolute);
        }
        Jyson.MyCodeManage.BLL.CodeContent codeContentBll = new BLL.CodeContent();
        Jyson.MyCodeManage.Model.CodeContent codeContentModel = new Model.CodeContent();
        public bool IsAdd = true;
        public int AddCodeTypeId = 0;////从主窗体传过来选择的类别ID值
        public int EditId = 0;//从主窗体传过来要修改的ID值
        public string content = "";
        public string title = "";
        private void frmEditOrAddCodeByHtml_Load(object sender, EventArgs e)
        {
            BindComboBox();
            if (EditId != 0)
            {
                codeContentModel = codeContentBll.GetModel(EditId);
                txtRemark.Text = codeContentModel.Remark;
                txtTitle.Text = codeContentModel.Title;
                content = codeContentModel.Content;
                cboCodeType.SelectedValue = codeContentModel.CodeTypeId;
            }
            else
            {
                txtTitle.Text = title;
                cboCodeType.SelectedValue = AddCodeTypeId;
            }
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindComboBox()
        {
            DataTable dt = new Jyson.MyCodeManage.BLL.CodeType().GetAllList().Tables[0];
            Jyson.MyCodeManage.Utility.Common.BindComboBox(dt, cboCodeType, "Id", "TypeName");
            cboCodeType.SelectedIndex = 0;
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                Utility.MsgBox.MsgBoxErrors("请填写标题！");
                return;
            }
            if (cboCodeType.SelectedIndex==-1)
            {
                Utility.MsgBox.MsgBoxErrors("请选择类别！");
                return;
            }
            codeContentModel.Title = txtTitle.Text.Trim();
            codeContentModel.CreateTime = DateTime.Now;
            codeContentModel.Remark = txtRemark.Text.Trim();
            codeContentModel.UpdateTime = DateTime.Now;
            codeContentModel.CodeTypeId = (int)cboCodeType.SelectedValue;
            codeContentModel.Content = wbEdit.Document.InvokeScript("getHtml").ToString();
            if (IsAdd)
            {
                if (codeContentBll.Add(codeContentModel))
                {
                    Utility.MsgBox.MsgBoxOK("增加成功");
                    this.Close();
                    return;
                }
            }
            else
            {
                if (codeContentBll.Update(codeContentModel))
                {
                    Utility.MsgBox.MsgBoxOK("修改成功");
                    this.Close();
                    return;
                }
            }
            Utility.MsgBox.MsgBoxErrors("我勒个去，出错了。");
        }

        private void wbEdit_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wbEdit.Document.InvokeScript("setHtml", new object[] { content });
        }
    }
}
