using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Query3 : Form
    {
        public Query3()
        {
            InitializeComponent();
        }

        private void shippersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shippersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Query3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.northwindDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwindDataSet.Orders);
            // TODO: This line of code loads data into the 'northwindDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.northwindDataSet.Shippers);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            shipper_IDTextBox.Clear();
            company_NameTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
