using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据采集整理小工具
{
    public static class CmdUtils
    {
        private static void execute(string exe, string args)
        {
            Process p = new Process();
            p.StartInfo.FileName = exe;
            p.StartInfo.Arguments = args; //设定程式执行參數   
            p.StartInfo.UseShellExecute = false; //关闭Shell的使用   
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入   
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出   
            p.StartInfo.RedirectStandardError = true; //重定向错误输出   
            p.StartInfo.CreateNoWindow = true; //设置不显示窗口   
            p.Start();
            string ret = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
        }

        public static void Analyze(string strNo)
        {
            execute("analyzer.exe", strNo);
        }

        public static void SaveResult(string strNo)
        {
            execute("save_result.exe", strNo);
        }
    }
}