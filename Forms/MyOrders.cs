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
    public partial class MyOrders : Form
    {
        public MyOrders()
        {
            InitializeComponent();
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            LoadOrders();
        }

        private void LoadOrders()
        {
            ABCTraders.OrdersDataTable sa = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetDataByCus(int.Parse(Global.UserID));
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
                txtName.Text = data[0].ProName;
                
                txtRate.Text = data[0].Rate.ToString();
                txtQnt.Text = data[0].Qty.ToString();
                txtPrice.Text = data[0].Amount.ToString();
                txtSts.Text = "Pending";


                if (type == "Car")
                {
                    ABCTraders.CarsDataTable car = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetById(proid);
                    txtSKU.Text = car[0].ModelID;
                    picProduct.ImageLocation = Global.ProjectPath + @"Resources\Car\" + car[0].Image;
                }
                else if(type == "Parts")
                {
                    ABCTraders.CarPartsDataTable part = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GeById(proid);
                    txtSKU.Text = part[0].PartID;
                    picProduct.ImageLocation = Global.ProjectPath + @"Resources\CarParts\" + part[0].Image;
                }
                else if (type == "Service")
                {

                }
                
            }
            catch (Exception)
            {
                //throw;
                //return;
            }
        }
    }
}
