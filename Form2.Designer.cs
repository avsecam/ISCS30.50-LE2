
namespace GRP11_Castro_Jocson_LE2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.DeleteBtn = new System.Windows.Forms.Button();
      this.UpdateBtn = new System.Windows.Forms.Button();
      this.AddBtn = new System.Windows.Forms.Button();
      this.NumberOfCasesTextBox = new System.Windows.Forms.TextBox();
      this.RegionTextBox = new System.Windows.Forms.TextBox();
      this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
      this.NumberOfCasesLabel = new System.Windows.Forms.Label();
      this.RegionLabel = new System.Windows.Forms.Label();
      this.RecordNumberLabel = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.DeleteBtn);
      this.groupBox1.Controls.Add(this.UpdateBtn);
      this.groupBox1.Controls.Add(this.AddBtn);
      this.groupBox1.Controls.Add(this.NumberOfCasesTextBox);
      this.groupBox1.Controls.Add(this.RegionTextBox);
      this.groupBox1.Controls.Add(this.RecordNumberTextBox);
      this.groupBox1.Controls.Add(this.NumberOfCasesLabel);
      this.groupBox1.Controls.Add(this.RegionLabel);
      this.groupBox1.Controls.Add(this.RecordNumberLabel);
      this.groupBox1.Location = new System.Drawing.Point(465, 33);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(304, 382);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Functionalities";
      // 
      // DeleteBtn
      // 
      this.DeleteBtn.Location = new System.Drawing.Point(101, 274);
      this.DeleteBtn.Name = "DeleteBtn";
      this.DeleteBtn.Size = new System.Drawing.Size(112, 64);
      this.DeleteBtn.TabIndex = 8;
      this.DeleteBtn.Text = "Delete";
      this.DeleteBtn.UseVisualStyleBackColor = true;
      this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
      // 
      // UpdateBtn
      // 
      this.UpdateBtn.Location = new System.Drawing.Point(167, 192);
      this.UpdateBtn.Name = "UpdateBtn";
      this.UpdateBtn.Size = new System.Drawing.Size(106, 57);
      this.UpdateBtn.TabIndex = 7;
      this.UpdateBtn.Text = "Update";
      this.UpdateBtn.UseVisualStyleBackColor = true;
      this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
      // 
      // AddBtn
      // 
      this.AddBtn.Location = new System.Drawing.Point(32, 192);
      this.AddBtn.Name = "AddBtn";
      this.AddBtn.Size = new System.Drawing.Size(113, 57);
      this.AddBtn.TabIndex = 6;
      this.AddBtn.Text = "Add";
      this.AddBtn.UseVisualStyleBackColor = true;
      this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
      // 
      // NumberOfCasesTextBox
      // 
      this.NumberOfCasesTextBox.Location = new System.Drawing.Point(126, 126);
      this.NumberOfCasesTextBox.Name = "NumberOfCasesTextBox";
      this.NumberOfCasesTextBox.Size = new System.Drawing.Size(147, 20);
      this.NumberOfCasesTextBox.TabIndex = 5;
      // 
      // RegionTextBox
      // 
      this.RegionTextBox.Location = new System.Drawing.Point(126, 89);
      this.RegionTextBox.Name = "RegionTextBox";
      this.RegionTextBox.Size = new System.Drawing.Size(147, 20);
      this.RegionTextBox.TabIndex = 4;
      // 
      // RecordNumberTextBox
      // 
      this.RecordNumberTextBox.Location = new System.Drawing.Point(126, 46);
      this.RecordNumberTextBox.Name = "RecordNumberTextBox";
      this.RecordNumberTextBox.Size = new System.Drawing.Size(147, 20);
      this.RecordNumberTextBox.TabIndex = 3;
      // 
      // NumberOfCasesLabel
      // 
      this.NumberOfCasesLabel.AutoSize = true;
      this.NumberOfCasesLabel.Location = new System.Drawing.Point(29, 129);
      this.NumberOfCasesLabel.Name = "NumberOfCasesLabel";
      this.NumberOfCasesLabel.Size = new System.Drawing.Size(88, 13);
      this.NumberOfCasesLabel.TabIndex = 2;
      this.NumberOfCasesLabel.Text = "Number of Cases";
      // 
      // RegionLabel
      // 
      this.RegionLabel.AutoSize = true;
      this.RegionLabel.Location = new System.Drawing.Point(29, 92);
      this.RegionLabel.Name = "RegionLabel";
      this.RegionLabel.Size = new System.Drawing.Size(41, 13);
      this.RegionLabel.TabIndex = 1;
      this.RegionLabel.Text = "Region";
      // 
      // RecordNumberLabel
      // 
      this.RecordNumberLabel.AutoSize = true;
      this.RecordNumberLabel.Location = new System.Drawing.Point(29, 49);
      this.RecordNumberLabel.Name = "RecordNumberLabel";
      this.RecordNumberLabel.Size = new System.Drawing.Size(82, 13);
      this.RecordNumberLabel.TabIndex = 0;
      this.RecordNumberLabel.Text = "Record Number";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(22, 33);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(418, 382);
      this.dataGridView1.TabIndex = 1;
      this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.BurlyWood;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form2";
      this.Text = "Main Window";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NumberOfCasesTextBox;
        private System.Windows.Forms.TextBox RegionTextBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.Label NumberOfCasesLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label RecordNumberLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}