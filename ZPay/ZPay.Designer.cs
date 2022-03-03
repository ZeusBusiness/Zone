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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.zPayLabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.actionControl = new System.Windows.Forms.TabControl();
            this.RequestTab = new System.Windows.Forms.TabPage();
            this.ResponseTab = new System.Windows.Forms.TabPage();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.parrentPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.actionControl.SuspendLayout();
            this.RequestTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.actionControl);
            this.mainPanel.Location = new System.Drawing.Point(200, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(300, 370);
            this.mainPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(66)))), ((int)(((byte)(138)))));
            this.sidePanel.Controls.Add(this.zPayLabel);
            this.sidePanel.Controls.Add(this.logo);
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 370);
            this.sidePanel.TabIndex = 0;
            // 
            // zPayLabel
            // 
            this.zPayLabel.AutoSize = true;
            this.zPayLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zPayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(127)))), ((int)(((byte)(14)))));
            this.zPayLabel.Location = new System.Drawing.Point(56, 171);
            this.zPayLabel.Name = "zPayLabel";
            this.zPayLabel.Size = new System.Drawing.Size(60, 30);
            this.zPayLabel.TabIndex = 1;
            this.zPayLabel.Text = "ZPay";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(32, 39);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(120, 120);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // actionControl
            // 
            this.actionControl.Controls.Add(this.RequestTab);
            this.actionControl.Controls.Add(this.ResponseTab);
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
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(16, 33);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(57, 15);
            this.dateTimeLabel.TabIndex = 0;
            this.dateTimeLabel.Text = "DateTime";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZPay.Properties.Resources.zeusBusiness;
            this.pictureBox1.Location = new System.Drawing.Point(1, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.actionControl.ResumeLayout(false);
            this.RequestTab.ResumeLayout(false);
            this.RequestTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel parrentPanel;
        private Panel sidePanel;
        private Panel mainPanel;
        private Label zPayLabel;
        private PictureBox logo;
        private TabControl actionControl;
        private TabPage RequestTab;
        private Label dateTimeLabel;
        private TabPage ResponseTab;
        private PictureBox pictureBox1;
    }
}