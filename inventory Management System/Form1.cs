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
    public partial class Form1 : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        List<inventory_Management_System.Product> products;
        public Form1()
        {
            InitializeComponent();
            products = db.Products.ToList();
            imageList1.ImageSize = new Size(90, 40);
            lbl_user.Text = inventory_Management_System.Users.Name;


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMSDataSet4.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.inventoryMSDataSet4.Customers);
            // TODO: This line of code loads data into the 'inventoryMSDataSet3.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventoryMSDataSet3.Products);
            for (int i = 0; i < products.Count; i++)
            {
                Bitmap btm = new Bitmap(90, 40);
                imageList1.Images.Add(btm);

                ListViewItem item = new ListViewItem();
                item.Text = products[i].ProdName;
                item.ImageIndex = i;
                item.Tag = products[i];

                listView1.Items.Add(item);


            }

        }

        private void btnAddd_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var product = (inventory_Management_System.Product)listView1.SelectedItems[0].Tag;
                for (int i = 0; i < dgvItems.RowCount; i++)
                {
                    if (dgvItems.Rows[i].Cells["colID"].Value.ToString() == product.ProdId.ToString())
                    {
                        dgvItems.Rows[i].Cells["colQuantity"].Value = int.Parse(dgvItems.Rows[i].Cells["colQuantity"].Value.ToString()) + 1;
                        dgvItems.Rows[i].Cells["colTotal"].Value = int.Parse(dgvItems.Rows[i].Cells["colQuantity"].Value.ToString()) * decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString());
                        calcTotal();
                        return;
                    }
                }
                dgvItems.Rows.Add(product.ProdId, product.ProdName, 1, product.ProdPrice, product.ProdPrice * 1);
                calcTotal();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        void calcTotal()
        {
            decimal total=0;
            double n = 0.077;
            decimal Netto = 0;
            Netto = Convert.ToDecimal(n);

            for (int i = 0; i < dgvItems.RowCount; i++)
            {
                total += decimal.Parse(dgvItems.Rows[i].Cells["colTotal"].Value.ToString());
            }
            txtTotal.Text = total.ToString();
            txtNetto.Text = (total - (total*Netto)).ToString();
            txtMS.Text = (total - (total - (total * Netto))).ToString();



        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Order result = new Order()
                {
                    OrderDate = dateTimePicker1.Value.Date,
                    Total = decimal.Parse(txtTotal.Text),
                    MwstSumme = decimal.Parse(txtMS.Text),
                    Netto = decimal.Parse(txtNetto.Text),
                    CustomerId = int.Parse(cmbCust.SelectedValue.ToString()),
                    userId = inventory_Management_System.Users.id,

                };

                List<OrderDetail> list = new List<OrderDetail>();

                if (dgvItems.Rows.Count != 0 && dgvItems.Rows != null)
                {
                    for (int i = 0; i < dgvItems.RowCount; i++)
                    {

                        list.Add(new OrderDetail
                        {
                            ProductId = int.Parse(dgvItems.Rows[i].Cells["colID"].Value.ToString()),
                            quantity = int.Parse(dgvItems.Rows[i].Cells["colQuantity"].Value.ToString()),
                            Price = decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString()),
                            Total = int.Parse(dgvItems.Rows[i].Cells["colQuantity"].Value.ToString()) * decimal.Parse(dgvItems.Rows[i].Cells["colPrice"].Value.ToString()),
                        });
                    }
                    result.OrderDetails = list;

                    db.Orders.Add(result);
                    db.SaveChanges();

                    MessageBox.Show("Save Done");
                }
                else
                {
                    MessageBox.Show("No Pruduct chosen");
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcTotal();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersDetials bill = new OrdersDetials();
            bill.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Main M = new Main();
            M.Show();
            this.Close();
        }
    }
    
}

