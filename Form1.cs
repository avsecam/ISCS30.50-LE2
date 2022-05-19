using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRP11_Castro_Jocson_LE2 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Hello" && PasswordTextBox.Text == "World")
            {
                MessageBox.Show("Log In Success", "Log In Success", MessageBoxButtons.OK);
                Form2 mainWindow = new Form2();
                mainWindow.ShowDialog();
            }
            else if (usernameTextBox.Text != "Hello" || PasswordTextBox.Text == "World")
            {
                MessageBox.Show("Invalid username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernameTextBox.Text == "Hello" || PasswordTextBox.Text != "World")
            {
                MessageBox.Show("Incorrect password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
