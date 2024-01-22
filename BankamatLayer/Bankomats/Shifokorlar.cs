
namespace BankamatLayer.Bankomats
{
    public partial class Shifokorlar : UserControl
    {
        public Shifokorlar(string FisrtName,
                             string LastName,
                             string Lavozim)
        {
            InitializeComponent();
            Ism.Text = FisrtName + LastName;
            level.Text = Lavozim;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   

    }
}
