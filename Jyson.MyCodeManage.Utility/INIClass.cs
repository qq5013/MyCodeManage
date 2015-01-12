using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jyson.MyCodeManage.Utility
{
    public class INIClass
    {

        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary> 
        /// 构造方法 
        /// </summary> 
        /// <param name="INIPath">文件路径</param> 
        public string inipath;
        public INIClass(string INIPath)
        {
            inipath = INIPath;
        }

        /// <summary> 
        /// 写入INI文件 
        /// </summary> 
        /// <param name="Section">配置节(如 [TypeName] )</param> 
        /// <param name="Key">键名</param> 
        /// <param name="Value">键值</param> 
        public  void IniWriteValue(string Section, string Key, string Value)
        {
            // section=配置节，key=键名，value=键值，filePath=完整路径和名称
            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }
        /// <summary> 
        /// 读出INI文件 
        /// </summary> 
        /// <param name="Section">项目名称(如 [TypeName] )</param> 
        /// <param name="Key">键</param> 
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            // section=配置节，key=键名，def=无法读取时缺省数值，temp=读取数值，size＝数值的大小，filePath=完整路径和名称
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.inipath);
            return temp.ToString();
        }

        //INIClass ini = new INIClass(Application.StartupPath + "\\mcs.ini");
        //private void btnWriteINI_Click(object sender, EventArgs e)
        //{
        //    ini.IniWriteValue("TypeTest", "Connection", textBox1.Text);
        //}

        //private void btnReadINI_Click(object sender, EventArgs e)
        //{
        //    textBox2.Text = ini.IniReadValue("TypeTest", "Connection");
        //}

    }
}
