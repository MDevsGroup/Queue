
using System.ComponentModel;

namespace BankamatLayer.Bankomats
{
    public partial class Shifokorlar : UserControl
    {
        public int UserId { get; }

        public Shifokorlar(string FisrtName,
                             string LastName,
                             string Lavozim,
                             int userId)
        {
            InitializeComponent();
            Ism.Text = FisrtName + LastName;
            level.Text = Lavozim;
            UserId = userId;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [Browsable(true)]
        public event EventHandler UserControlClicked;
        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            UserControlClicked?.Invoke(this, e);
        }
    }
}
