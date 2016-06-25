using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Book7._8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GetNum(string str)
        {
            //int i = 0;
            //foreach (char ch in str)
            //{
            //    if (ch >= 0x4e00 && ch <= 0x9fa5)
            //    {
            //        i++;
            //    }
            //}

            //return i;

            //正则表达式
            ArrayList arrList = new ArrayList();
            CharEnumerator CEnumerator = str.GetEnumerator();
            Regex regex = new Regex("^[\u4E00-\u9FA5]$");
            while (CEnumerator.MoveNext())
            {
                if (regex.IsMatch(CEnumerator.Current.ToString(), 0))
                {
                    arrList.Add(CEnumerator.Current.ToString());
                }
            }

            return arrList.Count;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string str = tbStr.Text;
            tbNum.Text = GetNum(str).ToString();
        }
    }
}
