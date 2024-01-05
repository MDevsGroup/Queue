using BusinessLogicLayer.Interfaces;
using Messager.EskizUz;
namespace Desktop.Auth;

public partial class OTP : Form
{
    private readonly IUserInterface _userInterface;
    
    public OTP(IUserInterface userInterface)
    {
        InitializeComponent();
        _userInterface = userInterface;
    }

    private void TasdiqlashBtn_Click(object sender, EventArgs e)
    {

        this.Hide();
        ResetPassword resetPassword = new ResetPassword(_userInterface);
        resetPassword.Show();
    }

    private void YuborishLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }
}
