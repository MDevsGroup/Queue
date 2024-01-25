namespace Desktop.Hodimlar.MacBookProForms;

partial class QueueControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 14);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(106, 15);
        label2.Name = "label2";
        label2.Size = new Size(38, 15);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(239, 15);
        label3.Name = "label3";
        label3.Size = new Size(38, 15);
        label3.TabIndex = 2;
        label3.Text = "label3";
        // 
        // guna2Button1
        // 
        guna2Button1.CustomizableEdges = customizableEdges1;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.Font = new Font("Segoe UI", 9F);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(326, 10);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2Button1.Size = new Size(138, 37);
        guna2Button1.TabIndex = 3;
        guna2Button1.Text = "guna2Button1";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2Button2
        // 
        guna2Button2.CustomizableEdges = customizableEdges3;
        guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button2.Font = new Font("Segoe UI", 9F);
        guna2Button2.ForeColor = Color.White;
        guna2Button2.Location = new Point(490, 10);
        guna2Button2.Name = "guna2Button2";
        guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
        guna2Button2.Size = new Size(138, 37);
        guna2Button2.TabIndex = 4;
        guna2Button2.Text = "guna2Button2";
        guna2Button2.Click += guna2Button2_Click;
        // 
        // QueueControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(guna2Button2);
        Controls.Add(guna2Button1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "QueueControl";
        Size = new Size(661, 56);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2Button guna2Button1;
    private Guna.UI2.WinForms.Guna2Button guna2Button2;
}
