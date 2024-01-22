using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Models;
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace Desktop.Hodimlar;

public partial class MacBookPro : Form
{
    private User _user;
    private IUserInterface _userInterface;
    public MacBookPro(User user, IUserInterface userInterface)
    {
        _userInterface = userInterface;
        _user = user;
        showOnScreen(0);
        InitializeComponent();
        _user.IsOnline = true;



    }

    private Region Picture(Guna2CirclePictureBox guna2CirclePictureBox)
    {
        GraphicsPath graphicsPath = new();
        graphicsPath.AddEllipse(0, 0, guna2CirclePictureBox.Width, guna2CirclePictureBox.Height);
        Region reg = new(graphicsPath);
        _user.IsOnline = true;

        return reg;
    }

    private void MacBookPro_Load(object sender, EventArgs e)
    {
        guna2CirclePictureBox1.Region = Picture(guna2CirclePictureBox1);
        _user.IsOnline = true;

    }

    private void showOnScreen(int screenNumber)
    {
        Screen[] screens = Screen.AllScreens;
        Location = screens[screenNumber].WorkingArea.Location;
        WindowState = FormWindowState.Maximized;
    }

    private void closeBrt_Click(object sender, EventArgs e)
    {
        this.Close();
        _user.IsOnline = false;
        _userInterface.UpdateOnlineUser(_user);
    }

    private void controlWaiting1_Load(object sender, EventArgs e)
    {

    }
}
