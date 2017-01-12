using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDFBase.Core.Views;
using System.Runtime.InteropServices;

namespace PDFBase
{
    public partial class FormMain : BaseStyleForm, IContainder
    {
        IView view;
        public FormMain():base()
        {
            InitializeComponent();
            splitContainer1.Panel1.MouseDown += new MouseEventHandler(Control_MouseDown);
        }

        

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.LightGray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tv_list.ExpandAll();
            SwitchView(new ucFound());
            
        }
        

        public void SwitchView(IView view)
        {
            splitContainer2.Panel2.Controls.Add((UserControl)view);
            ((UserControl)view).Dock = DockStyle.Fill;
            ((UserControl)view).BringToFront();
        }

        private void tv_list_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (tv_list.SelectedNode.Text)
            {
                case "发现文献":
                    view = new ucFound();
                    break;
                case "朋友":
                    view = new ucSocialContact();
                    break;
                case "本地文献":
                    view = new ucLocalDocs();
                    break;
                case "下载管理":
                    break;
                case "我的心愿":
                    break;
                case "我的分享":
                    break;
                case "发现文献1":
                    break;
            }
            SwitchView(view);
        }
    }
}
