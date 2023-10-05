<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lockitdownc_
=======
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace Lockdown
>>>>>>> a81224bfc174161e5ed35f03c43d5c73017577c4
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

<<<<<<< HEAD
=======
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

>>>>>>> a81224bfc174161e5ed35f03c43d5c73017577c4
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
=======
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
>>>>>>> a81224bfc174161e5ed35f03c43d5c73017577c4
