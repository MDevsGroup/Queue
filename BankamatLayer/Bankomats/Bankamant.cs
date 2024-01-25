using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.UserDtos;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace BankamatLayer.Bankomats
{
    public partial class Bankamant : Form
    {
        private readonly IUserInterface _userInterface;
        HubConnection connection;
        List<User> users = new();
        List<NetworkUser> networkUsers = new();
        User selectedUser;

        public Bankamant(IUserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
            connection = new HubConnectionBuilder()
                .WithUrl("wss://localhost:1808/network")
                .Build();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //var users = await _userInterface.GetOnlineUsers();

            //MainPanel.Controls.Clear();
            //foreach (var user in users)
            //{
            //    Shifokorlar shifokorlar = new Shifokorlar(user.FirstName,
            //                                                 user.LastName,
            //                                                 user.Lavozimi);

            //    MainPanel.Controls.Add(shifokorlar);
            //}
        }

        private void showOnScreen(int screenNumber)
        {
            Screen[] screens = Screen.AllScreens;
            Location = screens[screenNumber].WorkingArea.Location;
            WindowState = FormWindowState.Maximized;
        }

        private async void Bankamant_Load(object sender, EventArgs e)
        {
            await connection.StartAsync();

            connection.On<NetworkUser>("JoinNetwork", async (networkUser) =>
            {
                MainPanel.BeginInvoke(new Action(async () =>
                {
                    var user = await _userInterface.GetByIdAsync(networkUser.UserId);
                    Shifokorlar shifokorlar = new Shifokorlar(user.FirstName,
                                                              user.LastName,
                                                              user.Lavozimi,
                                                              user.Id);
                    MainPanel.Controls.Add(shifokorlar);
                    shifokorlar.UserControlClicked += ShifokorSelect;
                    users.Add(user);
                }));
                networkUsers.Add(networkUser);
            });

            connection.On<NetworkUser>("LeaveNetwork", (networkUser) =>
            {
                MainPanel.BeginInvoke(new Action(() =>
                {
                    foreach (var item in MainPanel.Controls)
                    {
                        if (item is Shifokorlar shifokorlar)
                        {
                            if (shifokorlar.UserId == networkUser.UserId)
                            {
                                MainPanel.Controls.Remove(shifokorlar);
                                users.Remove(users.Find(x => x.Id == networkUser.UserId));
                            }
                        }
                    }
                }));
                networkUsers.Remove(networkUser);
            });
        }

        private void NavbatBtn_Click(object sender, EventArgs e)
        {
            var shifokor = networkUsers.Find(x => x.UserId == selectedUser.Id);
            connection.InvokeAsync("Queue", new NetworkUser
            {
                UserId = selectedUser.Id,
                ConnectionId = shifokor.ConnectionId
            });

            MessageBox.Show("Navbatga qo'shildi");
        }

        private void ShifokorSelect(object sender, EventArgs e)
        {
            var shifokorlar = (Shifokorlar)sender;
            var selectedUser = users.Find(x => x.Id == shifokorlar.UserId);
            tanlandi.Visible = true;
            tanlandi.Text = "Tanlandi: ";
            tanlandi.Text += $"{selectedUser.FirstName} {selectedUser.LastName}";
            this.selectedUser = selectedUser;
        }
    }
}
