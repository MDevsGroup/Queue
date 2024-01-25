using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Hodimlar.MacBookProForms;
public partial class QueueControl : UserControl
{
    Queue queue;
    public QueueControl(int id, 
                        string queueNumber, 
                        DateTime date)
    {
        InitializeComponent();
        queue = new Queue()
        {
            Id = id,
            QueueNumber = queueNumber,
            CreatedAt = date
        };

        label1.Text = queue.Id.ToString();
        label2.Text = queue.QueueNumber;
        label3.Text = queue.CreatedAt.ToString();
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {

    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {

    }
}
