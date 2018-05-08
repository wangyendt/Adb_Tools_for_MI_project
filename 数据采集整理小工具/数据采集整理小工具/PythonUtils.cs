using System.Diagnostics;

namespace 数据采集整理小工具
{
    public static class PythonUtils
    {
        private static string execute(string cmd, string args)
        {
            Process p = new Process();
            p.StartInfo.FileName = "python35.exe";
            p.StartInfo.Arguments = cmd + " " + args;    //设定程式执行參數   
            p.StartInfo.UseShellExecute = false;        //关闭Shell的使用   
            p.StartInfo.RedirectStandardInput = true;   //重定向标准输入   
            p.StartInfo.RedirectStandardOutput = true;  //重定向标准输出   
            p.StartInfo.RedirectStandardError = true;   //重定向错误输出   
            p.StartInfo.CreateNoWindow = true;          //设置不显示窗口   
            p.Start();
            string ret = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();
            return ret;
        }

        public static string show_data_figure(string path)
        {
            return execute(@"draw.py", path);
        }
    }
}