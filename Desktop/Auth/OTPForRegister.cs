using BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Auth
{
    public partial class OTPForRegister : Form
    {
        private readonly IUserInterface _userInterface;

        public OTPForRegister(IUserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private void YuborishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void TasdiqlashBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_userInterface);
            login.Show();

        }
    }
}
