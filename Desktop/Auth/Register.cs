
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using Toastr.Winforms;
using Messager.EskizUz;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desktop.Auth;

public partial class Register : Form
{
    private readonly IUserInterface _userInterface;

    public Register(IUserInterface userInterface)
    {
        InitializeComponent();
        _userInterface = userInterface;
    }


    private void LovozimBox_TextChanged(object sender, EventArgs e)
    {
        LovozimBox.MaxLength = 50;
    }

    private void telBox_KeyPress(object sender, KeyPressEventArgs e)
    {

        if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
        {
            e.Handled = true;
            ParolTextBox.Focus();
        }
        else
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (telBox.Text.Length > 13)
                {
                    e.Handled = true;
                    ParolTextBox.Focus();

                }
            }
        }
    }

    private void IsmTextBox_TextChanged(object sender, EventArgs e)
    {
        if (IsmTextBox.Text.Length > 20)
        {
            IsmTextBox.Text = IsmTextBox.Text.Substring(0, 20);
            IsmTextBox.SelectionStart = 20;
        }
    }

    private void FamiliyaTextBox_TextChanged(object sender, EventArgs e)
    {
        FamiliyaTextBox.MaxLength = 30;
    }

    private void ParolTextBox_TextChanged(object sender, EventArgs e)
    {
        ParolTextBox.MaxLength = 30;

    }

    private void ParolniTastiqlashBox_TextChanged(object sender, EventArgs e)
    {
        ParolniTastiqlashBox.MaxLength = 20;
    }

    private void IsmTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            FamiliyaTextBox.Focus();
        }
        else if (IsmTextBox.Text.Length > 20)
        {
            IsmTextBox.Text = IsmTextBox.Text.Substring(0, 20);
            IsmTextBox.SelectionStart = 20;
        }
    }

    private void FamiliyaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            LovozimBox.Focus();
        }
        else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }

    }

    private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        Login login = new Login(_userInterface);
        login.Show();
    }

    public async void SaqlashBtn_Click(object sender, EventArgs e)
    {
        Saved();
    }


    public async void Saved()
    {
        var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);

        if (ParolTextBox.Text != ParolniTastiqlashBox.Text)
        {
            toast.ShowError("Parol bir hil emas");
            return;
        }

        RegisterDto registerDto = new RegisterDto()
        {
            FirstName = IsmTextBox.Text,
            LastName = FamiliyaTextBox.Text,
            Lavozimi = LovozimBox.Text,
            PhoneNumber = telBox.Text,
            Parol = ParolTextBox.Text,
            TasqidParol = ParolniTastiqlashBox.Text
        };
        string phoneNumber;
        if (telBox.Text.Length == 9)
        {
            phoneNumber = "+998" + telBox.Text;
        }
        else
        {
            phoneNumber = telBox.Text;
        }
        registerDto.PhoneNumber = phoneNumber;
        try
        {

            await Task.Run(async () =>
            {
                var result = await _userInterface.RegistrationCheck(registerDto);
                if (result)
                {
                    var messager = new MessagerAgent("mirabbosegamberdiyev7@gmail.com", "bYD5qpHPCDroxznocwGj4T2nKb3InuZ1pBNlrh8d");
                    var natija = await messager.SendOtpAsync(phoneNumber);
                    var code = natija.Code;
                    if (natija.Success)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            OTPForRegister oTPForRegister = new OTPForRegister(registerDto, _userInterface, code);
                            this.Hide();
                            oTPForRegister.Show();
                        });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            toast.ShowWarning("Telfon raqamga SMS yuborishda hatolik yuz berdi");
                        });
                    }
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        toast.ShowError("Telefon raqam oldin ro'yxatdan o'tgan!");
                    });

                }
            });
        }
        catch (Exception ex)
        {
            this.Invoke((MethodInvoker)delegate
            {
                toast.ShowError("Qo'shishda xatolik yuz berdi: " + ex.Message);
            });
        }
    }

    private void checkbox_CheckedChanged(object sender, EventArgs e)
    {
        if (checkbox.Checked)
        {
            ParolTextBox.UseSystemPasswordChar = false;
            ParolTextBox.PasswordChar = '\0';

            ParolniTastiqlashBox.UseSystemPasswordChar = false;
            ParolniTastiqlashBox.PasswordChar = '\0';
        }
        else
        {
            ParolTextBox.UseSystemPasswordChar = true;
            ParolTextBox.PasswordChar = '\u25CF';
            ParolniTastiqlashBox.UseSystemPasswordChar = true;
            ParolniTastiqlashBox.PasswordChar = '\u25CF';
        }
    }

    private void LovozimBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            telBox.Focus();
        }
    }

    private void ParolTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            ParolniTastiqlashBox.Focus();
        }
    }

    private void telBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void ParolniTastiqlashBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            e.Handled = true;
            SaqlashBtn.Focus();
        }
    }

    private async void SaqlashBtn_Enter(object sender, EventArgs e)
    {
         Saved();
    }
}

