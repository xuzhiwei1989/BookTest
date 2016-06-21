using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book5._5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text.Trim();

            string[] filePathArr = filePath.Split(new char[] { '\\' });
            //tbExtension.Text = filePathArr[filePathArr.Length - 1];
            string path = null;
            for (int i = 0; i < filePathArr.Length - 2;i++ )
            {
                if (i > 0)
                {
                    path += "\\";
                }
                path += filePathArr[i];
            }

            string fileName = filePathArr[filePathArr.Length - 1];
            string[] fileNameArr = fileName.Split(new char[] { '.' });
            string name = null;
            int j = 0;
            do
            {
                if (j > 0)
                {
                    name += ".";
                }
                name += fileNameArr[j++];
            } while (j < fileNameArr.Length - 1);

            //tbFilePath.Text = path;
            tbPath.Text = path;
            tbFileName.Text = name;
            tbExtension.Text = "." + fileNameArr[fileNameArr.Length - 1];

        }
    }
}
