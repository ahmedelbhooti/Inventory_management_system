using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            lbl_user.Text = inventory_Management_System.Users.Name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categaries Cat = new Categaries();
            Cat.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products P = new Products();
            P.Show();
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageUsers Users = new ManageUsers();
            Users.Show();
            //this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customers C = new Customers();
            C.Show();
        }
    }
}
