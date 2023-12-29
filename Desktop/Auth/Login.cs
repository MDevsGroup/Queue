using Desktop.Hodimlar;

namespace Desktop.Auth;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void telBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void telBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
        {
            e.Handled = true;
        }
        else
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (telBox.Text.Length > 13)
                {
                    e.Handled = true;
                }
            }
        }
    }

    private void ParolTextBox_TextChanged(object sender, EventArgs e)
    {
        ParolTextBox.MaxLength = 20;

    }
    private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        Register register = new Register();
        register.Show();
    }

    private void SMSLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        ForgetPassword forgetPassword = new ForgetPassword();
        forgetPassword.Show();
    }
    private void KirishBtn_Click(object sender, EventArgs e)
    {
        this.Hide();
        MacBookPro macBookPro = new MacBookPro();
        macBookPro.Show();
    }

}
