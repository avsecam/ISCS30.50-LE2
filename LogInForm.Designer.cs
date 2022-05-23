
namespace GRP11_Castro_Jocson_LE2 {
  partial class LogInForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.UsernameLabel = new System.Windows.Forms.Label();
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.usernameTextBox = new System.Windows.Forms.TextBox();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.LogInBtn = new System.Windows.Forms.Button();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.UsernamesLabel = new System.Windows.Forms.Label();
      this.PasswordsLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // UsernameLabel
      // 
      this.UsernameLabel.AutoSize = true;
      this.UsernameLabel.Location = new System.Drawing.Point(152, 66);
      this.UsernameLabel.Name = "UsernameLabel";
      this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
      this.UsernameLabel.TabIndex = 0;
      this.UsernameLabel.Text = "Username";
      this.UsernameLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Location = new System.Drawing.Point(154, 119);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
      this.PasswordLabel.TabIndex = 1;
      this.PasswordLabel.Text = "Password";
      // 
      // usernameTextBox
      // 
      this.usernameTextBox.Location = new System.Drawing.Point(102, 82);
      this.usernameTextBox.Name = "usernameTextBox";
      this.usernameTextBox.Size = new System.Drawing.Size(163, 20);
      this.usernameTextBox.TabIndex = 2;
      this.usernameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(102, 135);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.PasswordChar = '*';
      this.PasswordTextBox.Size = new System.Drawing.Size(163, 20);
      this.PasswordTextBox.TabIndex = 3;
      this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // LogInBtn
      // 
      this.LogInBtn.BackColor = System.Drawing.SystemColors.Control;
      this.LogInBtn.Location = new System.Drawing.Point(71, 188);
      this.LogInBtn.Name = "LogInBtn";
      this.LogInBtn.Size = new System.Drawing.Size(93, 49);
      this.LogInBtn.TabIndex = 4;
      this.LogInBtn.Text = "Log In";
      this.LogInBtn.UseVisualStyleBackColor = false;
      this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
      // 
      // ClearBtn
      // 
      this.ClearBtn.Location = new System.Drawing.Point(208, 188);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(83, 49);
      this.ClearBtn.TabIndex = 5;
      this.ClearBtn.Text = "Clear";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // UsernamesLabel
      // 
      this.UsernamesLabel.AutoSize = true;
      this.UsernamesLabel.Location = new System.Drawing.Point(12, 9);
      this.UsernamesLabel.Name = "UsernamesLabel";
      this.UsernamesLabel.Size = new System.Drawing.Size(85, 13);
      this.UsernamesLabel.TabIndex = 6;
      this.UsernamesLabel.Text = "Username: Hello";
      // 
      // PasswordsLabel
      // 
      this.PasswordsLabel.AutoSize = true;
      this.PasswordsLabel.Location = new System.Drawing.Point(12, 22);
      this.PasswordsLabel.Name = "PasswordsLabel";
      this.PasswordsLabel.Size = new System.Drawing.Size(87, 13);
      this.PasswordsLabel.TabIndex = 7;
      this.PasswordsLabel.Text = "Password: World";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkCyan;
      this.ClientSize = new System.Drawing.Size(364, 261);
      this.Controls.Add(this.PasswordsLabel);
      this.Controls.Add(this.UsernamesLabel);
      this.Controls.Add(this.ClearBtn);
      this.Controls.Add(this.LogInBtn);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.usernameTextBox);
      this.Controls.Add(this.PasswordLabel);
      this.Controls.Add(this.UsernameLabel);
      this.Name = "Form1";
      this.Text = "Log In Window";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label UsernamesLabel;
        private System.Windows.Forms.Label PasswordsLabel;
    }
}

