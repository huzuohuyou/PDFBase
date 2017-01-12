using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDFBase.Core.Controller;

namespace PDFBase.Core.Views
{
    public partial class ucSocialContact : UserControl,IView
    {
        SocialContactController controller;
        public ucSocialContact()
        {
            InitializeComponent();
            controller = new SocialContactController();
        }

        private void ucSocialContact_Load(object sender, EventArgs e)
        {
            ucPersional uc = new ucPersional();
            uc.Dock = DockStyle.Fill;
            pl_personal.Controls.Add(uc);
            SetMessagesView();
            this.MouseWheel += formsample_mousewheel;
        }

        public void SetMessagesView()
        {
            for (int i = 0; i < 10; i++)
            {
                ucSocialItem item = new ucSocialItem();
                item.Location = new Point(5,i*298);
                pl_message.Controls.Add(item);
            }
        }

        void formsample_mousewheel(object sender, MouseEventArgs e)
        {
            //获取光标位置
            Point mousepoint = new Point(e.X, e.Y);
            //换算成相对本窗体的位置
            mousepoint.Offset(this.Location.X, this.Location.Y);
            //判断是否在panel内
            if (pl_message.RectangleToScreen(pl_message.DisplayRectangle).Contains(mousepoint))
            {
                //滚动
                pl_message.AutoScrollPosition = new Point(0, pl_message.VerticalScroll.Value - e.Delta);
            }
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            frmSendMessage frm = new frmSendMessage();
            frm.ShowDialog();
        }
    }
}
