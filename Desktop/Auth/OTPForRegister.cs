using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using Toastr.Winforms;

namespace Desktop.Auth
{
    public partial class OTPForRegister : Form
    {
        private readonly IUserInterface _userInterface;
        public Toast toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
        private RegisterDto registerDto;
        private int remainingSeconds = 30;
        private int refreshCode;

        public OTPForRegister(IUserInterface userInterface, int code)
        {
            InitializeComponent();
            _userInterface = userInterface;
            refreshCode = code;
        }

        private void YuborishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TasdiqlashBtn_Click(object sender, EventArgs e)
        {
            if (refreshCode == int.Parse(SMSKodTextBox.Text))
            {
                this.Hide();
                Login login = new Login(_userInterface);
                login.Show();
            }
            else
            {
                new Toast().ShowWarning("Kod noto'g'ri");
            }
        }

        private void OTPForRegister_Load(object sender, EventArgs e)
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
                toast.ShowWarning("Sms kod ni amal qilish muddati tugadi!");
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
}
