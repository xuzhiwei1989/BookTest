using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Book14._8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode CmpNode = new TreeNode("我的电脑");
            tvDirList.Nodes.Add(CmpNode);
            ListViewShow(CmpNode);
        }

        private void ListViewShow(TreeNode treeNode)
        {
            lvFileList.Clear();

            try
            {
                if (treeNode.Parent == null)
                {
                    foreach (string drvName in Directory.GetLogicalDrives())
                    {
                        ListViewItem lvItem = new ListViewItem(drvName);
                        lvFileList.Items.Add(lvItem);
                    }
                }
                else
                {
                    foreach (string dirName in Directory.GetDirectories((string)treeNode.Tag))
                    {
                        ListViewItem lvItem = new ListViewItem(dirName);
                        lvFileList.Items.Add(lvItem);
                    }

                    foreach (string fileName in Directory.GetFiles((string)treeNode.Tag))
                    {
                        ListViewItem lvItem = new ListViewItem(fileName);
                        lvFileList.Items.Add(fileName);
                    }
                }
            }
            catch { }
        }

        private void ListViewShow(string dirFileName)
        {
            lvFileList.Clear();

            try
            {
                foreach (string dirName in Directory.GetDirectories(dirFileName))
                {
                    ListViewItem lvItem = new ListViewItem(dirName);
                    lvFileList.Items.Add(lvItem);
                }
                foreach (string fileName in Directory.GetFiles(dirFileName))
                {
                    ListViewItem lvItem = new ListViewItem(fileName);
                    lvFileList.Items.Add(lvItem);
                }
            }
            catch { }
        }

        private void TreeViewShow(TreeNode treeNode)
        {
            try
            {
                if (treeNode.Nodes.Count == 0)
                {
                    if (treeNode.Parent == null)
                    {
                        foreach (string drvName in Directory.GetLogicalDrives())
                        {
                            TreeNode tNode = new TreeNode(drvName);
                            tNode.Tag = drvName;
                            treeNode.Nodes.Add(tNode);
                        }
                    }
                    else
                    {
                        foreach (string dirName in Directory.GetDirectories((string)treeNode.Tag))
                        {
                            TreeNode tNode = new TreeNode(dirName);
                            tNode.Tag = dirName;
                            treeNode.Nodes.Add(tNode);
                        }
                    }
                }
            }
            catch { }
        }

        private void tvDirList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ListViewShow(e.Node);
            TreeViewShow(e.Node);
        }

        private void lvFileList_DoubleClick(object sender, EventArgs e)
        {
            foreach (int listIndex in lvFileList.SelectedIndices)
            {
                ListViewShow(lvFileList.Items[listIndex].Text);
            }
        }
    }
}
