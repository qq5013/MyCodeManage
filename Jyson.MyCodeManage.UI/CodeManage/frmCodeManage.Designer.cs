namespace Jyson.MyCodeManage.UI
{
    partial class frmCodeManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCodeTypeManage = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvwContent = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rdoCnBlogs = new System.Windows.Forms.RadioButton();
            this.rdoCSDN = new System.Windows.Forms.RadioButton();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.cboCodeType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wbShow = new System.Windows.Forms.WebBrowser();
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCodeTypeManage);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.rdoCnBlogs);
            this.panel1.Controls.Add(this.rdoCSDN);
            this.panel1.Controls.Add(this.rdoLocal);
            this.panel1.Controls.Add(this.cboCodeType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtKeys);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnCodeTypeManage
            // 
            this.btnCodeTypeManage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCodeTypeManage.Image = global::Jyson.MyCodeManage.UI.Properties.Resources.tool_box;
            this.btnCodeTypeManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCodeTypeManage.Location = new System.Drawing.Point(174, 546);
            this.btnCodeTypeManage.Name = "btnCodeTypeManage";
            this.btnCodeTypeManage.Size = new System.Drawing.Size(78, 30);
            this.btnCodeTypeManage.TabIndex = 10;
            this.btnCodeTypeManage.Text = "类别管理";
            this.btnCodeTypeManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCodeTypeManage.UseVisualStyleBackColor = true;
            this.btnCodeTypeManage.Click += new System.EventHandler(this.btnCodeTypeManage_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Jyson.MyCodeManage.UI.Properties.Resources.Approve;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(119, 546);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(54, 30);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "修改";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Image = global::Jyson.MyCodeManage.UI.Properties.Resources._04;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(64, 546);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(54, 30);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Jyson.MyCodeManage.UI.Properties.Resources._07;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(9, 546);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "增加";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tvwContent);
            this.groupBox1.Location = new System.Drawing.Point(7, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 479);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // tvwContent
            // 
            this.tvwContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwContent.ImageIndex = 0;
            this.tvwContent.ImageList = this.imageList1;
            this.tvwContent.Location = new System.Drawing.Point(3, 17);
            this.tvwContent.Name = "tvwContent";
            this.tvwContent.SelectedImageIndex = 0;
            this.tvwContent.Size = new System.Drawing.Size(245, 459);
            this.tvwContent.TabIndex = 0;
            this.tvwContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwContent_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fldr_obj.gif");
            this.imageList1.Images.SetKeyName(1, "mediacy.gif");
            this.imageList1.Images.SetKeyName(2, "gotoobj_tsk.gif");
            // 
            // rdoCnBlogs
            // 
            this.rdoCnBlogs.AutoSize = true;
            this.rdoCnBlogs.Location = new System.Drawing.Point(199, 12);
            this.rdoCnBlogs.Name = "rdoCnBlogs";
            this.rdoCnBlogs.Size = new System.Drawing.Size(65, 16);
            this.rdoCnBlogs.TabIndex = 5;
            this.rdoCnBlogs.Text = "CnBlogs";
            this.rdoCnBlogs.UseVisualStyleBackColor = true;
            // 
            // rdoCSDN
            // 
            this.rdoCSDN.AutoSize = true;
            this.rdoCSDN.Location = new System.Drawing.Point(155, 12);
            this.rdoCSDN.Name = "rdoCSDN";
            this.rdoCSDN.Size = new System.Drawing.Size(47, 16);
            this.rdoCSDN.TabIndex = 4;
            this.rdoCSDN.Text = "CSDN";
            this.rdoCSDN.UseVisualStyleBackColor = true;
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Checked = true;
            this.rdoLocal.Location = new System.Drawing.Point(110, 12);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.Size = new System.Drawing.Size(47, 16);
            this.rdoLocal.TabIndex = 3;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "本地";
            this.rdoLocal.UseVisualStyleBackColor = true;
            this.rdoLocal.CheckedChanged += new System.EventHandler(this.rdoLocal_CheckedChanged);
            // 
            // cboCodeType
            // 
            this.cboCodeType.FormattingEnabled = true;
            this.cboCodeType.Location = new System.Drawing.Point(8, 11);
            this.cboCodeType.Name = "cboCodeType";
            this.cboCodeType.Size = new System.Drawing.Size(97, 20);
            this.cboCodeType.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Jyson.MyCodeManage.UI.Properties.Resources._17;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(199, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(53, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "搜索";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.Location = new System.Drawing.Point(8, 37);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(185, 21);
            this.txtKeys.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wbShow);
            this.panel2.Controls.Add(this.groupBoxBanner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 583);
            this.panel2.TabIndex = 1;
            // 
            // wbShow
            // 
            this.wbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbShow.Location = new System.Drawing.Point(0, 45);
            this.wbShow.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbShow.Name = "wbShow";
            this.wbShow.Size = new System.Drawing.Size(733, 538);
            this.wbShow.TabIndex = 2;
            this.wbShow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbShow_DocumentCompleted);
            this.wbShow.NewWindow += new System.ComponentModel.CancelEventHandler(this.wbShow_NewWindow);
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Controls.Add(this.btnSave);
            this.groupBoxBanner.Controls.Add(this.btnPrevious);
            this.groupBoxBanner.Controls.Add(this.btnNext);
            this.groupBoxBanner.Controls.Add(this.lbl_Title);
            this.groupBoxBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBanner.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(733, 45);
            this.groupBoxBanner.TabIndex = 0;
            this.groupBoxBanner.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(64, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "收藏";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevious.Location = new System.Drawing.Point(15, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(45, 23);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "←";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(113, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Title.Location = new System.Drawing.Point(164, 18);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(0, 17);
            this.lbl_Title.TabIndex = 20;
            // 
            // frmCodeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodeManage";
            this.Text = "B2B备忘";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxBanner.ResumeLayout(false);
            this.groupBoxBanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCnBlogs;
        private System.Windows.Forms.RadioButton rdoCSDN;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.ComboBox cboCodeType;
        private System.Windows.Forms.Button btnCodeTypeManage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TreeView tvwContent;
        private System.Windows.Forms.WebBrowser wbShow;
        private System.Windows.Forms.GroupBox groupBoxBanner;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imageList1;



    }
}