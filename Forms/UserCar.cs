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
    public partial class UserCar : Form
    {
        public UserCar()
        {
            InitializeComponent();
        }

        private void UserCar_Load(object sender, EventArgs e)
        {
            
            btnRestore.Visible = false;
            btnBuy.Visible = false;
            txtImageName.Visible = false;
            txtImageName.Enabled = false;
            txtCarId.Visible = false;
            txtCarId.Enabled = false;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnRestore.BackColor = Class.ThemeColor.PrimaryColor;
            btnBuy.BackColor = Class.ThemeColor.PrimaryColor;

            LoadCars();
        }

        public void LoadCars()
        {
            ABCTraders.CarsDataTable sa = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetData();
            CarGrid.DataSource = sa.DefaultView;
            CarGrid.AutoGenerateColumns = false;

            CarGrid.EnableHeadersVisualStyles = false;
            CarGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            CarGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CarGrid.RowTemplate.Height = 45;

        }

        private void CarGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.CarGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                ABCTraders.CarsDataTable data = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetById(id);
                txtCarId.Text = data[0].CarId.ToString();
                txtName.Text = data[0].CarName;
                txtManufacturer.Text = data[0].Manufacturer;
                txtModelID.Text = data[0].ModelID;
                txtYear.Text = data[0].ManufactureYear.ToString();
                txtFuel.Text = data[0].FuelType;
                txtColor.Text = data[0].Color;
                txtPrice.Text = data[0].Price.ToString();
                txtImageName.Text = data[0].Image;
                picCar.ImageLocation = Global.ProjectPath + @"Resources\Car\" + data[0].Image;
                btnRestore.Visible = true;
                btnBuy.Visible = true;
            }
            catch
            {
                //
            }
        }

        private void Restore()
        {
            txtName.Text = "";
            txtManufacturer.Text = "";
            txtYear.Text = "";
            txtFuel.Text = "";
            txtColor.Text = "";
            txtPrice.Text = "";
            txtImageName.Text = "";
            picCar.ImageLocation = "";
            txtModelID.Text = "";
            picCar.Image = ABC_traders.Properties.Resources.carsketch;
            btnBuy.Visible = false;
            btnRestore.Visible = false;
            LoadCars();
        }
        
        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            Restore();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want purchase this Car?.", "Purchases Car", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int cusid = int.Parse(Global.UserID);
                    string protype = "Car";
                    int proid = int.Parse(txtCarId.Text);
                    string proname = txtName.Text;
                    int qty = 1;
                    int rate = int.Parse(txtPrice.Text);
                    int amount = qty * rate;
                    new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().AddOrder(cusid, protype, proid, proname, qty, rate, amount);
                    MessageBox.Show("Car purchase successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restore();
                }
                catch (Exception)
                {
                    MessageBox.Show("There are no car data saved on this ID! Please Conatct Customer Care : 0770061547!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCars();
                return;
            }
            else
            {
                bool isIntString = txtSearch.Text.All(char.IsDigit);
                ABCTraders.CarsDataTable data = null;
                if (isIntString == true)
                {
                    data = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetbyYear(int.Parse(txtSearch.Text));

                }
                else
                {
                    data = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetByModel(txtSearch.Text);
                    if (data.Count == 0)
                    {
                        data = new DataSet.ABCTradersTableAdapters.CarsTableAdapter().GetByName(txtSearch.Text);
                    }
                }
                CarGrid.DataSource = data.DefaultView;
                CarGrid.AutoGenerateColumns = false;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadCars();
        }
    }
}
