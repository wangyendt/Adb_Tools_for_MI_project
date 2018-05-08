using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CCWin;

namespace 数据采集整理小工具
{
    public partial class Form1 : CCSkinMain
    {
        private Thread _thrdShowScreenShot;
        public string StrNo { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            skpbScreenShot.BackgroundImageLayout = ImageLayout.Stretch;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void skbtnInstallApk_Click(object sender, EventArgs e)
        {
            skrtbLog.ShowLog(AdbUtils.install_apk(@"FingerPrintDataCollection-release.apk"));
            skrtbLog.ShowLog("安装apk成功!");
        }

        private void skStartCapture_Click(object sender, EventArgs e)
        {
            if (_thrdShowScreenShot != null)
            {
                if (_thrdShowScreenShot.IsAlive)
                {
                    _thrdShowScreenShot.Abort();
                }
                _thrdShowScreenShot = null;
            }
            else
            {
                _thrdShowScreenShot = new Thread(ShowScreenShot) { IsBackground = true };
                _thrdShowScreenShot.Start();
            }
        }

        private void ShowScreenShot()
        {
            while (true)
            {
                AdbUtils.screen_shot();
                Stream s = File.Open("screenshot.png", FileMode.Open);
                skpbScreenShot.BackgroundImage = Image.FromStream(s);
                s.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_thrdShowScreenShot != null)
            {
                _thrdShowScreenShot.Abort();
                _thrdShowScreenShot = null;
            }
        }

        private void skbtnAuthorize_Click(object sender, EventArgs e)
        {
            AdbUtils.authorized().ToList().ForEach(x => skrtbLog.ShowLog(x));
            skrtbLog.ShowLog("授权成功!");
        }

        private void skbtnOpenApk_Click(object sender, EventArgs e)
        {
            AdbUtils.open_apk();
            Thread.Sleep(1000);
            AdbUtils.authorize_apk();
            skrtbLog.ShowLog("打开apk成功!");
        }

        private void skbtnStartTest_Click(object sender, EventArgs e)
        {
            AdbUtils.touch_screen_from_xy(540, 900);
            skrtbLog.ShowLog("开始测试");
        }

        private void skbtnStopTest_Click(object sender, EventArgs e)
        {
            AdbUtils.touch_screen_from_xy(540, 900);
            AdbUtils.close_apk();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            string strNo = "DefaultCode";
            if (frm2.DialogResult == DialogResult.OK)
            {
                strNo = frm2.Str;
            }
            StrNo = strNo;
            AdbUtils.pull_out_data(@"/sdcard/NDT/Rawdata/", StrNo);
            skrtbLog.ShowLog("结束测试, 文件已导出!");
        }

        private void skbtnClearData_Click(object sender, EventArgs e)
        {
            AdbUtils.clear_all_data();
            skrtbLog.ShowLog("清除数据成功!");
        }

        private void skbtnReboot_Click(object sender, EventArgs e)
        {
            AdbUtils.reboot();
            skrtbLog.ShowLog("手机已重启");
        }

        private void skbtnAnalyse_Click(object sender, EventArgs e)
        {
            CmdUtils.Analyze(StrNo);
            //            skrtbLog.ShowLog(PythonUtils.show_data_figure(StrNo));
            skrtbLog.ShowLog("分析已完成");
        }

        private void skbtnShutDown_Click(object sender, EventArgs e)
        {
            AdbUtils.shutdown();
            skrtbLog.ShowLog("手机已关机");
        }
    }
}
