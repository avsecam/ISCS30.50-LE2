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

    private void LogInBtn_Click(object sender, EventArgs e) {
      if (isValidUser(UsernameTextBox.Text, PasswordTextBox.Text)) {
        MessageBox.Show("Log In Success", "Log In Success", MessageBoxButtons.OK);
        MainWindow mainWindow = new MainWindow();
        mainWindow.Username = UsernameTextBox.Text;
        mainWindow.ShowDialog();
      } else {
        MessageBox.Show("Invalid username or password.", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ClearBtn_Click(object sender, EventArgs e) {
      UsernameTextBox.Clear();
      PasswordTextBox.Clear();
    }

    private bool isValidUser(string username, string password) {
      foreach (UserCredentials user in users) {
        if (user.Username == username && user.Password == password) return true;
      }
      return false;
    }
  }
}
