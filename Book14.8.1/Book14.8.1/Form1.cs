using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book14._8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string bookName = txtBookName.Text;
            if (bookName == null || bookName == "")
            {
                MessageBox.Show("书名目录不能为空");
                return;
            }

            foreach (ListViewItem item in lvBookList.Items)
            {
                if (item.Text == bookName)
                {
                    MessageBox.Show("书名目录已存在");
                    return;
                }
            }

            lvBookList.Items.Add(bookName);
        }
    }
}
