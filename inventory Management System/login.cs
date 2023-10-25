using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_Management_System
{

    public partial class login : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        public login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = db.Users.FirstOrDefault(x => x.UserName == txtUser.Text && x.Password == txtPass.Text);
            if (user != null)
            {
                this.Close();

                Thread th = new Thread(OpenForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Users.Name = user.UserName;
                Users.id = user.Id;


            }
            else
            {
                MessageBox.Show("please Enter a correct values");
            }
        }
        void OpenForm()
        {
            Application.Run(new Main());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    static class Users
    {
        static public string Name { get; set; } 
        static public int id { get; set; }
    } 
}
