﻿using Jyson.MyCodeManage.Utility;
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
    public partial class frmDBSwitch : Form
    {
        INIClass ini = new INIClass(Application.StartupPath + "\\mcs.ini");
        public frmDBSwitch()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdoRelease.Checked)
            {
                ini.IniWriteValue("DataBase", "Connection", "release");
            }
            else
            {
                ini.IniWriteValue("DataBase", "Connection", "test");
            }
            MsgBox.MsgBoxOK("保存成功");
        }

        private void frmDBSwitch_Load(object sender, EventArgs e)
        {
            string strConn = ini.IniReadValue("DataBase", "Connection");
            if (strConn=="test")
            {
                rdoTest.Checked = true;
            }
            else
            {
                rdoRelease.Checked = true;
            }
        }
    }
}
