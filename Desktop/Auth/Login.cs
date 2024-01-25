
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using Desktop.Hodimlar;
using Microsoft.AspNetCore.SignalR.Client;
using Toastr.Winforms;

namespace Desktop.Auth;

public partial class Login : Form
{
    private IUserInterface _userInterface;
    HubConnection connection;
    public Login(IUserInterface userInterface)
    {
        showOnScreen(0);
        InitializeComponent();
        _userInterface = userInterface;
        connection = new HubConnectionBuilder()
            .WithUrl("wss://localhost:1808/network")
            .Build();
    }

    private void telBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
        else
        {
            if (char.IsDigit(e.KeyChar) && telBox.Text.Length > 13)
            {
                e.Handled = true;
            }
        }
    }

    private void ParolTextBox_TextChanged(object sender, EventArgs e)
    {
        ParolTextBox.MaxLength = 20;
    }

    private void SMSLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Hide();
        ForgetPassword forgetPassword = new ForgetPassword(_userInterface);
        forgetPassword.Show();
    }

    private async void KirishBtn_Click(object sender, EventArgs e)
    {
        var toast = new Toast(ToastrPosition.TopCenter, duration: 3000, enableSoundEffect: true);

        LoginDto loginDto = new LoginDto()
        {
            PhoneNumber = telBox.Text,
            Parol = ParolTextBox.Text
        };

        try
        {
            var user = await _userInterface.Login(loginDto);
            Hide();

            await connection.StartAsync();
            await connection.InvokeAsync("JoinNetwork", 
                new NetworkUser()
                {
                    UserId = user.Id,
                    ConnectionId = connection.ConnectionId
                }
            );

            MacBookPro macBookPro = new MacBookPro(connection, user, _userInterface);
            macBookPro.ShowDialog();
            Close();
        }
        catch (Exception)
        {
            toast.ShowError("Parol notog'ri");
        }
    }

    private void checkbox_CheckedChanged(object sender, EventArgs e)
    {
        if (checkbox.Checked)
        {
            ParolTextBox.UseSystemPasswordChar = false;
            ParolTextBox.PasswordChar = '\0';
        }
        else
        {
            ParolTextBox.UseSystemPasswordChar = true;
            ParolTextBox.PasswordChar = '\u25CF';
        }
    }

    private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        this.Hide();
        Register register = new Register(_userInterface);
        register.Show();
    }

    private void KirishBtn_Enter(object sender, EventArgs e)
    {

    }

    private void showOnScreen(int screenNumber)
    {
        Screen[] screens = Screen.AllScreens;
        Location = screens[screenNumber].WorkingArea.Location;
        WindowState = FormWindowState.Maximized;
    }

    private void Login_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
