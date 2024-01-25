namespace BankamatLayer.Bankomats
{
    partial class Bankamant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            NavbatBtn = new Guna.UI2.WinForms.Guna2Button();
            MainPanel = new FlowLayoutPanel();
            tanlandi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            topPanel.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(guna2HtmlLabel2);
            topPanel.Controls.Add(guna2HtmlLabel1);
            topPanel.CustomizableEdges = customizableEdges1;
            topPanel.Dock = DockStyle.Top;
            topPanel.FillColor = Color.White;
            topPanel.FillColor2 = Color.White;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            topPanel.Size = new Size(734, 70);
            topPanel.TabIndex = 0;
            topPanel.Paint += topPanel_Paint;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.Top;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(163, 37);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(424, 23);
            guna2HtmlLabel2.TabIndex = 1;
            guna2HtmlLabel2.Text = "Shifokorlarimizdan birning ko’rigi uchun navbatga yoziling";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.Top;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(300, 6);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(151, 25);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Assalomu alaykum!";
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(tanlandi);
            guna2CustomGradientPanel1.Controls.Add(NavbatBtn);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel1.Dock = DockStyle.Bottom;
            guna2CustomGradientPanel1.Location = new Point(0, 407);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Size = new Size(734, 103);
            guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // NavbatBtn
            // 
            NavbatBtn.Anchor = AnchorStyles.Bottom;
            NavbatBtn.BorderRadius = 10;
            NavbatBtn.CustomizableEdges = customizableEdges3;
            NavbatBtn.DisabledState.BorderColor = Color.DarkGray;
            NavbatBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            NavbatBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            NavbatBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            NavbatBtn.FillColor = Color.FromArgb(79, 70, 229);
            NavbatBtn.Font = new Font("Segoe UI Semibold", 10.75F, FontStyle.Bold);
            NavbatBtn.ForeColor = Color.White;
            NavbatBtn.Location = new Point(528, 29);
            NavbatBtn.Name = "NavbatBtn";
            NavbatBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            NavbatBtn.Size = new Size(179, 44);
            NavbatBtn.TabIndex = 0;
            NavbatBtn.Text = "Navbatni olish";
            NavbatBtn.Click += NavbatBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 70);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(734, 337);
            MainPanel.TabIndex = 2;
            // 
            // tanlandi
            // 
            tanlandi.Anchor = AnchorStyles.Top;
            tanlandi.BackColor = Color.Transparent;
            tanlandi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanlandi.Location = new Point(12, 32);
            tanlandi.Name = "tanlandi";
            tanlandi.Size = new Size(109, 34);
            tanlandi.TabIndex = 1;
            tanlandi.Text = "Tanlandi:";
            tanlandi.Visible = false;
            // 
            // Bankamant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 510);
            Controls.Add(MainPanel);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(topPanel);
            MinimumSize = new Size(750, 549);
            Name = "Bankamant";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stoyka";
            Load += Bankamant_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel topPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button NavbatBtn;
        private FlowLayoutPanel MainPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel tanlandi;
    }
}