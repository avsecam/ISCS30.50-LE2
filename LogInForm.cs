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
  public partial class LogInForm : Form {

    private List<UserCredentials> users = new List<UserCredentials>();

    public LogInForm() {
      InitializeComponent();

      users.Add(new UserCredentials("Hello", "World"));
      users.Add(new UserCredentials("Object", "Oriented"));
      users.Add(new UserCredentials("admin", "1234"));

      UsernamesLabel.Text = "Accepted Usernames: ";
      PasswordsLabel.Text = "Accepted Passwords: ";
      for (int i = 0; i < users.Count; ++i) {
        if (i == users.Count - 1) {
          UsernamesLabel.Text += $"{users[i].Username}";
          PasswordsLabel.Text += $"{users[i].Password}";
          continue;
        }

        UsernamesLabel.Text += $"{users[i].Username}, ";
        PasswordsLabel.Text += $"{users[i].Password}, ";
      }
    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void LogInBtn_Click(object sender, EventArgs e) {
      if (usernameTextBox.Text == "Hello" && PasswordTextBox.Text == "World") {
        MessageBox.Show("Log In Success", "Log In Success", MessageBoxButtons.OK);
        MainWindow mainWindow = new MainWindow();
        mainWindow.ShowDialog();
      } else if (usernameTextBox.Text != "Hello" || PasswordTextBox.Text == "World") {
        MessageBox.Show("Invalid username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
      } else if (usernameTextBox.Text == "Hello" || PasswordTextBox.Text != "World") {
        MessageBox.Show("Incorrect password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      usernameTextBox.Text = "";
      PasswordTextBox.Text = "";
    }
  }
}
