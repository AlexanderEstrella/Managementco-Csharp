using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace Lockdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectoSQL_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(
          new SqlConnectionStringBuilder()
          {
              DataSource = "ALEX-PC",
              InitialCatalog = "AdventureWorks2019",
              UserID = "sa",
              Password = "admi"
          }.ConnectionString
      );
                conn.Open();


                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}