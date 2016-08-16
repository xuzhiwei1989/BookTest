namespace Book14._8._2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tvDirList = new System.Windows.Forms.TreeView();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tvDirList
            // 
            this.tvDirList.Location = new System.Drawing.Point(13, 13);
            this.tvDirList.Name = "tvDirList";
            this.tvDirList.Size = new System.Drawing.Size(139, 237);
            this.tvDirList.TabIndex = 0;
            this.tvDirList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDirList_AfterSelect);
            // 
            // lvFileList
            // 
            this.lvFileList.Location = new System.Drawing.Point(158, 13);
            this.lvFileList.MultiSelect = false;
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(288, 237);
            this.lvFileList.TabIndex = 0;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.List;
            this.lvFileList.DoubleClick += new System.EventHandler(this.lvFileList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 262);
            this.Controls.Add(this.lvFileList);
            this.Controls.Add(this.tvDirList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirList;
        private System.Windows.Forms.ListView lvFileList;
    }
}

