using BusinessLogicLayer.Interfaces;
using Toastr.Winforms;

namespace Desktop.Auth
{
    public partial class ResetPassword : Form
    {
        private readonly IUserInterface _userInterface;

        public ResetPassword(IUserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private void SaqlashBtn_Click(object sender, EventArgs e)
        {
            var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);

            if (ParolTextBox.Text.Length == ParolniTiklashTextBox.Text.Length)
            {
                for (int i = 0; i < ParolTextBox.Text.Length; i++)
                {
                    if (ParolTextBox.Text[i] != ParolniTiklashTextBox.Text[i])
                    {
                        toast.ShowWarning("Parol bir hil emas");
                        return;
                    }
                }
                this.Hide();
                Login login = new(_userInterface);
                login.Show();
            }
            else
            {
                toast.ShowWarning("Parol bir hil emas");
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
    }
}
