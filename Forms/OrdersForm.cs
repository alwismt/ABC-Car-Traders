using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_traders.DataSet;

namespace ABC_traders.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            this.OrderGrid.RowHeaderMouseDoubleClick += OrderGrid_RowHeaderMouseDoubleClick;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            txtUName.Visible = false;
            txtUsername.Visible = false;
            txtEmail.Visible = false;
            txtContact.Visible = false;
            txtNIC.Visible = false;
            txtAddress.Visible = false;
            lblUName.Visible = false;
            lblUEmail.Visible = false;
            lblUAddress.Visible = false;
            lblUMobile.Visible = false;
            lblNIC.Visible = false;
            lbUUsername.Visible = false;

            btnOrder.Visible = false;
            lblOName.Visible = true;
            lblOPrice.Visible = true;
            lblOQnt.Visible = true;
            lblOSKU.Visible = true;
            lblOImage.Visible = true;
            lblORate.Visible = true;

            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;

            LoadOrders();

        }

        private void LoadOrders()
        {
            ABCTraders.OrdersDataTable sa = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetData();
            OrderGrid.DataSource = sa.DefaultView;
            OrderGrid.AutoGenerateColumns = false;

            OrderGrid.EnableHeadersVisualStyles = false;
            OrderGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            OrderGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            OrderGrid.RowTemplate.Height = 50;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadOrders();
                return;
            }
            else
            {
                bool isIntString = txtSearch.Text.All(char.IsDigit);
                ABCTraders.OrdersDataTable data = null;
                if (isIntString == true)
                {
                    data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetById(int.Parse(txtSearch.Text));

                }
                else
                {
                    data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType(txtSearch.Text);
                }
                OrderGrid.DataSource = data.DefaultView;
                OrderGrid.AutoGenerateColumns = false;
            }

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadOrders();
        }
        
        private void OrderGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.OrderGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["Id"].Value.ToString());

                ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetById(id);

                string type = data[0].ProType;
                int proid = data[0].ProId;
                int cusid = data[0].CusID;
                txtName.Text = data[0].ProName;

                txtRate.Text = data[0].Rate.ToString();
                txtQnt.Text = data[0].Qty.ToString();
                txtPrice.Text = data[0].Amount.ToString();


                if (type == "Car")
                {
                    ABCTraders.CarsDataTable car = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetById(proid);
                    txtSKU.Text = car[0].ModelID;
                    picProduct.ImageLocation = Global.ProjectPath + @"Resources\Car\" + car[0].Image;
                }
                else if (type == "Parts")
                {
                    ABCTraders.CarPartsDataTable part = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GeById(proid);
                    txtSKU.Text = part[0].PartID;
                    picProduct.ImageLocation = Global.ProjectPath + @"Resources\CarParts\" + part[0].Image;
                }
                else if (type == "Service")
                {

                }
                Order();
                ABCTraders.UsersDataTable user = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetDataByID(cusid);
                txtUName.Text = user[0].Name;
                txtUsername.Text = user[0].Username;
                txtEmail.Text = user[0].Email;
                txtContact.Text = user[0].Mobile.ToString();
                txtNIC.Text = user[0].NIC;
                txtAddress.Text = user[0].Address;

            }
            catch (Exception)
            {
                //throw;
                //return;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
            txtUName.Visible = true;
            txtUsername.Visible = true;
            txtEmail.Visible = true;
            txtContact.Visible = true;
            txtNIC.Visible = true;
            txtAddress.Visible = true;

            lblUName.Visible = true;
            lblUEmail.Visible = true;
            lblUAddress.Visible = true;
            lblUMobile.Visible = true;
            lblNIC.Visible = true;
            lbUUsername.Visible = true;
            
            lblOName.Visible = false;
            lblOPrice.Visible = false;
            lblOQnt.Visible = false;
            lblOSKU.Visible = false;
            lblOImage.Visible = false;
            lblORate.Visible = false;

            txtName.Visible = false;

            txtRate.Visible = false;
            txtQnt.Visible = false;
            txtPrice.Visible = false;
            txtSKU.Visible = false;
            picProduct.Visible = false;
            btnUser.Visible = false;
            btnOrder.Visible = true;

        }

        private void Order()
        {
            txtUName.Visible = false;
            txtUsername.Visible = false;
            txtEmail.Visible = false;
            txtContact.Visible = false;
            txtNIC.Visible = false;
            txtAddress.Visible = false;
            lblUName.Visible = false;
            lblUEmail.Visible = false;
            lblUAddress.Visible = false;
            lblUMobile.Visible = false;
            lblNIC.Visible = false;
            lbUUsername.Visible = false;
            btnOrder.Visible = false;

            lblOName.Visible = true;
            lblOPrice.Visible = true;
            lblOQnt.Visible = true;
            lblOSKU.Visible = true;
            lblOImage.Visible = true;
            lblORate.Visible = true;
            txtName.Visible = true;
            txtRate.Visible = true;
            txtQnt.Visible = true;
            txtPrice.Visible = true;
            txtSKU.Visible = true;
            picProduct.Visible = true;
            btnUser.Visible = true;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order();
        }
    }
}
