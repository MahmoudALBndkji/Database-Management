using System;
using System.Windows.Forms;
using System.IO;

namespace m5
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();
        private void button2_Click_1(object sender, EventArgs e)
        {
            textpassowrd.Text = textUsername.Text = "";
            textUsername.Focus();
        }
        private void button3_Click_1(object sender, EventArgs e) => this.Close();
        private void checkBoPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoPass.Checked)
                textpassowrd.PasswordChar = '\0';
            else
                textpassowrd.PasswordChar = '*';
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.Open("text.txt", FileMode.Open, FileAccess.Read));
            string b;
            string v;
            while (br.PeekChar() != -1)
            {
                b = br.ReadString();
                v = br.ReadString();
                if (b == textUsername.Text && v == textpassowrd.Text)
                {
                    app ap = new app();
                    this.Hide();
                    ap.ShowDialog();
                }
                else
                    MessageBox.Show("The username or passowrd is wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            br.Close();
        }
    }
}

