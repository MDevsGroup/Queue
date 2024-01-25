using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using DataAccessLayer.Models;
using Desktop.Hodimlar.MacBookProForms;
using Guna.UI2.WinForms;
using Microsoft.AspNetCore.SignalR.Client;
using System.Drawing.Drawing2D;

namespace Desktop.Hodimlar;

public partial class MacBookPro : Form
{
    private readonly HubConnection _connection;
    private User _user;
    private IUserInterface _userInterface;
    List<Queue> Queues = new();

    public MacBookPro(HubConnection connection, 
        User user, IUserInterface userInterface)
    {
        _userInterface = userInterface;
        _connection = connection;
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
       
        _connection.On<NetworkUser>("Queue", async (networkUser) =>
        {
            flowLayoutPanel1.BeginInvoke(new Action(() =>
            {
                //yangi queue yaratish logikasi
                Queue queue = new()
                {
                    Id = 1,
                    QueueNumber = networkUser.ConnectionId,
                    CreatedAt = DateTime.Now
                };

                QueueControl queueControl = new(queue.Id, queue.QueueNumber, queue.CreatedAt);
                Queues.Add(queue);
                flowLayoutPanel1.Controls.Add(queueControl);
            }));
        });
    }

    private void showOnScreen(int screenNumber)
    {
        Screen[] screens = Screen.AllScreens;
        Location = screens[screenNumber].WorkingArea.Location;
        WindowState = FormWindowState.Maximized;
    }

    private async void closeBrt_Click(object sender, EventArgs e)
    {
        //_user.IsOnline = false;
        //_userInterface.UpdateOnlineUser(_user);
        await _connection.InvokeAsync("LeaveNetwork",
            new NetworkUser()
            {
                UserId = _user.Id,
                ConnectionId = _connection.ConnectionId
            });
        await _connection.StopAsync();
        Application.Exit();
    }
}

class Queue
{
    public int Id { get; set; }
    public string QueueNumber { get; set; }
    public DateTime CreatedAt { get; set; }
}