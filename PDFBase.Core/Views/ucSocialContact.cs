using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFBase.Core.Views
{
    public partial class ucSocialContact : UserControl,IView
    {
        public ucSocialContact()
        {
            InitializeComponent();
        }

        private void ucSocialContact_Load(object sender, EventArgs e)
        {
            ucPersional uc = new ucPersional();
            uc.Dock = DockStyle.Fill;
            pl_personal.Controls.Add(uc);
        }
    }
}
