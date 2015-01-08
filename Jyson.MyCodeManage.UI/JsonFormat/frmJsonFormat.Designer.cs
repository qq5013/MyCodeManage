namespace Jyson.MyCodeManage.UI.JsonFormat
{
    partial class frmJsonFormat
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
            this.wbJson = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbJson
            // 
            this.wbJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbJson.Location = new System.Drawing.Point(0, 0);
            this.wbJson.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbJson.Name = "wbJson";
            this.wbJson.Size = new System.Drawing.Size(963, 672);
            this.wbJson.TabIndex = 0;
            // 
            // frmJsonFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 672);
            this.Controls.Add(this.wbJson);
            this.Name = "frmJsonFormat";
            this.Text = "Json格式化";
            this.Load += new System.EventHandler(this.frmJsonFormat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbJson;
    }
}