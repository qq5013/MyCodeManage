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
    public partial class frmCodeType : Form
    {
        public frmCodeType()
        {
            InitializeComponent();
        }
        Jyson.MyCodeManage.BLL.CodeType codeType = new BLL.CodeType();
        Model.CodeType codeTypeModel = new Model.CodeType();
        string selectTreeId = "";
        private bool IsAdd = false;//是否是增加操作 
        private void frmCodeType_Load(object sender, EventArgs e)
        {
            txtCodeTypeName.Enabled = false;
            txtOrder.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            fillTree();
        }
        /// <summary>
        /// 绑定树结点方法
        /// </summary>
        private void fillTree()
        {
            this.tv_list.Nodes.Clear();
            tv_list.ImageIndex = 1;//设置treeView的默认图标
            tv_list.SelectedImageIndex = 2;//设置treeView的选择后的节点图标
            TreeNode tn = tv_list.Nodes.Add("AllType", "所有类别", 0);//设置父节点名称
            List<Model.CodeType> list = codeType.GetModelList("").OrderBy(m=>m.OrderNo).ToList();
            foreach (Model.CodeType item in list)
            {
              TreeNode tnChild= tn.Nodes.Add(item.Id.ToString(), item.TypeName);
              tnChild.Tag = item;
            }
            tv_list.ExpandAll();
        }
        /// <summary>
        /// 当选择树后，绑定数据到文本框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_list_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectTreeId = "";
            if (e.Node.Name != "AllType")
            {
                Model.CodeType codeType=e.Node.Tag as Model.CodeType;
                selectTreeId = e.Node.Name;
                txtCodeTypeName.Text = e.Node.Text;
                txtOrder.Text = codeType.OrderNo.ToString();
                return;
            }
            
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodeTypeName.Text))
            {
                MessageBox.Show("类别名称不能为空！");
                return;
            }
            if (!Utility.Validation.validateNum(txtOrder.Text.Trim()))
            {
                Utility.MsgBox.MsgBoxErrors("类别排序请输入数字！");
                return;
            }
            codeTypeModel.TypeName = txtCodeTypeName.Text.Trim();
            codeTypeModel.OrderNo = int.Parse(txtOrder.Text.Trim());
            if (IsAdd)//增加
            {
                if (codeType.Add(codeTypeModel))
                {
                    MessageBox.Show("增加类别成功！");
                }
            }
            else//修改
            {
                if (string.IsNullOrEmpty(selectTreeId))
                {
                    return;
                }
                codeTypeModel.Id = int.Parse(selectTreeId);
                if (codeType.Update(codeTypeModel))
                {
                    MessageBox.Show("修改类别成功！");
                }
            }
            fillTree();

        }
        //修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsAdd = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;

            txtCodeTypeName.Enabled = true;
            txtOrder.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;

        } 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOrder.Text = "";
            txtCodeTypeName.Text = "";
            IsAdd = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;

            txtCodeTypeName.Enabled = true;
            txtOrder.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
        }
        /// <summary>
        /// 撤消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            IsAdd = true;
            selectTreeId = "";
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = true;

            txtCodeTypeName.Enabled = false;
            txtOrder.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectTreeId != "")
            {
                if (!Utility.MsgBox.MsgBoxQuestion("是否真的要删除该类别？"))
                {
                    return;
                }
                if (codeType.Delete(int.Parse(selectTreeId)))
                {
                    Utility.MsgBox.MsgBoxOK("删除成功");
                    fillTree();
                    return;
                }
            }
            else
                MessageBox.Show("请选择要删除的一条记录！");

        }

    }
}
