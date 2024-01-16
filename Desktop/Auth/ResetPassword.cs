using BusinessLogicLayer.Interfaces;
using Toastr.Winforms;

namespace Desktop.Auth
{
    public partial class ResetPassword : Form
    {
        private readonly IUserInterface _userInterface;
        private readonly string _phoneNumber;

        public ResetPassword(IUserInterface userInterface,
                             string phoneNumber)
        {
            InitializeComponent();
            _userInterface = userInterface;
            _phoneNumber = phoneNumber;
        }
        
        private async void SaqlashBtn_Click(object sender, EventArgs e)
        {
            var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
            var check = Textvalidator(ParolTextBox.Text, ParolniTiklashTextBox.Text);
            if (check.Item1 == false)
            {
                new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true).ShowWarning(check.Item2);
            }
            else
            {
                try
                {
                    await _userInterface.UpdatePassword(_phoneNumber, ParolTextBox.Text);
                    Login login = new(_userInterface);
                    this.Close();
                    login.Show();
                }
                catch(ArgumentNullException ex)
                {
                    new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true).ShowError(ex.Message);
                }
            }
        }
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void ParolTextBox_TextChanged(object sender, EventArgs e)
        {
            ParolTextBox.MaxLength = 20;
        }

        private void ParolniTiklashTextBox_TextChanged(object sender, EventArgs e)
        {
            ParolniTiklashTextBox.MaxLength = 20;
        }

        private (bool, string) Textvalidator(string str1, string str2)
        {
            if (str1 != str2) return (false, "Parol bir hil emas");

            if (str1.Length < 3) return (false, "Parol uzunligi 3 tadan uzun bo'lishi shart!");

            return (true, "OK");
        }
    }
}
