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
    public partial class Customers : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        public Customers()
        {
            
            InitializeComponent();
            dataGridView3.DataSource = db.Customers.ToList();
            //gridStyle
            this.dataGridView3.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView3.DefaultCellStyle.BackColor = Color.White;
            lbl_user.Text = inventory_Management_System.Users.Name;
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            Customer C = new Customer();
            //Add new customer
            try
            {
                if (txtCname.Text != "")
                {

                    if (txtCId.Text == "")
                    {

                        C.CustName = txtCname.Text;
                        C.CustPhone = txtPhone.Text;
                        db.Customers.Add(C);
                        db.SaveChanges();
                        MessageBox.Show("Add successfully");
                        clean();
                        update();
                    }
                    else
                    {
                        MessageBox.Show("Please Empty ID box");
                        txtCId.Text = "";
                    }
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
        public void clean()
        {
            txtCname.Text = txtPhone.Text = txtCId.Text = "";
        }
        public void update()
        {
            object options = null;
            db = new SampleDbContext(options);
            dataGridView3.DataSource = db.Customers.ToList();

        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            //Update customer data
            try
            {
                if ((txtCname.Text != "") && (txtCId.Text != ""))
                {
                    int id = int.Parse(txtCId.Text);
                    Customer C = db.Customers.Find(id);
                    if (C != null)
                    {
                        using (db)
                        {

                            C.CustName = txtCname.Text;
                            C.CustPhone = txtPhone.Text;
                            db.SaveChanges();
                        }
                        MessageBox.Show("Edit succeeded");

                    }
                    else
                    {
                        MessageBox.Show("Please Enter correct ID");
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

        private void btnDelC_Click(object sender, EventArgs e)
        {
            //Delete customer
            try
            {
                if (txtCId.Text != "")
                {

                    int id = int.Parse(txtCId.Text);
                    Customer C = db.Customers.Find(id);
                    if (C != null)
                    {
                        using (db)
                        {

                            db.Customers.Remove(C);
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
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRefff_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            dataGridView3.DataSource = db.Customers.Where(x => x.CustName.Contains(text)).ToList();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
    
}
