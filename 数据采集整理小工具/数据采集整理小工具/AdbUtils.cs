using System.Diagnostics;

namespace 数据采集整理小工具
{
    public static class AdbUtils
    {
        private static string execute(string cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = cmd;    //设定程式执行參數   
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

        public static string install_apk(string apk_path)
        {
            execute(@"/c adb uninstall com.ndt.collection");
            return execute(@"/c adb install -r " + apk_path);
        }

        public static void screen_shot()
        {
            execute(@"/c adb shell ""system/bin/screencap"" /sdcard/screenshot.png");
            execute(@"/c adb pull /sdcard/screenshot.png ./");
        }

        public static string[] authorized()
        {
            string[] ret = new string[2];
            ret[0] = execute(@"/c adb shell chmod 777 /dev/ndt_i2c_node");
            ret[1] = execute(@"/c adb shell setenforce 0");
            execute(@"/c adb shell settings put system screen_brightness 150");
            execute(@"/c adb shell settings put system screen_off_timeout 1800000");
            return ret;
        }

        public static string open_apk()
        {
            //execute(@"/c adb shell input keyevent 26");
            execute(@"/c adb shell input swipe 540 1500 540 500");
            return execute(@"/c adb shell am start -n com.ndt.collection/.core.MainActivity");
        }

        public static void authorize_apk()
        {
            execute(@"/c adb shell input tap 920 1250");
        }

        public static string close_apk()
        {
            return execute(@"/c adb shell am force-stop com.ndt.collection");
        }

        public static string touch_screen_from_xy(int x, int y)
        {
            return execute(@"/c adb shell input tap " + x + " " + y);
        }

        public static string pull_out_data(string data_path, string des_path)
        {
            return execute(@"/c adb pull " + data_path + " " + des_path);
        }

        public static string clear_all_data()
        {
            return execute(@"/c adb shell rm /sdcard/NDT/Rawdata/*");
        }

        public static string reboot()
        {
            return execute(@"/c adb reboot");
        }

        public static string shutdown()
        {
            return execute(@"/c adb reboot -p");
        }
    }
}