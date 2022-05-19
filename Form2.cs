using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRP11_Castro_Jocson_LE2
{
    public partial class Form2 : Form
    {
        String regionEntry;
        int recordNumber, casesNumber;
        DataTable tableSource = new DataTable();

        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tableSource.Columns.Add("Record Number", typeof(int));
            tableSource.Columns.Add("Region", typeof(string));
            tableSource.Columns.Add("Cases", typeof(int));

            dataGridView1.DataSource = tableSource;

            tableSource.Rows.Add(1, "2", 30);
            tableSource.Rows.Add(2, "8", 50);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            recordNumber = int.Parse(RecordNumberTextBox.Text);
            regionEntry = RegionTextBox.Text;
            casesNumber = int.Parse(NumberOfCasesTextBox.Text);
            tableSource.Rows.Add(recordNumber, regionEntry, casesNumber);
            RecordNumberTextBox.Text = "";
            RegionTextBox.Text = "";
            NumberOfCasesTextBox.Text = "";
            MessageBox.Show("Add successful", "Record has been successfully added!", MessageBoxButtons.OK);
        }
    }
}
