
using Messager.EskizUz;

namespace Desktop.Auth;

public partial class ForgetPassword : Form
{
    public ForgetPassword()
    {
        InitializeComponent();
    }




    private async void KodniOlishBtn_Click(object sender, EventArgs e)
    {
        Close();
        OTP otpForm = new OTP();
        otpForm.Show();
    }

    private void telBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
        else if (Char.IsDigit(e.KeyChar) && telBox.Text.Length > 13)
        {
            e.Handled = true;
        }
    }

    private void guna2HtmlLabel2_Click(object sender, EventArgs e)
    {

    }
}