using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PDFBase.Core.Views
{
    public partial class frmSendMessage : BaseStyleForm
    {
       
        public frmSendMessage():base()
        {
            InitializeComponent();
            panel1.MouseDown += new MouseEventHandler(Control_MouseDown);
        }

        void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        
        private void label2_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.LightGray;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
