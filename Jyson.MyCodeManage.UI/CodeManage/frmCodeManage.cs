using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Text.RegularExpressions;

namespace Jyson.MyCodeManage.UI
{
    public partial class frmCodeManage : BaseForm
    {
        public frmCodeManage()
        {
            InitializeComponent();
        }
        Jyson.MyCodeManage.BLL.CodeType codeTypeBll = new BLL.CodeType();
        Jyson.MyCodeManage.Model.CodeType codeTypeModel = new Model.CodeType();
        Jyson.MyCodeManage.BLL.CodeContent codeContentBll = new BLL.CodeContent();
        Jyson.MyCodeManage.Model.CodeContent codeContentModel = new Model.CodeContent();
        string web_code = "";
        private int selectCodeTypeId = 0;//当前选择类别的ID
        private int selectCodeContentId = 0;//当前选择的ID
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            BindComboBox();
            groupBoxBanner.Visible = false;
            //使用webbrowser控件有个常见的问题就是js脚本错误弹出框,所以需要加代码屏蔽掉
            this.wbShow.ScriptErrorsSuppressed = true;
            this.wbShow.Url = new Uri(Application.StartupPath + "\\web\\show.html", UriKind.Absolute);
            fillTree();
        }
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindComboBox()
        {
            DataTable dt = codeTypeBll.GetAllList().Tables[0].Clone();
            dt.Rows.Add("0", "全部", "0");
            foreach (DataRow dr in codeTypeBll.GetAllList().Tables[0].Rows)
            {
                dt.Rows.Add(dr[0], dr[1], dr[2]);
            }
            Jyson.MyCodeManage.Utility.Common.BindComboBox(dt, cboCodeType, "Id", "TypeName");
            cboCodeType.SelectedIndex = 0;
        }
        /// <summary>
        /// 绑定树结点方法
        /// </summary>
        private void fillTree()
        {
            this.tvwContent.Nodes.Clear();
            tvwContent.ImageIndex = 0;//设置treeView的默认图标
            tvwContent.SelectedImageIndex = 2;//设置treeView的选择后的节点图标
            if (cboCodeType.SelectedValue.ToString() == "0")
            {
                List<Model.CodeType> list = codeTypeBll.GetModelList("").OrderBy(m => m.OrderNo).ToList();
                foreach (Model.CodeType item in list)
                {
                    TreeNode tn = new TreeNode();
                    tn.Tag = item.Id;
                    tn.Name = "0";
                    tn.Text = item.TypeName;
                    tvwContent.Nodes.Add(tn);
                    //TreeNode tn = tvwContent.Nodes.Add("0", item.TypeName);
                    List<Model.CodeContent> codeContentList = codeContentBll.GetModelList("").Where(m => m.CodeTypeId == item.Id).ToList();
                    foreach (Model.CodeContent contentList in codeContentList)
                    {
                        tn.Nodes.Add(contentList.Id.ToString(), contentList.Title, 1);
                    }
                }
            }
            //tvwContent.ExpandAll();
        }
        /// <summary>
        /// 当树选择后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvwContent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "0" || string.IsNullOrEmpty(e.Node.Name))
            {
                selectCodeTypeId = (int)e.Node.Tag;
                selectCodeContentId = 0;
                return;
            }
            selectCodeContentId = int.Parse(e.Node.Name);
            LoadContent(int.Parse(e.Node.Name));

        }
        private void LoadContent(int id)
        {
            DataTable dt = codeContentBll.GetList(id).Tables[0];
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"<center><H2>" + dt.Rows[0]["Title"].ToString() + "</H2></center>");
            sb.AppendLine("<small><font face=\"Arial, Helvetica\">分类：" + dt.Rows[0]["TypeName"].ToString());
            sb.AppendLine("&nbsp&nbsp&nbsp&nbsp录入时间：" + dt.Rows[0]["CreateTime"].ToString());
            sb.AppendLine("&nbsp&nbsp&nbsp&nbsp编辑时间：" + dt.Rows[0]["UpdateTime"].ToString());
            sb.AppendLine("<hr />" + dt.Rows[0]["Content"].ToString());
            sb.AppendLine("<br/><br/><br/><br/><hr/>备注：" + dt.Rows[0]["Remark"].ToString());
            sb.AppendLine("</font><small>");
            wbShow.Document.Body.InnerHtml = sb.ToString();
            wbShow.Document.InvokeScript("prettyPrint");
        }
        //类别管理
        private void btnCodeTypeManage_Click(object sender, EventArgs e)
        {
            frmCodeType codeType = new frmCodeType();
            codeType.ShowDialog();
            codeType.Dispose();
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditOrAddCodeByHtml codeByHtml = new frmEditOrAddCodeByHtml();
            codeByHtml.IsAdd = true;
            codeByHtml.AddCodeTypeId = selectCodeTypeId;
            codeByHtml.Text = "增加条目";
            codeByHtml.ShowDialog();
            codeByHtml.Dispose();
            fillTree();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectCodeContentId == 0)
            {
                Utility.MsgBox.MsgBoxErrors("请选择一条要删除的记录！");
                return;
            }
            if (!Utility.MsgBox.MsgBoxQuestion("是否要删除该条记录？"))
            {
                return;
            }
            if (codeContentBll.Delete(selectCodeContentId))
            {
                Utility.MsgBox.MsgBoxOK("删除成功！");
                fillTree();
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectCodeContentId == 0)
            {
                Utility.MsgBox.MsgBoxErrors("请选择一条要修改的记录！");
                return;
            }
            frmEditOrAddCodeByHtml codeByHtml = new frmEditOrAddCodeByHtml();
            codeByHtml.IsAdd = false;
            codeByHtml.EditId = selectCodeContentId;
            codeByHtml.Text = "修改条目";
            codeByHtml.ShowDialog();
            codeByHtml.Dispose();
            fillTree();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.rdoLocal.Checked)
            {
                Search();
            }
            else
            {
                this.lbl_Title.Text = "载入中 .........";
                wbShow.Visible = true;
                if (this.rdoCnBlogs.Checked)
                {
                    this.wbShow.Navigate("http://zzk.cnblogs.com/s?w=" + HttpUtility.UrlEncode(this.txtKeys.Text));

                }
                else if (this.rdoCSDN.Checked)
                {
                    this.wbShow.Navigate("http://so.csdn.net/search?t=blog&q=" + HttpUtility.UrlEncode(this.txtKeys.Text));
                }
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Search()
        {
            this.tvwContent.Nodes.Clear();
            tvwContent.ImageIndex = 0;//设置treeView的默认图标
            tvwContent.SelectedImageIndex = 2;//设置treeView的选择后的节点图标
            if (cboCodeType.SelectedValue.ToString() == "0")
            {
                List<Model.CodeType> list = codeTypeBll.GetModelList("").OrderBy(m => m.OrderNo).ToList();
                foreach (Model.CodeType item in list)
                {
                    TreeNode tn = new TreeNode();
                    tn.Tag = item.Id;
                    tn.Name = "0";
                    tn.Text = item.TypeName;
                    tvwContent.Nodes.Add(tn);
                    //TreeNode tn = tvwContent.Nodes.Add("0", item.TypeName);
                    List<Model.CodeContent> codeContentList = codeContentBll.GetModelList("").Where(m => m.CodeTypeId == item.Id).Where(m => m.Title.Contains(txtKeys.Text.Trim()) || m.Remark.Contains(txtKeys.Text.Trim())).ToList();
                    foreach (Model.CodeContent contentList in codeContentList)
                    {
                        tn.Nodes.Add(contentList.Id.ToString(), contentList.Title, 1);
                    }
                }
            }
            else
            {
                List<Model.CodeType> list = codeTypeBll.GetModelList("").Where(m => m.Id == int.Parse(cboCodeType.SelectedValue.ToString())).OrderBy(m => m.OrderNo).ToList();
                foreach (Model.CodeType item in list)
                {
                    TreeNode tn = new TreeNode();
                    tn.Tag = item.Id;
                    tn.Name = "0";
                    tn.Text = item.TypeName;
                    tvwContent.Nodes.Add(tn);
                    //TreeNode tn = tvwContent.Nodes.Add("0", item.TypeName);
                    List<Model.CodeContent> codeContentList = new List<Model.CodeContent>();
                    if (string.IsNullOrEmpty(txtKeys.Text))
                    {
                        codeContentList = codeContentBll.GetModelList("").Where(m => m.CodeTypeId == item.Id).ToList();
                    }
                    else
                    {
                        codeContentList = codeContentBll.GetModelList("").Where(m => m.CodeTypeId == item.Id).Where(m => m.Title.Contains(txtKeys.Text.Trim()) || m.Remark.Contains(txtKeys.Text.Trim())).ToList();
                    }
                    foreach (Model.CodeContent contentList in codeContentList)
                    {
                        tn.Nodes.Add(contentList.Id.ToString(), contentList.Title, 1);
                    }
                }
            }
            if (cboCodeType.SelectedIndex != 0)
            {
                tvwContent.ExpandAll();
            }
        }

        private void rdoLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocal.Checked)
            {
                this.wbShow.Url = new Uri(Application.StartupPath + "\\web\\show.html", UriKind.Absolute);
                groupBoxBanner.Visible = false;
                tvwContent.Enabled = true;

            }

            else
            {
                tvwContent.Enabled = false;
                groupBoxBanner.Visible = true;
                btnSave.Enabled = false;
            }

        }
        /// <summary>
        /// 浏览标题显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wbShow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.btnSave.Enabled = false;
            this.lbl_Title.Text = this.wbShow.Document.Title;
            if (this.rdoCnBlogs.Checked)
            {
                if (this.wbShow.Document.GetElementById("cnblogs_post_body") != null)
                {
                    web_code = this.wbShow.Document.GetElementById("cnblogs_post_body").InnerHtml;
                }
            }
            else if (this.rdoCSDN.Checked)
            {
                if (this.wbShow.Document.GetElementById("article_content") != null)
                {
                    web_code = this.wbShow.Document.GetElementById("article_content").InnerHtml;
                }
            }
            if (!string.IsNullOrEmpty(web_code))
            {
                this.btnSave.Enabled = true;
            }
        }
        /// <summary>
        /// 解决点击连接会出现调用系统的IE浏览器打开窗体的情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wbShow_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            string a_html = wbShow.Document.ActiveElement.OuterHtml;
            if (a_html.IndexOf("href") > -1)
            {
                string url = new Regex("href=\"[\\d\\D]+?\"").Match(a_html).Value.Replace("href=\"", "").Replace("\"", "");
                this.wbShow.Navigate(url);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.wbShow.GoBack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.wbShow.GoForward();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string html = "";
            if (this.rdoCnBlogs.Checked)
            {
                html = web_code.Replace(" src=\"/Images/", " src=\"Images/");
            }
            else if (this.rdoCSDN.Checked)
            {
                html = web_code;
            }
            if (!string.IsNullOrEmpty(web_code))
            {
                this.btnSave.Visible = true;
            }

            frmEditOrAddCodeByHtml codeByHtml = new frmEditOrAddCodeByHtml();
            codeByHtml.content = html;
            codeByHtml.Text = "增加条目";
            codeByHtml.title = this.lbl_Title.Text;
            codeByHtml.ShowDialog();
            codeByHtml.Dispose();
            fillTree();
        }

    }
}
