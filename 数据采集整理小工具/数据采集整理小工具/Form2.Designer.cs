using System.ComponentModel;
using CCWin.SkinControl;

namespace 数据采集整理小工具
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.skrtbNo = new CCWin.SkinControl.SkinChatRichTextBox();
            this.SuspendLayout();
            // 
            // skrtbNo
            // 
            this.skrtbNo.Location = new System.Drawing.Point(77, 43);
            this.skrtbNo.Multiline = false;
            this.skrtbNo.Name = "skrtbNo";
            this.skrtbNo.SelectControl = null;
            this.skrtbNo.SelectControlIndex = 0;
            this.skrtbNo.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skrtbNo.Size = new System.Drawing.Size(251, 31);
            this.skrtbNo.TabIndex = 0;
            this.skrtbNo.Text = "";
            this.skrtbNo.WordWrap = false;
            this.skrtbNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skrtbNo_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.skrtbNo);
            this.MaximumSize = new System.Drawing.Size(400, 100);
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入编号, 按回车(Enter)退出:";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SkinChatRichTextBox skrtbNo;
    }
}