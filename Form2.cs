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
  public partial class Form2 : Form {
    String regionEntry;
    int recordNumber, casesNumber;
    DataTable tableSource = new DataTable();

    public Form2() {
      InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e) {
      tableSource.Columns.Add("Record Number", typeof(int));
      tableSource.Columns.Add("Region", typeof(string));
      tableSource.Columns.Add("Cases", typeof(int));

      dataGridView1.DataSource = tableSource;

      tableSource.Rows.Add(1, "2", 30);
      tableSource.Rows.Add(2, "8", 50);
    }

    private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e) {
      DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
      RecordNumberTextBox.Text = selectedRow.Cells[0].Value.ToString();
      RegionTextBox.Text = selectedRow.Cells[1].Value.ToString();
      NumberOfCasesTextBox.Text = selectedRow.Cells[2].Value.ToString();
    }

    private void AddBtn_Click(object sender, EventArgs e) {
      if (RecordNumberTextBox.Text.Length == 0 || RegionTextBox.Text.Length == 0 || NumberOfCasesTextBox.Text.Length == 0) return;

      recordNumber = int.Parse(RecordNumberTextBox.Text);
      regionEntry = RegionTextBox.Text;
      casesNumber = int.Parse(NumberOfCasesTextBox.Text);
      tableSource.Rows.Add(recordNumber, regionEntry, casesNumber);
      MessageBox.Show("Add successful", "Record has been successfully added!", MessageBoxButtons.OK);
      ClearFields();
    }

    private void UpdateBtn_Click(object sender, EventArgs e) {
      if (dataGridView1.SelectedRows.Count < 1) return;
      if (RecordNumberTextBox.Text.Length == 0 || RegionTextBox.Text.Length == 0 || NumberOfCasesTextBox.Text.Length == 0) return;

      DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
      recordNumber = int.Parse(RecordNumberTextBox.Text);
      regionEntry = RegionTextBox.Text;
      casesNumber = int.Parse(NumberOfCasesTextBox.Text);
      selectedRow.Cells[0].Value = recordNumber;
      selectedRow.Cells[1].Value = regionEntry;
      selectedRow.Cells[2].Value = casesNumber;
      MessageBox.Show("Update successful", "Record has been successfully updated!", MessageBoxButtons.OK);
      ClearFields();
    }

    private void DeleteBtn_Click(object sender, EventArgs e) {
      if (dataGridView1.SelectedRows.Count < 1) return;

      DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
      dataGridView1.Rows.Remove(selectedRow);
      MessageBox.Show("Delete successful", "Record has been successfully deleted!", MessageBoxButtons.OK);
      ClearFields();
    }

    private void ClearFields() {
      RecordNumberTextBox.Clear();
      RegionTextBox.Clear();
      NumberOfCasesTextBox.Clear();
    }
  }

}
