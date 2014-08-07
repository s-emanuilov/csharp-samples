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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void таблица1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories frm_g = new Categories();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void клиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers frm_g = new Customers();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void работнициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees frm_g = new Employees();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void детайлиЗаПоръчкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails frm_g = new OrderDetails();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void поръчкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders frm_g = new Orders();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void продуктиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products frm_g = new Products();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void изпращачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shippers frm_g = new Shippers();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void доставчициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers frm_g = new Suppliers();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForUs frm_g = new ForUs();
            frm_g.Show();
        }

        private void заявка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query1 frm_g = new Query1();
            frm_g.MdiParent = this;
            frm_g.Show();

        }

        private void заявка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query2 frm_g = new Query2();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void заявка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query3 frm_g = new Query3();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void заявка4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query4 frm_g = new Query4();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void справка1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 frm_g = new Report1();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void справка2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 frm_g = new Report2();
            frm_g.MdiParent = this;
            frm_g.Show();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справка3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchLocation frm_g = new SearchLocation();
            frm_g.MdiParent = this;
            frm_g.Show();
        }
    }
}
