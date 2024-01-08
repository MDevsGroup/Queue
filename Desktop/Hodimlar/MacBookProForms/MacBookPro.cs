using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Hodimlar
{
    public partial class MacBookPro : Form
    {
        public MacBookPro()
        {
            InitializeComponent();
        }

        private Region Picture(Guna2CirclePictureBox guna2CirclePictureBox)
        {
            GraphicsPath graphicsPath = new();
            graphicsPath.AddEllipse(0, 0, guna2CirclePictureBox.Width, guna2CirclePictureBox.Height);
            Region reg = new(graphicsPath);
            return reg;
        }

        private void MacBookPro_Load(object sender, EventArgs e)
        {
            guna2CirclePictureBox1.Region = Picture(guna2CirclePictureBox1);
        }
    }
}
