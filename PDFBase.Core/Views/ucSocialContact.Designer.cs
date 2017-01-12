namespace PDFBase.Core.Views
{
    partial class ucSocialContact
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.pl_message = new System.Windows.Forms.Panel();
            this.pl_personal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.pl_message);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pl_personal);
            this.splitContainer1.Size = new System.Drawing.Size(805, 577);
            this.splitContainer1.SplitterDistance = 598;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_sendMessage);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 49);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "动态";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sendMessage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendMessage.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sendMessage.Location = new System.Drawing.Point(503, 13);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(75, 29);
            this.btn_sendMessage.TabIndex = 4;
            this.btn_sendMessage.Text = "发动态";
            this.btn_sendMessage.UseVisualStyleBackColor = false;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // pl_message
            // 
            this.pl_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_message.AutoScroll = true;
            this.pl_message.Location = new System.Drawing.Point(16, 50);
            this.pl_message.Name = "pl_message";
            this.pl_message.Size = new System.Drawing.Size(583, 525);
            this.pl_message.TabIndex = 3;
            // 
            // pl_personal
            // 
            this.pl_personal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_personal.Location = new System.Drawing.Point(0, 0);
            this.pl_personal.Name = "pl_personal";
            this.pl_personal.Size = new System.Drawing.Size(206, 577);
            this.pl_personal.TabIndex = 0;
            // 
            // ucSocialContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucSocialContact";
            this.Size = new System.Drawing.Size(805, 577);
            this.Load += new System.EventHandler(this.ucSocialContact_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pl_message;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_personal;
    }
}
