using System;
using System.Windows.Forms;
using CCWin;

namespace 数据采集整理小工具
{
    public partial class Form2 : CCSkinMain
    {
        public string Str { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void skrtbNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Str = skrtbNo.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
