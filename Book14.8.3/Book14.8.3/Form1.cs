using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book14._8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button1.Text = "开始";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "停止";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16(2000 / trackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                progressBar1.PerformStep();
            }

            int intPercent;
            intPercent = 100 * (this.progressBar1.Value - this.progressBar1.Minimum)
                            / (this.progressBar1.Maximum - this.progressBar1.Minimum);
            label2.Text = Convert.ToInt16(intPercent).ToString() + "%";
        }
    }
}
