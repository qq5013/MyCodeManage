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
            try
            {
                DataTable table = _smsRecordBLL.GetList(100, "sendtype=0", "Id desc").Tables[0];

                dataGridView1.DataSource = table;

                //this.dataGridView1.Columns[0].HeaderText = "手机号";
                //this.dataGridView1.Columns[1].HeaderCell.Value = "创建时间";
                //this.dataGridView1.Columns[2].HeaderCell.Value = "验证码";
                //this.dataGridView1.Columns[3].HeaderCell.Value = "内容";

                //int RowsCount = table.Rows.Count;
                //for (int i = 0; i < RowsCount; i++)
                //{
                //    dataGridView1.Rows.Add(
                //        table.Rows[i]["Phone"].ToString(),
                //        table.Rows[i]["CreateDate"].ToString(),
                //        table.Rows[i]["VerifyCode"].ToString(),
                //        table.Rows[i]["Content"].ToString()
                //        );
                //}
            }
            catch (Exception ex)
            {

            }

        }
        //void BindData()
        //{
        //    listView1.Items.Clear();
        //    //string Keywords = txtKeywords.Text == "关键字..." ? "" : txtKeywords.Text;

        //    DataTable table = _smsRecordBLL.GetList(100, "sendtype=0", "Id desc").Tables[0];


        //    listView1.GridLines = true; //显示各个记录的分隔线   
        //    listView1.FullRowSelect = true; //要选择就是一行   
        //    listView1.View = View.Details; //定义列表显示的方式   
        //    listView1.Scrollable = true; //需要时候显示滚动条   
        //    listView1.MultiSelect = false; // 不可以多行选择   
        //    listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;

        //    ImageList imgList = new ImageList(); 
        //    imgList.ImageSize = new Size(1, 25);//分别是宽和高 
        //    listView1.SmallImageList = imgList; //这里设置listView的SmallImageList ,用imgList将其撑大

        //    // 显示表头   
        //    listView1.Columns.Clear();
        //    listView1.Columns.Add("手机号", 150, HorizontalAlignment.Left);
        //    listView1.Columns.Add("创建时间", 150, HorizontalAlignment.Left);
        //    listView1.Columns.Add("验证码", 80, HorizontalAlignment.Left);
        //    listView1.Columns.Add("内容",400, HorizontalAlignment.Left);

        //    int RowsCount = table.Rows.Count;
        //    for (int i = 0; i < RowsCount; i++)
        //    {
        //        ListViewItem li = new ListViewItem();
        //        li.SubItems.Clear();
        //        li.ImageIndex = 0;
        //        li.SubItems[0].Text = table.Rows[i]["Phone"].ToString();
        //        li.SubItems.Add(table.Rows[i]["CreateDate"].ToString());
        //        li.SubItems.Add(table.Rows[i]["VerifyCode"].ToString());
        //        li.SubItems.Add(table.Rows[i]["Content"].ToString());
        //        li.Tag = table.Rows[i]["Id"];
        //        listView1.Items.Add(li);
        //    }

        //}
    }
}
