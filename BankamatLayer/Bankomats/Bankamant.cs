using BusinessLogicLayer.Interfaces;


namespace BankamatLayer.Bankomats
{
    public partial class Bankamant : Form
    {
        private readonly IUserInterface _userInterface;

        public Bankamant(IUserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            var users = await _userInterface.GetOnlineUsers();

            MainPanel.Controls.Clear();
            foreach (var user in users)
            {
                Shifokorlar shifokorlar = new Shifokorlar(user.FirstName,
                                                             user.LastName,
                                                             user.Lavozimi);

                MainPanel.Controls.Add(shifokorlar);
            }
        }

        private void showOnScreen(int screenNumber)
        {
            Screen[] screens = Screen.AllScreens;
            Location = screens[screenNumber].WorkingArea.Location;
            WindowState = FormWindowState.Maximized;
        }
    }
}
