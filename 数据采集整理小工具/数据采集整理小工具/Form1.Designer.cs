using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CCWin.SkinClass;
using CCWin.SkinControl;

namespace 数据采集整理小工具
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skStartCapture = new CCWin.SkinControl.SkinButton();
            this.skbtnReboot = new CCWin.SkinControl.SkinButton();
            this.skbtnAnalyse = new CCWin.SkinControl.SkinButton();
            this.skbtnClearData = new CCWin.SkinControl.SkinButton();
            this.skbtnStopTest = new CCWin.SkinControl.SkinButton();
            this.skbtnStartTest = new CCWin.SkinControl.SkinButton();
            this.skbtnOpenApk = new CCWin.SkinControl.SkinButton();
            this.skbtnInstallApk = new CCWin.SkinControl.SkinButton();
            this.skbtnAuthorize = new CCWin.SkinControl.SkinButton();
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.skrtbLog = new CCWin.SkinControl.SkinChatRichTextBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skpbScreenShot = new CCWin.SkinControl.SkinPictureBox();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skbtnShutDown = new CCWin.SkinControl.SkinButton();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).BeginInit();
            this.skinSplitContainer2.Panel1.SuspendLayout();
            this.skinSplitContainer2.Panel2.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skpbScreenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(1016, 736);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.PaleGreen;
            this.skinTabPage1.Controls.Add(this.skinSplitContainer1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(1016, 700);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "main tools";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinGroupBox2);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinSplitContainer2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1016, 700);
            this.skinSplitContainer1.SplitterDistance = 266;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.skStartCapture);
            this.skinGroupBox2.Controls.Add(this.skbtnShutDown);
            this.skinGroupBox2.Controls.Add(this.skbtnReboot);
            this.skinGroupBox2.Controls.Add(this.skbtnAnalyse);
            this.skinGroupBox2.Controls.Add(this.skbtnClearData);
            this.skinGroupBox2.Controls.Add(this.skbtnStopTest);
            this.skinGroupBox2.Controls.Add(this.skbtnStartTest);
            this.skinGroupBox2.Controls.Add(this.skbtnOpenApk);
            this.skinGroupBox2.Controls.Add(this.skbtnInstallApk);
            this.skinGroupBox2.Controls.Add(this.skbtnAuthorize);
            this.skinGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(266, 700);
            this.skinGroupBox2.TabIndex = 0;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "ToolBox";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.Gold;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skStartCapture
            // 
            this.skStartCapture.BackColor = System.Drawing.Color.Transparent;
            this.skStartCapture.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skStartCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skStartCapture.DownBack = null;
            this.skStartCapture.ForeColor = System.Drawing.Color.DarkRed;
            this.skStartCapture.Location = new System.Drawing.Point(3, 615);
            this.skStartCapture.MouseBack = null;
            this.skStartCapture.Name = "skStartCapture";
            this.skStartCapture.NormlBack = null;
            this.skStartCapture.Size = new System.Drawing.Size(260, 82);
            this.skStartCapture.TabIndex = 4;
            this.skStartCapture.Text = "启动/停止系统截图";
            this.skStartCapture.UseVisualStyleBackColor = false;
            this.skStartCapture.Click += new System.EventHandler(this.skStartCapture_Click);
            // 
            // skbtnReboot
            // 
            this.skbtnReboot.BackColor = System.Drawing.Color.Transparent;
            this.skbtnReboot.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnReboot.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnReboot.DownBack = null;
            this.skbtnReboot.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnReboot.Location = new System.Drawing.Point(3, 483);
            this.skbtnReboot.MouseBack = null;
            this.skbtnReboot.Name = "skbtnReboot";
            this.skbtnReboot.NormlBack = null;
            this.skbtnReboot.Size = new System.Drawing.Size(260, 66);
            this.skbtnReboot.TabIndex = 6;
            this.skbtnReboot.Text = "Step 8. 重启";
            this.skbtnReboot.UseVisualStyleBackColor = false;
            this.skbtnReboot.Click += new System.EventHandler(this.skbtnReboot_Click);
            // 
            // skbtnAnalyse
            // 
            this.skbtnAnalyse.BackColor = System.Drawing.Color.Transparent;
            this.skbtnAnalyse.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnAnalyse.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnAnalyse.DownBack = null;
            this.skbtnAnalyse.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnAnalyse.Location = new System.Drawing.Point(3, 417);
            this.skbtnAnalyse.MouseBack = null;
            this.skbtnAnalyse.Name = "skbtnAnalyse";
            this.skbtnAnalyse.NormlBack = null;
            this.skbtnAnalyse.Size = new System.Drawing.Size(260, 66);
            this.skbtnAnalyse.TabIndex = 5;
            this.skbtnAnalyse.Text = "Step 7. 分析数据";
            this.skbtnAnalyse.UseVisualStyleBackColor = false;
            this.skbtnAnalyse.Click += new System.EventHandler(this.skbtnAnalyse_Click);
            // 
            // skbtnClearData
            // 
            this.skbtnClearData.BackColor = System.Drawing.Color.Transparent;
            this.skbtnClearData.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnClearData.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnClearData.DownBack = null;
            this.skbtnClearData.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnClearData.Location = new System.Drawing.Point(3, 351);
            this.skbtnClearData.MouseBack = null;
            this.skbtnClearData.Name = "skbtnClearData";
            this.skbtnClearData.NormlBack = null;
            this.skbtnClearData.Size = new System.Drawing.Size(260, 66);
            this.skbtnClearData.TabIndex = 3;
            this.skbtnClearData.Text = "Step 6. 清除手机中的数据";
            this.skbtnClearData.UseVisualStyleBackColor = false;
            this.skbtnClearData.Click += new System.EventHandler(this.skbtnClearData_Click);
            // 
            // skbtnStopTest
            // 
            this.skbtnStopTest.BackColor = System.Drawing.Color.Transparent;
            this.skbtnStopTest.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnStopTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnStopTest.DownBack = null;
            this.skbtnStopTest.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnStopTest.Location = new System.Drawing.Point(3, 285);
            this.skbtnStopTest.MouseBack = null;
            this.skbtnStopTest.Name = "skbtnStopTest";
            this.skbtnStopTest.NormlBack = null;
            this.skbtnStopTest.Size = new System.Drawing.Size(260, 66);
            this.skbtnStopTest.TabIndex = 3;
            this.skbtnStopTest.Text = "Step 5. 结束测试";
            this.skbtnStopTest.UseVisualStyleBackColor = false;
            this.skbtnStopTest.Click += new System.EventHandler(this.skbtnStopTest_Click);
            // 
            // skbtnStartTest
            // 
            this.skbtnStartTest.BackColor = System.Drawing.Color.Transparent;
            this.skbtnStartTest.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnStartTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnStartTest.DownBack = null;
            this.skbtnStartTest.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnStartTest.Location = new System.Drawing.Point(3, 219);
            this.skbtnStartTest.MouseBack = null;
            this.skbtnStartTest.Name = "skbtnStartTest";
            this.skbtnStartTest.NormlBack = null;
            this.skbtnStartTest.Size = new System.Drawing.Size(260, 66);
            this.skbtnStartTest.TabIndex = 3;
            this.skbtnStartTest.Text = "Step 4. 开始测试";
            this.skbtnStartTest.UseVisualStyleBackColor = false;
            this.skbtnStartTest.Click += new System.EventHandler(this.skbtnStartTest_Click);
            // 
            // skbtnOpenApk
            // 
            this.skbtnOpenApk.BackColor = System.Drawing.Color.Transparent;
            this.skbtnOpenApk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnOpenApk.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnOpenApk.DownBack = null;
            this.skbtnOpenApk.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnOpenApk.Location = new System.Drawing.Point(3, 153);
            this.skbtnOpenApk.MouseBack = null;
            this.skbtnOpenApk.Name = "skbtnOpenApk";
            this.skbtnOpenApk.NormlBack = null;
            this.skbtnOpenApk.Size = new System.Drawing.Size(260, 66);
            this.skbtnOpenApk.TabIndex = 2;
            this.skbtnOpenApk.Text = "Step 3. 打开apk";
            this.skbtnOpenApk.UseVisualStyleBackColor = false;
            this.skbtnOpenApk.Click += new System.EventHandler(this.skbtnOpenApk_Click);
            // 
            // skbtnInstallApk
            // 
            this.skbtnInstallApk.BackColor = System.Drawing.Color.Transparent;
            this.skbtnInstallApk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnInstallApk.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnInstallApk.DownBack = null;
            this.skbtnInstallApk.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnInstallApk.Location = new System.Drawing.Point(3, 87);
            this.skbtnInstallApk.MouseBack = null;
            this.skbtnInstallApk.Name = "skbtnInstallApk";
            this.skbtnInstallApk.NormlBack = null;
            this.skbtnInstallApk.Size = new System.Drawing.Size(260, 66);
            this.skbtnInstallApk.TabIndex = 1;
            this.skbtnInstallApk.Text = "Step 2. 安装apk";
            this.skbtnInstallApk.UseVisualStyleBackColor = false;
            this.skbtnInstallApk.Click += new System.EventHandler(this.skbtnInstallApk_Click);
            // 
            // skbtnAuthorize
            // 
            this.skbtnAuthorize.BackColor = System.Drawing.Color.Transparent;
            this.skbtnAuthorize.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnAuthorize.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnAuthorize.DownBack = null;
            this.skbtnAuthorize.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnAuthorize.Location = new System.Drawing.Point(3, 21);
            this.skbtnAuthorize.MouseBack = null;
            this.skbtnAuthorize.Name = "skbtnAuthorize";
            this.skbtnAuthorize.NormlBack = null;
            this.skbtnAuthorize.Size = new System.Drawing.Size(260, 66);
            this.skbtnAuthorize.TabIndex = 0;
            this.skbtnAuthorize.Text = "Step 1. 重启后授权";
            this.skbtnAuthorize.UseVisualStyleBackColor = false;
            this.skbtnAuthorize.Click += new System.EventHandler(this.skbtnAuthorize_Click);
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            // 
            // skinSplitContainer2.Panel1
            // 
            this.skinSplitContainer2.Panel1.Controls.Add(this.skinGroupBox3);
            // 
            // skinSplitContainer2.Panel2
            // 
            this.skinSplitContainer2.Panel2.Controls.Add(this.skinGroupBox1);
            this.skinSplitContainer2.Size = new System.Drawing.Size(746, 700);
            this.skinSplitContainer2.SplitterDistance = 377;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox3.Controls.Add(this.skrtbLog);
            this.skinGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(377, 700);
            this.skinGroupBox3.TabIndex = 0;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "Log";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.LightCoral;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skrtbLog
            // 
            this.skrtbLog.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.skrtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skrtbLog.Location = new System.Drawing.Point(3, 21);
            this.skrtbLog.Name = "skrtbLog";
            this.skrtbLog.SelectControl = null;
            this.skrtbLog.SelectControlIndex = 0;
            this.skrtbLog.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skrtbLog.Size = new System.Drawing.Size(371, 676);
            this.skrtbLog.TabIndex = 1;
            this.skrtbLog.Text = "";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.skpbScreenShot);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(365, 700);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "ScreenShot";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.Lime;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skpbScreenShot
            // 
            this.skpbScreenShot.BackColor = System.Drawing.Color.MediumTurquoise;
            this.skpbScreenShot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skpbScreenShot.Location = new System.Drawing.Point(3, 21);
            this.skpbScreenShot.Name = "skpbScreenShot";
            this.skpbScreenShot.Size = new System.Drawing.Size(359, 676);
            this.skpbScreenShot.TabIndex = 0;
            this.skpbScreenShot.TabStop = false;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(1016, 700);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "tbc...";
            // 
            // skbtnShutDown
            // 
            this.skbtnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.skbtnShutDown.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnShutDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.skbtnShutDown.DownBack = null;
            this.skbtnShutDown.ForeColor = System.Drawing.Color.DarkRed;
            this.skbtnShutDown.Location = new System.Drawing.Point(3, 549);
            this.skbtnShutDown.MouseBack = null;
            this.skbtnShutDown.Name = "skbtnShutDown";
            this.skbtnShutDown.NormlBack = null;
            this.skbtnShutDown.Size = new System.Drawing.Size(260, 66);
            this.skbtnShutDown.TabIndex = 7;
            this.skbtnShutDown.Text = "Step 9. 关闭手机";
            this.skbtnShutDown.UseVisualStyleBackColor = false;
            this.skbtnShutDown.Click += new System.EventHandler(this.skbtnShutDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.skinTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据提取及处理小程序, by 王也, y.wang@newdegreetech.com, v0.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.ResumeLayout(false);
            this.skinSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).EndInit();
            this.skinSplitContainer2.ResumeLayout(false);
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skpbScreenShot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkinTabControl skinTabControl1;
        private SkinTabPage skinTabPage1;
        private SkinTabPage skinTabPage2;
        private SkinSplitContainer skinSplitContainer1;
        private SkinSplitContainer skinSplitContainer2;
        private SkinPictureBox skpbScreenShot;
        private SkinGroupBox skinGroupBox1;
        private SkinGroupBox skinGroupBox2;
        private SkinGroupBox skinGroupBox3;
        private SkinButton skbtnAuthorize;
        private SkinButton skbtnInstallApk;
        private SkinButton skbtnOpenApk;
        private SkinButton skbtnStartTest;
        private SkinButton skbtnStopTest;
        private SkinButton skbtnClearData;
        private SkinButton skStartCapture;
        private SkinChatRichTextBox skrtbLog;
        private SkinButton skbtnAnalyse;
        private SkinButton skbtnReboot;
        private SkinButton skbtnShutDown;
    }
}

