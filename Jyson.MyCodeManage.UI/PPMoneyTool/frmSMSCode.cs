using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jyson.MyCodeManage.UI.PPMoneyTool
{
    public partial class frmSMSCode : BaseForm
    {
        BLL.SMSRecord _smsRecordBLL = new BLL.SMSRecord();
        public frmSMSCode()
        {
            InitializeComponent();
        }

        private void frmSMSCode_Load(object sender, EventArgs e)
        {
            DataBind("");
        }

        private void DataBind(string where)
        {
            DataTable table = _smsRecordBLL.GetList(100, "sendtype=0" + where, "Id desc").Tables[0];
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //设置显示的列名
            this.dataGridView1.Columns["Phone"].HeaderText = "手机号";
            this.dataGridView1.Columns["CreateDate"].HeaderText = "创建时间";
            this.dataGridView1.Columns["VerifyCode"].HeaderText = "验证码";
            this.dataGridView1.Columns["Content"].HeaderText = "内容";
            //设置列的宽度
            this.dataGridView1.Columns["Phone"].Width = 150;
            this.dataGridView1.Columns["CreateDate"].Width = 150;
            this.dataGridView1.Columns["VerifyCode"].Width = 100;
            this.dataGridView1.Columns["Content"].Width = 580;
            //隐藏某列
            this.dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Columns["SendType"].Visible = false;
            this.dataGridView1.Columns["Priority"].Visible = false;
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim()!="")
            {
                DataBind(" and phone like '%"+txtPhone.Text.Trim()+"%'");
            }
            else
            {
                DataBind("");
            }
        }
    }
}
