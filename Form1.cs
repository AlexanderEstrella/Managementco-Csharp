using System.Data;
using System.Data.SqlClient;
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
            System.Data.SqlClient.SqlConnectionStringBuilder builder =
   new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = "(local)";
            builder["integrated Security"] = true;
            builder["Initial Catalog"] = "AdventureWorks;NewValue=Bad";
            Console.WriteLine(builder.ConnectionString);
        }
    }
}