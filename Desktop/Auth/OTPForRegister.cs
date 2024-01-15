using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toastr.Winforms;

namespace Desktop.Auth
{
    public partial class OTPForRegister : Form
    {
        private readonly IUserInterface _userInterface;
        private readonly int code;
        Toast toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);
        private RegisterDto registerDto;

        public OTPForRegister(IUserInterface userInterface, int code)
        {
            InitializeComponent();
            _userInterface = userInterface;
            this.code = code;
        }

        private void YuborishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TasdiqlashBtn_Click(object sender, EventArgs e)
        {
            if (code == int.Parse(SMSKodTextBox.Text))
            {
                this.Hide();
                Login login = new Login(_userInterface);
                Register register = new Register(_userInterface);
                register.Saved(registerDto);

                login.Show();
            }
            else
            {
                toast.ShowWarning("Kod noto'g'ri");
            }
        }
    }
}
