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
    public partial class CarParts : Form
    {
        public CarParts()
        {
            InitializeComponent();
        }

        private void CarParts_Load(object sender, EventArgs e)
        {
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnUpdate.Visible = false;

            txtImageName.Visible = false;
            txtImageName.Enabled = false;
            txtId.Visible = false;
            txtId.Enabled = false;
            
            btnUpdate.BackColor = Class.ThemeColor.PrimaryColor;
            btnRestore.BackColor = Class.ThemeColor.PrimaryColor;
            btnAddPart.BackColor = Class.ThemeColor.PrimaryColor;
            btnClear.BackColor = Class.ThemeColor.PrimaryColor;
            btnDeletePart.BackColor = Class.ThemeColor.SecondaryColor;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnSelectImage.BackColor = Class.ThemeColor.PrimaryColor;

            lblAddNewPart.Text = "Add New Part";
            LoadParts();

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
                    picPart.ImageLocation = imageLocation;
                    txtImageName.Text = Path.GetFileName(opnfd.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("The image already exit on the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        public void LoadParts()
        {
            ABCTraders.CarPartsDataTable sa = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetData();
            PartGrid.DataSource = sa.DefaultView;
            PartGrid.AutoGenerateColumns = false;

            PartGrid.EnableHeadersVisualStyles = false;
            PartGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            PartGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            PartGrid.RowTemplate.Height = 50;

        }



        private void Restore()
        {
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnUpdate.Visible = false;
            btnAddPart.Visible = true;
            btnClear.Visible = true;
            txtImageName.Visible = false;
            txtImageName.Enabled = false;
            txtId.Visible = false;
            txtId.Enabled = false;
            txtId.Text = "";
            txtName.Text = "";
            txtPartId.Text = "";
            txtBrand.Text = "";
            txtWarrenty.Text = "";
            txtPrice.Text = "";
            txtQnt.Text = "";
            txtImageName.Text = "";
            picPart.ImageLocation = "";
            lblAddNewPart.Text = "Add New Part";
            picPart.Image = ABC_traders.Properties.Resources.color_utilities;
            LoadParts();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPartId.Text == "" || txtBrand.Text == "" || txtWarrenty.Text == "" || txtPrice.Text == "" || txtQnt.Text == "" || txtImageName.Text == "")
            {
                MessageBox.Show("All fieds are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    File.Copy(picPart.ImageLocation, Path.Combine(Global.ProjectPath + @"Resources\CarParts\", Path.GetFileName(picPart.ImageLocation)));
                }
                catch (Exception)
                {
                    //Just ignore the error for, If image already exists use the that image
                }
                string name = txtName.Text;
                string partid = txtPartId.Text;
                string brand = txtBrand.Text;
                string wrnty = txtWarrenty.Text;
                string price = txtPrice.Text;
                string qnt = txtQnt.Text;
                string image = txtImageName.Text;
                try
                {
                    ABCTraders.CarPartsDataTable data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetBySKU(partid);
                    if(data.Count == 0)
                    {
                        new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().AddPart(name, partid, brand, wrnty, int.Parse(price), int.Parse(qnt), image);
                        Restore();
                        MessageBox.Show("New Part Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("This Part SKU already exits on the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPartId.Text = "";
            txtBrand.Text = "";
            txtWarrenty.Text = "";
            txtPrice.Text = "";
            txtQnt.Text = "";
            txtImageName.Text = "";
            picPart.Image = ABC_traders.Properties.Resources.color_utilities;
        }

        private void PartGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.PartGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                ABCTraders.CarPartsDataTable data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GeById(id);


                txtId.Text = data[0].Id.ToString();
                txtName.Text = data[0].PartName;
                txtPartId.Text = data[0].PartID;
                txtBrand.Text = data[0].Brand;
                txtWarrenty.Text = data[0].Warrenty;
                txtPrice.Text = data[0].Price.ToString();
                txtQnt.Text = data[0].Quantity.ToString();
                txtImageName.Text = data[0].Image;
                picPart.ImageLocation = Global.ProjectPath + @"Resources\CarParts\" + data[0].Image;
                btnUpdate.Visible = true;
                btnDeletePart.Visible = true;
                btnRestore.Visible = true;
                btnAddPart.Visible = false;
                btnClear.Visible = false;
                lblAddNewPart.Text = "Update The Part";
            }
            catch (Exception)
            {

                //
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPartId.Text == "" || txtBrand.Text == "" || txtWarrenty.Text == "" || txtPrice.Text == "" || txtQnt.Text == "" || txtImageName.Text == "")
            {
                MessageBox.Show("All fieds are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    File.Copy(picPart.ImageLocation, Path.Combine(Global.ProjectPath + @"Resources\CarParts\", Path.GetFileName(picPart.ImageLocation)));
                }
                catch (Exception)
                {
                    //Just ignore the error for, If image already exists use the that image
                }
                int id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string partid = txtPartId.Text;
                string brand = txtBrand.Text;
                string wrnty = txtWarrenty.Text;
                int price = int.Parse(txtPrice.Text);
                int qnt = int.Parse(txtQnt.Text);
                string image = txtImageName.Text;
                DialogResult dr = MessageBox.Show("Do you want update this Part record?.", "Update Car", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().UpdatePart(name, partid, brand, wrnty, price, qnt, image, id);
                        Restore();
                        MessageBox.Show("Part Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want delete this Part?.", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().DeletePart(id);
                MessageBox.Show("Car Deleted successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restore();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadParts();
                return;
            }
            else
            {
                ABCTraders.CarPartsDataTable data = null;
                string txt = txtSearch.Text;
                data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetByName(txt);
                if(data.Count == 0)
                {
                    data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetBySKU(txt);
                }

                PartGrid.DataSource = data.DefaultView;
                PartGrid.AutoGenerateColumns = false;
            }
        }

       

        private void btnClearFilter_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadParts();
        }
    }
}
