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
    public partial class Products : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        

        public Products()
        {
            InitializeComponent();
            lbl_user.Text = inventory_Management_System.Users.Name;
            //Datashow on Grid
            dataGridView2.DataSource = db.Products.Select(x => new { x.ProdId,
                x.ProdName,
                x.ProdQty,
                x.ProdPrice,
                x.ProdDesc,
                x.Catogary.CatName }).ToList();
            //gridStyle
            this.dataGridView2.DefaultCellStyle.Font = new Font("Tahoma", 12);
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView2.DefaultCellStyle.BackColor = Color.White;
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMSDataSet.Catogaries' table. You can move, or remove it, as needed.
            this.catogariesTableAdapter.Fill(this.inventoryMSDataSet.Catogaries);

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            //Add new product
            Product P = new Product();
            try
            {


                if ((txtPname.Text != "") && (txtPQty.Text != "") && (txtPprice.Text != "") && (cmbCat.Text != ""))
                {


                    if (txtPId.Text == "")
                    {

                        P.ProdName = txtPname.Text;
                        P.ProdQty = int.Parse(txtPQty.Text);
                        P.ProdPrice = int.Parse(txtPprice.Text);
                        P.catId = int.Parse(cmbCat.SelectedValue.ToString());
                        P.ProdDesc = txtDesc.Text;
                        db.Products.Add(P);
                        db.SaveChanges();
                        MessageBox.Show("Add successfully");
                        clean();
                        update();



                    }
                    else
                    {
                        MessageBox.Show("Please Empty ID box");
                        //txtId.Text = "";
                    }
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
        public void clean()
        {
            txtPname.Text = txtPprice.Text = txtPQty.Text =  txtPId.Text = txtDesc.Text = "";
        }
        public void update()
        {
            object options = null;
            db = new SampleDbContext(options);
            dataGridView2.DataSource = db.Products.Select(x => new {x.ProdId, x.ProdName, x.ProdQty, x.ProdPrice, x.ProdDesc,x.Catogary.CatName}).ToList();
            
        }

        private void GetAllData()
        {
            throw new NotImplementedException();
        }

        private void btnRefr_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnEditP_Click(object sender, EventArgs e)
        {
            //Update product
            try
            {
                if ((txtPname.Text != "") && (txtPQty.Text != "") && (txtPprice.Text != "") && (cmbCat.Text != "") && (txtPId.Text != ""))
                {
                    int id = int.Parse(txtPId.Text);
                    Product P = db.Products.Find(id);
                    if (P != null)
                    {
                        using (db)
                        {

                            P.ProdName = txtPname.Text;
                            P.ProdQty = int.Parse(txtPQty.Text);
                            P.ProdPrice = int.Parse(txtPprice.Text);
                            P.catId = int.Parse(cmbCat.SelectedValue.ToString());
                            P.ProdDesc = txtDesc.Text;
                            db.SaveChanges();
                            clean();
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

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            //Delete product
            try
            {
                if (txtPId.Text != "")
                {

                    int id = int.Parse(txtPId.Text);
                    Product P = db.Products.Find(id);
                    if (P != null)
                    {
                        using (db)
                        {

                            db.Products.Remove(P);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            dataGridView2.DataSource = db.Products.Where(x => x.ProdName.Contains(text) || x.Catogary.CatName.Contains(text))
                .Select(x => new { x.ProdId, x.ProdName, x.ProdQty, x.ProdPrice, x.ProdDesc, x.Catogary.CatName }).ToList();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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
