using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jyson.MyCodeManage.UI.JsonFormat
{
    public partial class frmJsonFormat : BaseForm
    {
        public frmJsonFormat()
        {
            InitializeComponent();
        }

        private void frmJsonFormat_Load(object sender, EventArgs e)
        {
            this.wbJson.Url = new Uri(Application.StartupPath + "\\jsonWeb\\index.htm", UriKind.Absolute);
        }
    }
}
