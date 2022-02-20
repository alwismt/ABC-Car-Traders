using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_traders.DataSet;

namespace ABC_traders.Forms
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnDeleteCar.Visible = false;
            btnRestore.Visible = false;
            txtImageName.Visible = false;
            txtImageName.Enabled = false;
            txtCarId.Visible = false;
            txtCarId.Enabled = false;

            btnUpdate.BackColor = Class.ThemeColor.PrimaryColor;
            btnRestore.BackColor = Class.ThemeColor.PrimaryColor;
            btnAddCar.BackColor = Class.ThemeColor.PrimaryColor;
            btnClear.BackColor = Class.ThemeColor.PrimaryColor;
            btnDeleteCar.BackColor = Class.ThemeColor.SecondaryColor;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnSelectImage.BackColor = Class.ThemeColor.PrimaryColor;

            LoadCars();
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
            lblAddNewCar.Text = "Add New Car";
            picCar.Image = ABC_traders.Properties.Resources.carsketch;
            btnUpdate.Visible = false;
            btnDeleteCar.Visible = false;
            btnRestore.Visible = false;
            btnAddCar.Visible = true;
            btnClear.Visible = true;
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
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            string imageLocation = "";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageLocation = opnfd.FileName;
                    picCar.ImageLocation = imageLocation;
                    File.Copy(picCar.ImageLocation, Path.Combine(Global.ProjectPath + @"Resources\Car\", Path.GetFileName(picCar.ImageLocation)));
                    txtImageName.Text = Path.GetFileName(opnfd.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("The image already exit on the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtManufacturer.Text == "" || txtModelID.Text == "" || txtYear.Text == "" || txtFuel.Text == "" || txtColor.Text == "" || txtPrice.Text == "" || txtImageName.Text == "")
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Car Name field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtManufacturer.Text == "")
                {
                    MessageBox.Show("Car Manufacturer field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtModelID.Text == "")
                {
                    MessageBox.Show("This Car SKU Already have in our system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtYear.Text == "")
                {
                    MessageBox.Show("Car Manufacture Year field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtFuel.Text == "")
                {
                    MessageBox.Show("Car Fuel Type field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtColor.Text == "")
                {
                    MessageBox.Show("Car Color field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Car Price field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtImageName.Text == "")
                {
                    MessageBox.Show("Car Image field is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtName.Text;
                string mnfct = txtManufacturer.Text;
                int year = int.Parse(txtYear.Text);
                string fuel = txtFuel.Text;
                string color = txtColor.Text;
                int price = int.Parse(txtPrice.Text);
                string image = txtImageName.Text;
                string model = txtModelID.Text;
                try
                {
                    new DataSet.ABCTradersTableAdapters.CarsTableAdapter().AddNewCar(name, mnfct, year, fuel, color, image, price, model);
                    Restore();
                    MessageBox.Show("New Car Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Restore();
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
                btnUpdate.Visible = true;
                btnDeleteCar.Visible = true;
                btnRestore.Visible = true;
                btnAddCar.Visible = false;
                btnClear.Visible = false;
                lblAddNewCar.Text = "Update The Car";
            }
            catch (Exception)
            {

                //
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtManufacturer.Text == "" || txtYear.Text == "" || txtFuel.Text == "" || txtColor.Text == "" || txtPrice.Text == "" || txtImageName.Text == "")
            {
                //
            }
            else
            {
                int id = int.Parse(txtCarId.Text);
                string name = txtName.Text;
                string mnfct = txtManufacturer.Text;
                int year = int.Parse(txtYear.Text);
                string fuel = txtFuel.Text;
                string color = txtColor.Text;
                int price = int.Parse(txtPrice.Text);
                string image = txtImageName.Text;
                string model = txtModelID.Text;
                DialogResult dr = MessageBox.Show("Do you want update this Car record?.", "Update Car", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        new DataSet.ABCTradersTableAdapters.CarsTableAdapter().UpdateCar(name, mnfct, year,fuel, color, image, price, model, id);
                        MessageBox.Show("Car details updated successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Restore();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There are no car data saved on this ID! Please try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Restore();
                    }
                }

            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want delete this Car record?.", "Update Car", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtCarId.Text);
                new DataSet.ABCTradersTableAdapters.CarsTableAdapter().DeleteCar(id);
                MessageBox.Show("Car Deleted successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restore();
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
