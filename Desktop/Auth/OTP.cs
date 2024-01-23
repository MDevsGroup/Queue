using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using Messager.EskizUz;
using Toastr.Winforms;
namespace Desktop.Auth;

public partial class OTP : Form
{
    private readonly IUserInterface _userInterface;
    public Toast toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
    private RegisterDto registerDto;
    private int remainingSeconds = 120;
    private int refreshCode;
    private string _phoneNumber;

    public OTP(RegisterDto oTPFor, IUserInterface userInterface, int code)
    {
        InitializeComponent(); 
        _userInterface = userInterface;
        refreshCode = code;
        registerDto = oTPFor;
        _phoneNumber = oTPFor.PhoneNumber;
    }

    public OTP(IUserInterface userInterface, string phoneNumber, int code)
    {
        InitializeComponent();
        _userInterface = userInterface;
        _phoneNumber = phoneNumber;
        refreshCode = code;
    }

    private void TasdiqlashBtn_Click(object sender, EventArgs e)
    {
        if (refreshCode == int.Parse(SMSKodTextBox.Text))
        {
            timer1.Stop();
            Hide();
            ResetPassword resetPassword = new ResetPassword(_userInterface, _phoneNumber);
            resetPassword.ShowDialog();
            Application.Exit();

        }
        else
        {
            new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true).ShowWarning("Kod noto'g'ri");
        }
    }

    private async void YuborishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        YuborishLabel.Visible = false;
        var phoneNumber = _phoneNumber;
        await Task.Run(async () =>
        {
            var messager = new MessagerAgent("sardorsaminov5@gmail.com", "AOZG0pbutgYE9zxfvue6ZuMlqBNVUlti9ouMGWmD");
            var natija = await messager.SendOtpAsync(phoneNumber);
        });

        remainingSeconds = 120;

        timer1.Interval = 1000;

        timer1.Start();
    }

    private void OTP_Load(object sender, EventArgs e)
    {
        timer1.Tick += new EventHandler(timer1_Tick);

        timer1.Interval = 1000;

        timer1.Start();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        if (remainingSeconds > 0)
        {
            remainingSeconds--;
            label1.Text = FormatTime(remainingSeconds);
        }
        else
        {
            timer1.Stop();
            new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true).ShowWarning("Sms kod ni amal qilish muddati tugadi!");
            refreshCode = 0;
            YuborishLabel.Visible = true;
        }
    }

    private string FormatTime(int seconds)
    {
        int minutes = seconds / 60;
        int remainingSeconds = seconds % 60;
        return $"{minutes:D2}:{remainingSeconds:D2}";
    }
}
