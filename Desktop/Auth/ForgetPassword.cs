
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
        await Task.Run(async () =>
        {

            var messager = new MessagerAgent("sardorsaminov@gmail.com", "AOZG0pbutgYE9zxfvue6ZuMlqBNVUlti9ouMGWmD");
            var natija = await messager.SendOtpAsync(phoneNumber);
            if (!natija.Success)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    var phoneNumber = telBox.Text;
                    OTP otpForm = new OTP(phoneNumber);
                    this.Hide();
                    otpForm.Show();
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
                    toast.ShowWarning("Telefon raqamga SMS yuborishda xatolik yuz berdi");
                });
            }

        });


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