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
    public partial class OrdersDetials : Form
    {
        inventoryMSEntities1 db = new inventoryMSEntities1();
        public OrdersDetials()
        {
            
            InitializeComponent();
            dgvOrders.DataSource = db.Orders.Select(x => new { x.OrderId, x.Total, x.User.UserName, x.Customer.CustName }).ToList();
            lbl_user.Text = inventory_Management_System.Users.Name;
        }

        private void OrdersDetials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryMSDataSet6.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.inventoryMSDataSet6.Customers);
            // TODO: This line of code loads data into the 'inventoryMSDataSet5.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.inventoryMSDataSet5.Customers);

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dgvOrders.CurrentRow.Cells[0].Value.ToString());
            var bill = db.Orders.FirstOrDefault(x => x.OrderId == id);
            txtNum.Text = bill.OrderId.ToString();
            txtMS.Text = bill.MwstSumme.ToString();
            txtNetto.Text = bill.Netto.ToString();
            txtTotal.Text = bill.Total.ToString();
            dateTimePicker1.Value = (DateTime)bill.OrderDate;
            cmbCust.SelectedValue = bill.Customer.CustId;


            dgvODetails.Rows.Clear();
            foreach(var item in bill.OrderDetails)
            {

                dgvODetails.Rows.Add(item.ProductId, item.Product.ProdName ,item.Price, item.quantity, item.Total);
            }

        }

        private void dgvOrders_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            db.SaveChanges();
        }

        private void btnDelC_Click(object sender, EventArgs e)
        {
            if (txtCId.Text != "")
            {

                int id = int.Parse(txtCId.Text);
                Order O = db.Orders.Find(id);
                if (O != null)
                {
                    using (db)
                    {

                        db.Orders.Remove(O);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Delete succeeded");
                    txtCId.Text = "";

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
        public void update()
        {
            object options = null;
            db = new SampleDbContext(options);
            dgvOrders.DataSource = db.Orders.Select(x => new { x.OrderId, x.Total, x.User.UserName, x.Customer.CustName }).ToList();

        }
    }
}
