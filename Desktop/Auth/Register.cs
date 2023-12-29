

namespace Desktop.Auth;

public partial class Register : Form
{
    public Register()
    {
        InitializeComponent();
    }

    private void LovozimBox_TextChanged(object sender, EventArgs e)
    {
        LovozimBox.MaxLength = 50;

    }

    private void telBox_TextChanged(object sender, EventArgs e)
    {


    }

    private void telBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
        {
            e.Handled = true;
        }
        else
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if (telBox.Text.Length > 13)
                {
                    e.Handled = true;
                }
            }
        }
    }


    private void IsmTextBox_TextChanged(object sender, EventArgs e)
    {
        if (IsmTextBox.Text.Length > 20)
        {
            IsmTextBox.Text = IsmTextBox.Text.Substring(0, 20);
            IsmTextBox.SelectionStart = 20;
        }
    }


    private void FamiliyaTextBox_TextChanged(object sender, EventArgs e)
    {
        FamiliyaTextBox.MaxLength = 30;


    }

    private void ParolTextBox_TextChanged(object sender, EventArgs e)
    {
        ParolTextBox.MaxLength = 20;

    }

    private void ParolniTastiqlashBox_TextChanged(object sender, EventArgs e)
    {
        ParolniTastiqlashBox.MaxLength = 20;

    }

    private void IsmTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {

        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void FamiliyaTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {

        if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }
    private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide(); 

        Login login = new Login();
        login.Show();
    }



    private void SaqlashBtn_Click(object sender, EventArgs e)
    {

    }

}
