namespace Desktop.Auth
{
    partial class ForgetPassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            KodniOlishBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            telBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // KodniOlishBtn
            // 
            KodniOlishBtn.Anchor = AnchorStyles.None;
            KodniOlishBtn.BorderRadius = 6;
            KodniOlishBtn.CustomizableEdges = customizableEdges5;
            KodniOlishBtn.DisabledState.BorderColor = Color.DarkGray;
            KodniOlishBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            KodniOlishBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            KodniOlishBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            KodniOlishBtn.FillColor = Color.FromArgb(79, 70, 229);
            KodniOlishBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KodniOlishBtn.ForeColor = Color.White;
            KodniOlishBtn.Location = new Point(21, 193);
            KodniOlishBtn.Name = "KodniOlishBtn";
            KodniOlishBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            KodniOlishBtn.Size = new Size(340, 39);
            KodniOlishBtn.TabIndex = 30;
            KodniOlishBtn.Text = "Kodni olish";
            KodniOlishBtn.Click += KodniOlishBtn_Click;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.None;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(119, 22);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(136, 32);
            guna2HtmlLabel2.TabIndex = 29;
            guna2HtmlLabel2.Text = "Parolni tiklash";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.TopCenter;
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // telBox
            // 
            telBox.Anchor = AnchorStyles.None;
            telBox.BorderRadius = 5;
            telBox.BorderThickness = 0;
            telBox.CustomizableEdges = customizableEdges7;
            telBox.DefaultText = "+998";
            telBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            telBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            telBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            telBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            telBox.FillColor = Color.FromArgb(224, 224, 224);
            telBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            telBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            telBox.ForeColor = Color.FromArgb(102, 102, 102);
            telBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            telBox.Location = new Point(21, 111);
            telBox.Margin = new Padding(5);
            telBox.MaxLength = 13;
            telBox.Name = "telBox";
            telBox.PasswordChar = '\0';
            telBox.PlaceholderText = "";
            telBox.SelectedText = "";
            telBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            telBox.Size = new Size(340, 40);
            telBox.TabIndex = 28;
            telBox.KeyPress += telBox_KeyPress;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.Anchor = AnchorStyles.None;
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.Location = new Point(21, 76);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(129, 27);
            guna2HtmlLabel5.TabIndex = 27;
            guna2HtmlLabel5.Text = "Telefon raqam";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 267);
            Controls.Add(KodniOlishBtn);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(telBox);
            Controls.Add(guna2HtmlLabel5);
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button KodniOlishBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox telBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}