using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class SearchLocation : Form
    {

        DataTable dt = new DataTable();

        public SearchLocation()
        {
            InitializeComponent();
        }
        private SqlConnection SQLConnection()
        {

            string constr = ("Data Source=PC;Initial Catalog=AgencyDB;Integrated Security=True");
            SqlConnection connection = new SqlConnection(constr);
            return connection;

        }
        private void FillGrid(string search)
        {
            String sqlString = String.Format("SELECT * FROM Emmployees Where City='{0}'", search);
            SqlConnection conn = SQLConnection();
            SqlCommand comm = new SqlCommand(sqlString, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {

                    dt.Load(reader);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    //
                }
                reader.Close();
            }
            catch (SqlException ol)
            {
                MessageBox.Show(ol.Message.ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dt.Clear();
                dataGridView1.DataSource = dt;
            }
            string search = textBox1.Text;
            if (textBox1.Text.Length != 0)
            {
                FillGrid(search);
            }
            else
            {
                MessageBox.Show("Моля, въведете име на работник!");
            }
            dataGridView1.Visible = true;
        }

        private void SearchLocation_Load(object sender, EventArgs e)
        {

        }

    }
}
