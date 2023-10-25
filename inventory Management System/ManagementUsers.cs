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
    public partial class ManageUsers : Form
    {
        //int increment = 1;
        inventoryMSEntities1 db = new inventoryMSEntities1();
        //private object options;

        

        public ManageUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Users.ToList();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Blue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
            lbl_user.Text = inventory_Management_System.Users.Name;
            /*dataGridView1.DataSource = db.Users
                .OrderByDescending(x => x.Id)
                .Take(5)
                .Select(x => new {
                    x.Id,
                    x.UserName,
                    x.FullName,
                    x.Date,
                    x.Password

                })
                .ToList();*/
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            //Add new user
            try
            {
                if ((txtFname.Text != "") && (txtUname.Text != "") && (txtPass.Text != ""))
                {

                    if (txtId.Text == "")
                    {

                        u.FullName = txtFname.Text;
                        u.UserName = txtUname.Text;
                        u.Password = txtPass.Text;
                        u.Date = BrithDate.Value;
                        db.Users.Add(u);
                        db.SaveChanges();
                        MessageBox.Show("Add successfully");
                        clean();
                        update();
                    }
                    else
                    {
                        MessageBox.Show("Please Empty ID box");
                        txtId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the boxes");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        public void clean()
        {
            txtFname.Text = txtUname.Text = txtPass.Text = "";
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //Update user data
            try
            {
                if ((txtFname.Text != "") && (txtUname.Text != "") && (txtPass.Text != "") && (txtId.Text != ""))
                {
                    int id = int.Parse(txtId.Text);
                    User u = db.Users.Find(id);
                    if (u != null)
                    {
                        using (db)
                        {

                            u.UserName = txtUname.Text;
                            u.FullName = txtFname.Text;
                            u.Password = txtPass.Text;
                            u.Date = BrithDate.Value;
                            db.SaveChanges();
                        }
                        MessageBox.Show("Edit succeeded");

                    }
                    else
                    {
                        MessageBox.Show("please Enter correct ID");
                    }

                    update();
                }
                else
                {
                    MessageBox.Show("Please fill the boxes");
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
        public void update()
        {
            object options = null;
            db = new SampleDbContext(options);
            dataGridView1.DataSource = db.Users.ToList();
            
        }

        private void GetAllData()
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            dataGridView1.DataSource = db.Users.Where(x => x.FullName.Contains(text) || x.UserName.Contains(text)).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete user
            try
            {
                if (txtId.Text != "")
                {

                    int id = int.Parse(txtId.Text);
                    User u = db.Users.Find(id);
                    if (u != null)
                    {
                        using (db)
                        {

                            db.Users.Remove(u);
                            db.SaveChanges();
                        }
                        MessageBox.Show("Delete succeeded");

                    }
                    else
                    {
                        MessageBox.Show("please Enter correct ID");
                    }

                    update();
                }
                else
                {
                    MessageBox.Show("Please fill the boxes");
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource = db.Users
                .OrderByDescending(x => x.Id)
                .Skip(5 * increment)
                .Take(5)
                .Select(x => new{
                    x.Id, 
                    x.UserName,
                    x.FullName,
                    x.Date,
                    x.Password
                
                })
                .ToList();
            increment++;*/
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            /*increment--;
            dataGridView1.DataSource = db.Users
                .OrderByDescending(x => x.Id)
                .Skip(5 * increment)
                .Take(5)
                .Select(x => new {
                    x.Id,
                    x.UserName,
                    x.FullName,
                    x.Date,
                    x.Password

                })
                .ToList();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Close();
        }
    }
}
