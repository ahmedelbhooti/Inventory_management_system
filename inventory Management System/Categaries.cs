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
    public partial class Categaries : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        public Categaries()
        {
            
            InitializeComponent();
            dataGridView3.DataSource = db.Catogaries.ToList();
            //gridStyle
            this.dataGridView3.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView3.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView3.DefaultCellStyle.BackColor = Color.White;
            lbl_user.Text = inventory_Management_System.Users.Name;

        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            Catogary C = new Catogary();
            //Add new category
            try
            {
                if (txtCname.Text != "")
                {

                    if (txtCId.Text == "")
                    {

                        C.CatName = txtCname.Text;
                        db.Catogaries.Add(C);
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
            txtCname.Text = txtCId.Text = "";
        }
        public void update()
        {
            object options = null;
            db = new SampleDbContext(options);
            dataGridView3.DataSource = db.Catogaries.ToList();

        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            //Update Category data
            try
            {
                if ((txtCname.Text != "") && (txtCId.Text != ""))
                {
                    int id = int.Parse(txtCId.Text);
                    Catogary C = db.Catogaries.Find(id);
                    if (C != null)
                    {
                        using (db)
                        {

                            C.CatName = txtCname.Text;
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
            //Delete Category
            try
            {
                if (txtCId.Text != "")
                {

                    int id = int.Parse(txtCId.Text);
                    Catogary C = db.Catogaries.Find(id);
                    if (C != null)
                    {
                        using (db)
                        {

                            db.Catogaries.Remove(C);
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

        private void btnRefff_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            dataGridView3.DataSource = db.Catogaries.Where(x => x.CatName.Contains(text)).ToList();
        }

        private void Categaries_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHomee_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Close();
        }
    }
}
