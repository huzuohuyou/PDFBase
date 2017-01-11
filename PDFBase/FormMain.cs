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
    public partial class FormMain : Form, IContainder
    {
        IView view;
        public FormMain()
        {
            InitializeComponent();
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
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
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
