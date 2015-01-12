namespace Jyson.MyCodeManage.UI.PPMoneyTool
{
    partial class frmDBSwitch
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
            this.rdoRelease = new System.Windows.Forms.RadioButton();
            this.rdoTest = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoRelease
            // 
            this.rdoRelease.AutoSize = true;
            this.rdoRelease.Location = new System.Drawing.Point(54, 31);
            this.rdoRelease.Name = "rdoRelease";
            this.rdoRelease.Size = new System.Drawing.Size(137, 16);
            this.rdoRelease.TabIndex = 0;
            this.rdoRelease.TabStop = true;
            this.rdoRelease.Text = "ppmoney_nop_release";
            this.rdoRelease.UseVisualStyleBackColor = true;
            // 
            // rdoTest
            // 
            this.rdoTest.AutoSize = true;
            this.rdoTest.Location = new System.Drawing.Point(54, 74);
            this.rdoTest.Name = "rdoTest";
            this.rdoTest.Size = new System.Drawing.Size(119, 16);
            this.rdoTest.TabIndex = 1;
            this.rdoTest.TabStop = true;
            this.rdoTest.Text = "ppmoney_nop_test";
            this.rdoTest.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Jyson.MyCodeManage.UI.Properties.Resources._01;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(94, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmDBSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 194);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdoTest);
            this.Controls.Add(this.rdoRelease);
            this.Name = "frmDBSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "切换数据库";
            this.Load += new System.EventHandler(this.frmDBSwitch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoRelease;
        private System.Windows.Forms.RadioButton rdoTest;
        private System.Windows.Forms.Button btnSave;
    }
}