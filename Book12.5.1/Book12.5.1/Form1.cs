using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book12._5._1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        public Form1()
        {
            InitializeComponent();

            this.timer = new Timer();
            this.timer.Enabled = true;
            this.timer.Interval = 500;

            this.timer.Tick += new System.EventHandler(this.timer_Tick);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }
    }
}
