
using BusinessLogicLayer.Interfaces;
using Messager.EskizUz;
using Toastr.Winforms;

namespace Desktop.Auth;

public partial class ForgetPassword : Form
{
    private readonly IUserInterface _userInterface;
    private int _code;
    public ForgetPassword(IUserInterface userInterface)
    {
        InitializeComponent();
        _userInterface = userInterface;
    }
    private async void KodniOlishBtn_Click(object sender, EventArgs e)
    {
        var phoneNumber = telBox.Text;
        if (telBox.Text.Length == 9)
        {
            phoneNumber = "+998" + telBox.Text;
        }
        else
        {
            phoneNumber = telBox.Text;
        }
        var check = await _userInterface.GetByPhoneNumber(phoneNumber);
        if (check)
        {
            await Task.Run(async () =>
            {

                var messager = new MessagerAgent("sardorsaminov5@gmail.com", "AOZG0pbutgYE9zxfvue6ZuMlqBNVUlti9ouMGWmD");
                var natija = await messager.SendOtpAsync(phoneNumber);
                _code = natija.Code;
                if (natija.Success)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        var phoneNumber = telBox.Text;
                        Hide();
                        OTP otpForm = new OTP(_userInterface, phoneNumber, _code);
                        otpForm.ShowDialog();
                        Application.Exit();
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
        else
        {
            new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true).ShowError("Bunday foydalanuvchi mavjud emas");
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