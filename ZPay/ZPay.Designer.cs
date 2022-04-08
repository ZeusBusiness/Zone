namespace ZPay
{
    partial class ZPay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZPay));
            this.parrentPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.zeusLink = new System.Windows.Forms.LinkLabel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.adPicture = new System.Windows.Forms.PictureBox();
            this.actionControl = new System.Windows.Forms.TabControl();
            this.ResponseTab = new System.Windows.Forms.TabPage();
            this.refreshPic = new System.Windows.Forms.PictureBox();
            this.responseStatus = new System.Windows.Forms.Label();
            this.transactionID = new System.Windows.Forms.Label();
            this.logPicture = new System.Windows.Forms.PictureBox();
            this.responseMessage = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.frndLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.copyright = new System.Windows.Forms.Label();
            this.intText = new System.Windows.Forms.Label();
            this.integrationPicture = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.zPayNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.parrentPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adPicture)).BeginInit();
            this.actionControl.SuspendLayout();
            this.ResponseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicture)).BeginInit();
            this.aboutTab.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integrationPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // parrentPanel
            // 
            this.parrentPanel.Controls.Add(this.mainPanel);
            this.parrentPanel.Controls.Add(this.sidePanel);
            this.parrentPanel.Location = new System.Drawing.Point(0, 0);
            this.parrentPanel.Name = "parrentPanel";
            this.parrentPanel.Size = new System.Drawing.Size(450, 300);
            this.parrentPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.zeusLink);
            this.mainPanel.Controls.Add(this.closeBtn);
            this.mainPanel.Controls.Add(this.adPicture);
            this.mainPanel.Controls.Add(this.actionControl);
            this.mainPanel.Location = new System.Drawing.Point(150, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(300, 300);
            this.mainPanel.TabIndex = 1;
            // 
            // zeusLink
            // 
            this.zeusLink.AutoSize = true;
            this.zeusLink.Location = new System.Drawing.Point(124, 280);
            this.zeusLink.Name = "zeusLink";
            this.zeusLink.Size = new System.Drawing.Size(118, 15);
            this.zeusLink.TabIndex = 3;
            this.zeusLink.TabStop = true;
            this.zeusLink.Text = "www.zeusbusiness.in";
            this.zeusLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zeusLink_LinkClicked);
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(269, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // adPicture
            // 
            this.adPicture.Image = ((System.Drawing.Image)(resources.GetObject("adPicture.Image")));
            this.adPicture.Location = new System.Drawing.Point(1, 192);
            this.adPicture.Name = "adPicture";
            this.adPicture.Size = new System.Drawing.Size(300, 106);
            this.adPicture.TabIndex = 1;
            this.adPicture.TabStop = false;
            // 
            // actionControl
            // 
            this.actionControl.Controls.Add(this.ResponseTab);
            this.actionControl.Controls.Add(this.aboutTab);
            this.actionControl.Location = new System.Drawing.Point(0, 13);
            this.actionControl.Name = "actionControl";
            this.actionControl.SelectedIndex = 0;
            this.actionControl.Size = new System.Drawing.Size(300, 180);
            this.actionControl.TabIndex = 0;
            // 
            // ResponseTab
            // 
            this.ResponseTab.Controls.Add(this.refreshPic);
            this.ResponseTab.Controls.Add(this.responseStatus);
            this.ResponseTab.Controls.Add(this.transactionID);
            this.ResponseTab.Controls.Add(this.logPicture);
            this.ResponseTab.Controls.Add(this.responseMessage);
            this.ResponseTab.Controls.Add(this.datetime);
            this.ResponseTab.Location = new System.Drawing.Point(4, 24);
            this.ResponseTab.Name = "ResponseTab";
            this.ResponseTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResponseTab.Size = new System.Drawing.Size(292, 152);
            this.ResponseTab.TabIndex = 1;
            this.ResponseTab.Text = "Response";
            this.ResponseTab.UseVisualStyleBackColor = true;
            // 
            // refreshPic
            // 
            this.refreshPic.Image = global::ZPay.Properties.Resources.autorenew;
            this.refreshPic.Location = new System.Drawing.Point(103, 5);
            this.refreshPic.Name = "refreshPic";
            this.refreshPic.Size = new System.Drawing.Size(32, 32);
            this.refreshPic.TabIndex = 7;
            this.refreshPic.TabStop = false;
            this.refreshPic.Click += new System.EventHandler(this.refreshPic_Click);
            // 
            // responseStatus
            // 
            this.responseStatus.AutoSize = true;
            this.responseStatus.Location = new System.Drawing.Point(13, 69);
            this.responseStatus.Name = "responseStatus";
            this.responseStatus.Size = new System.Drawing.Size(57, 15);
            this.responseStatus.TabIndex = 6;
            this.responseStatus.Text = "Response";
            // 
            // transactionID
            // 
            this.transactionID.AutoSize = true;
            this.transactionID.Location = new System.Drawing.Point(12, 112);
            this.transactionID.Name = "transactionID";
            this.transactionID.Size = new System.Drawing.Size(78, 15);
            this.transactionID.TabIndex = 4;
            this.transactionID.Text = "TransactionID";
            // 
            // logPicture
            // 
            this.logPicture.Image = ((System.Drawing.Image)(resources.GetObject("logPicture.Image")));
            this.logPicture.Location = new System.Drawing.Point(155, 5);
            this.logPicture.Name = "logPicture";
            this.logPicture.Size = new System.Drawing.Size(32, 32);
            this.logPicture.TabIndex = 0;
            this.logPicture.TabStop = false;
            this.logPicture.Tag = "Clear Log";
            this.logPicture.Click += new System.EventHandler(this.logPicture_Click);
            // 
            // responseMessage
            // 
            this.responseMessage.AutoSize = true;
            this.responseMessage.Location = new System.Drawing.Point(13, 90);
            this.responseMessage.Name = "responseMessage";
            this.responseMessage.Size = new System.Drawing.Size(53, 15);
            this.responseMessage.TabIndex = 2;
            this.responseMessage.Text = "Message";
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Location = new System.Drawing.Point(13, 46);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(57, 15);
            this.datetime.TabIndex = 1;
            this.datetime.Text = "DateTime";
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.frndLabel);
            this.aboutTab.Controls.Add(this.aboutLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 24);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(292, 152);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About Us";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // frndLabel
            // 
            this.frndLabel.AutoSize = true;
            this.frndLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.frndLabel.Location = new System.Drawing.Point(4, 19);
            this.frndLabel.Name = "frndLabel";
            this.frndLabel.Size = new System.Drawing.Size(103, 21);
            this.frndLabel.TabIndex = 1;
            this.frndLabel.Text = "Hello Friend,";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.aboutLabel.Location = new System.Drawing.Point(5, 41);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(272, 102);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = resources.GetString("aboutLabel.Text");
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(52)))), ((int)(((byte)(99)))));
            this.sidePanel.Controls.Add(this.copyright);
            this.sidePanel.Controls.Add(this.intText);
            this.sidePanel.Controls.Add(this.integrationPicture);
            this.sidePanel.Controls.Add(this.logo);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(150, 300);
            this.sidePanel.TabIndex = 0;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyright.ForeColor = System.Drawing.Color.White;
            this.copyright.Location = new System.Drawing.Point(27, 260);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(98, 13);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Copyright © 2022";
            // 
            // intText
            // 
            this.intText.AutoSize = true;
            this.intText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.intText.ForeColor = System.Drawing.Color.White;
            this.intText.Location = new System.Drawing.Point(26, 180);
            this.intText.Name = "intText";
            this.intText.Size = new System.Drawing.Size(102, 17);
            this.intText.TabIndex = 2;
            this.intText.Text = "Integrated with";
            // 
            // integrationPicture
            // 
            this.integrationPicture.Image = ((System.Drawing.Image)(resources.GetObject("integrationPicture.Image")));
            this.integrationPicture.Location = new System.Drawing.Point(13, 200);
            this.integrationPicture.Name = "integrationPicture";
            this.integrationPicture.Size = new System.Drawing.Size(125, 50);
            this.integrationPicture.TabIndex = 1;
            this.integrationPicture.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(1, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(147, 162);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // zPayNotify
            // 
            this.zPayNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.zPayNotify.BalloonTipText = "ZPay";
            this.zPayNotify.BalloonTipTitle = "ZPay";
            this.zPayNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("zPayNotify.Icon")));
            this.zPayNotify.Tag = "ZPay";
            this.zPayNotify.Text = "ZPay";
            this.zPayNotify.Visible = true;
            this.zPayNotify.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // ZPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.parrentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZPay";
            this.Load += new System.EventHandler(this.ZPay_Load);
            this.parrentPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adPicture)).EndInit();
            this.actionControl.ResumeLayout(false);
            this.ResponseTab.ResumeLayout(false);
            this.ResponseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPicture)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integrationPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parrentPanel;
        private Panel sidePanel;
        private Panel mainPanel;
        private PictureBox logo;
        private TabControl actionControl;
        private TabPage ResponseTab;
        private PictureBox adPicture;
        private Button closeBtn;
        private Label intText;
        private PictureBox integrationPicture;
        private LinkLabel zeusLink;
        private TabPage aboutTab;
        private Label frndLabel;
        private Label aboutLabel;
        private PictureBox logPicture;
        private Label datetime;
        private Label responseMessage;
        private Label transactionID;
        private Label responseStatus;
        private PictureBox refreshPic;
        private Label copyright;
        private NotifyIcon zPayNotify;
    }
}