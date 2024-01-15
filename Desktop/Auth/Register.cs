
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using Toastr.Winforms;
using Messager.EskizUz;

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
            TasqidParol = ParolniTastiqlashBox.Text,
            State = 0
        };
        var phoneNumber = telBox.Text;

        await Task.Run(async () =>
        {
            try
            {

                var messager = new MessagerAgent("mirabbosegamberdiyev7@gmail.com", "bYD5qpHPCDroxznocwGj4T2nKb3InuZ1pBNlrh8d");
                var natija = await messager.SendOtpAsync(phoneNumber);
                var code = natija.Code;

                if (natija.Success)
                {
                    await _userInterface.Registiration(registerDto);
                }
                else
                {
                    new Toast().ShowWarning("Telfon raqamga SMS yuborishda hatolik yuz berdi");
                }
            }
            catch (Exception ex)
            {
                new Toast().ShowError("Qo'shishda xatolik yuz berdi: " + ex.Message);
            }
        });

        OTPForRegister oTPForRegister = new OTPForRegister(_userInterface);
        this.Hide();

        oTPForRegister.Show();

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
}
