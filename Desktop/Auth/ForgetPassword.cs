
using BusinessLogicLayer.Interfaces;
using Messager.EskizUz;
using Toastr.Winforms;

namespace Desktop.Auth;

public partial class ForgetPassword : Form
{
    private readonly IUserInterface _userInterface;

    public ForgetPassword(IUserInterface userInterface)
    {
        InitializeComponent();
        _userInterface = userInterface;
    }




    private async void KodniOlishBtn_Click(object sender, EventArgs e)
    {
        var phoneNumber = telBox.Text;
        var messager = new MessagerAgent("mirabbosegamberdiyev7@gmail.com", "bYD5qpHPCDroxznocwGj4T2nKb3InuZ1pBNlrh8d");
        var natija = await messager.SendOtpAsync(phoneNumber);
        if(natija.Success)
        {
            Close();
            OTP otpForm = new OTP(_userInterface);
            otpForm.Show();
        }
        else
        {
            var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
            toast.ShowWarning("Telfon raqamga SMS yuborishda hatolik yuz berdi");
        }

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