﻿using Jyson.MyCodeManage.UI.PPMoneyTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Jyson.MyCodeManage.UI
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //显示打开的窗体图标
            //dockPanel.ShowDocumentIcon = true;
        }

        #region --加载窗体
        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="form"></param>
        private void LoadShowForm(BaseForm form)
        {
            if (SetSelectActivate(form.Text))
            {
                return;
            }
            ServerSide.SplashScreen.Splasher.Status = "窗体正在加载中，请稍等......";
            System.Threading.Thread.Sleep(100);
            ServerSide.SplashScreen.Splasher.Show(typeof(ServerSide.SplashScreen.frmSplash));

            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                form.MdiParent = this;
                form.Show();
            }
            else
                form.Show(this.dockPanel);

            System.Threading.Thread.Sleep(50);
            ServerSide.SplashScreen.Splasher.Close();
        }
        private void menuItemB2BMemo_Click(object sender, EventArgs e)
        {
            frmCodeManage codeManage = new frmCodeManage();
            LoadShowForm(codeManage);

        }
        private void menuItemSMSCode_Click(object sender, EventArgs e)
        {
            frmSMSCode smsCode = new frmSMSCode();
            LoadShowForm(smsCode);
        }
        //private void menuItemEInsureLog_Click(object sender, EventArgs e)
        //{
        //    ProductCheckLog.frmEInsureLog frmEInsureLog = new ProductCheckLog.frmEInsureLog();
        //    LoadShowForm(frmEInsureLog);
        //} 
        #endregion


        private IDockContent FindDocument(string text)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                    if (form.Text == text)
                        return form as IDockContent;

                return null;
            }
            else
            {
                foreach (IDockContent content in dockPanel.Documents)
                    if (content.DockHandler.TabText == text)
                        return content;

                return null;
            }
        }


        public void CloseAllDocuments()
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
            }
            else
            {
                IDockContent[] documents = dockPanel.DocumentsToArray();
                foreach (IDockContent content in documents)
                {
                    content.DockHandler.Close();
                }
            }
        }
        /// <summary>
        /// 设置当前窗体为活动
        /// </summary>
        /// <param name="strText"></param>
        private bool SetSelectActivate(string strText)
        {
            IDockContent content = FindDocument(strText);
            if (content != null)
            {
                content.DockHandler.Activate();//设置当前窗体为活动
                return true;
            }
            return false;
        }

        /// <summary>
        /// 导航栏点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == toolBarB2BMemo)
                menuItemB2BMemo_Click(null, null);
            else if (e.ClickedItem == toolBarSMSCode)
            {
                menuItemSMSCode_Click(null, null);
            }
            else if (e.ClickedItem == toolBarMstsc)
            {
                menuItemMstsc_Click(null, null);
            }

        }

        #region --文件
        private void menuItemClose_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
                ActiveMdiChild.Close();
            else if (dockPanel.ActiveDocument != null)
                dockPanel.ActiveDocument.DockHandler.Close();
        }

        private void menuItemCloseAll_Click(object sender, System.EventArgs e)
        {
            CloseAllDocuments();
        }

        private void menuItemCloseAllButThisOne_Click(object sender, System.EventArgs e)
        {
            if (dockPanel.DocumentStyle == DocumentStyle.SystemMdi)
            {
                Form activeMdi = ActiveMdiChild;
                foreach (Form form in MdiChildren)
                {
                    if (form != activeMdi)
                        form.Close();
                }
            }
            else
            {
                foreach (IDockContent document in dockPanel.DocumentsToArray())
                {
                    if (!document.DockHandler.IsActivated)
                        document.DockHandler.Close();
                }
            }
        }

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        #endregion

        #region --工具
        private void menuItemShowDocumentIcon_Click(object sender, System.EventArgs e)
        {
            dockPanel.ShowDocumentIcon = menuItemShowDocumentIcon.Checked = !menuItemShowDocumentIcon.Checked;
        }

        private void menuItemNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void menuItemCalc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.WorkingDirectory = Application.StartupPath + "/JsonView/";//要启动程序路径
            p.StartInfo.FileName = "JsonView.exe";//需要启动的程序名   
            p.Start();//启动     
            //System.Diagnostics.Process.Start("calc.exe");
        }

        private void menuItemMstsc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mstsc.exe");
        }
        #endregion


    }
}
