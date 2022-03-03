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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZPay));
            this.parrentPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.adPicture = new System.Windows.Forms.PictureBox();
            this.actionControl = new System.Windows.Forms.TabControl();
            this.RequestTab = new System.Windows.Forms.TabPage();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.ResponseTab = new System.Windows.Forms.TabPage();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.intText = new System.Windows.Forms.Label();
            this.integrationPicture = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.frndLabel = new System.Windows.Forms.Label();
            this.zeusLink = new System.Windows.Forms.LinkLabel();
            this.parrentPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adPicture)).BeginInit();
            this.actionControl.SuspendLayout();
            this.RequestTab.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integrationPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // parrentPanel
            // 
            this.parrentPanel.Controls.Add(this.mainPanel);
            this.parrentPanel.Controls.Add(this.sidePanel);
            this.parrentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrentPanel.Location = new System.Drawing.Point(0, 0);
            this.parrentPanel.Name = "parrentPanel";
            this.parrentPanel.Size = new System.Drawing.Size(500, 370);
            this.parrentPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.zeusLink);
            this.mainPanel.Controls.Add(this.closeBtn);
            this.mainPanel.Controls.Add(this.adPicture);
            this.mainPanel.Controls.Add(this.actionControl);
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(300, 370);
            this.mainPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.Location = new System.Drawing.Point(267, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // adPicture
            // 
            this.adPicture.Image = ((System.Drawing.Image)(resources.GetObject("adPicture.Image")));
            this.adPicture.Location = new System.Drawing.Point(1, 259);
            this.adPicture.Name = "adPicture";
            this.adPicture.Size = new System.Drawing.Size(300, 107);
            this.adPicture.TabIndex = 1;
            this.adPicture.TabStop = false;
            // 
            // actionControl
            // 
            this.actionControl.Controls.Add(this.RequestTab);
            this.actionControl.Controls.Add(this.ResponseTab);
            this.actionControl.Controls.Add(this.aboutTab);
            this.actionControl.Location = new System.Drawing.Point(1, 28);
            this.actionControl.Name = "actionControl";
            this.actionControl.SelectedIndex = 0;
            this.actionControl.Size = new System.Drawing.Size(300, 229);
            this.actionControl.TabIndex = 0;
            // 
            // RequestTab
            // 
            this.RequestTab.BackColor = System.Drawing.Color.White;
            this.RequestTab.Controls.Add(this.dateTimeLabel);
            this.RequestTab.Location = new System.Drawing.Point(4, 24);
            this.RequestTab.Name = "RequestTab";
            this.RequestTab.Padding = new System.Windows.Forms.Padding(3);
            this.RequestTab.Size = new System.Drawing.Size(292, 201);
            this.RequestTab.TabIndex = 0;
            this.RequestTab.Text = "Request";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(16, 33);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(57, 15);
            this.dateTimeLabel.TabIndex = 0;
            this.dateTimeLabel.Text = "DateTime";
            // 
            // ResponseTab
            // 
            this.ResponseTab.Location = new System.Drawing.Point(4, 24);
            this.ResponseTab.Name = "ResponseTab";
            this.ResponseTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResponseTab.Size = new System.Drawing.Size(292, 201);
            this.ResponseTab.TabIndex = 1;
            this.ResponseTab.Text = "Response";
            this.ResponseTab.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(138)))));
            this.sidePanel.Controls.Add(this.intText);
            this.sidePanel.Controls.Add(this.integrationPicture);
            this.sidePanel.Controls.Add(this.logo);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 370);
            this.sidePanel.TabIndex = 0;
            // 
            // intText
            // 
            this.intText.AutoSize = true;
            this.intText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intText.ForeColor = System.Drawing.Color.White;
            this.intText.Location = new System.Drawing.Point(44, 259);
            this.intText.Name = "intText";
            this.intText.Size = new System.Drawing.Size(115, 21);
            this.intText.TabIndex = 2;
            this.intText.Text = "Integrated with";
            // 
            // integrationPicture
            // 
            this.integrationPicture.Image = ((System.Drawing.Image)(resources.GetObject("integrationPicture.Image")));
            this.integrationPicture.Location = new System.Drawing.Point(10, 281);
            this.integrationPicture.Name = "integrationPicture";
            this.integrationPicture.Size = new System.Drawing.Size(183, 50);
            this.integrationPicture.TabIndex = 1;
            this.integrationPicture.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(26, 70);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(147, 162);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.frndLabel);
            this.aboutTab.Controls.Add(this.aboutLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 24);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(292, 201);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About Us";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(0, 55);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(292, 45);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Start your journey with us by integrating your Task OS \r\nwith our Fully Managed S" +
    "erverless \r\nCloud Computing Backend.";
            // 
            // frndLabel
            // 
            this.frndLabel.AutoSize = true;
            this.frndLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.frndLabel.Location = new System.Drawing.Point(3, 27);
            this.frndLabel.Name = "frndLabel";
            this.frndLabel.Size = new System.Drawing.Size(103, 21);
            this.frndLabel.TabIndex = 1;
            this.frndLabel.Text = "Hello, Friend";
            // 
            // zeusLink
            // 
            this.zeusLink.AutoSize = true;
            this.zeusLink.Location = new System.Drawing.Point(121, 348);
            this.zeusLink.Name = "zeusLink";
            this.zeusLink.Size = new System.Drawing.Size(118, 15);
            this.zeusLink.TabIndex = 3;
            this.zeusLink.TabStop = true;
            this.zeusLink.Text = "www.zeusbusiness.in";
            this.zeusLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zeusLink_LinkClicked);
            // 
            // ZPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 370);
            this.Controls.Add(this.parrentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZPay";
            this.Text = "Form1";
            this.parrentPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adPicture)).EndInit();
            this.actionControl.ResumeLayout(false);
            this.RequestTab.ResumeLayout(false);
            this.RequestTab.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integrationPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parrentPanel;
        private Panel sidePanel;
        private Panel mainPanel;
        private PictureBox logo;
        private TabControl actionControl;
        private TabPage RequestTab;
        private Label dateTimeLabel;
        private TabPage ResponseTab;
        private PictureBox adPicture;
        private Button closeBtn;
        private Label intText;
        private PictureBox integrationPicture;
        private LinkLabel zeusLink;
        private TabPage aboutTab;
        private Label frndLabel;
        private Label aboutLabel;
    }
}