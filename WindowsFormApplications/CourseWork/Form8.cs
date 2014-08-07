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
    public partial class Shippers : Form
    {
        public Shippers()
        {
            InitializeComponent();
        }

        private void shippersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shippersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Shippers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.northwindDataSet.Shippers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
