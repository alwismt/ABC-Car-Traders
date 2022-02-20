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
    public partial class UserParts : Form
    {
        public UserParts()
        {
            InitializeComponent();
        }

        private void UserParts_Load(object sender, EventArgs e)
        {

            txtImageName.Visible = false;
            txtImageName.Enabled = false;
            txtId.Visible = false;
            txtId.Enabled = false;

            btnBuy.Visible = false;
            btnRestore.Visible = false;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnRestore.BackColor = Class.ThemeColor.PrimaryColor;
            btnBuy.BackColor = Class.ThemeColor.PrimaryColor;

            //lblAddNewPart.Text = "Add New Part";
            LoadParts();
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

        private void PartGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            
            btnBuy.Visible = true;
            btnRestore.Visible = true;
            txtQnt.Enabled = true;
            txtQnt.Text = "1";
        }

        private void Restore()
        {
            btnBuy.Visible = false;
            btnRestore.Visible = false;
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
            picPart.Image = ABC_traders.Properties.Resources.color_utilities;
            txtQnt.Enabled = true;
            LoadParts();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want Purchase this Part?.", "Purchase", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int cusid = int.Parse(Global.UserID);
                    string protype = "Parts";
                    int proid = int.Parse(txtId.Text);
                    string proname = txtName.Text;
                    int qty = int.Parse(txtQnt.Text);
                    int rate = int.Parse(txtPrice.Text);
                    int amount = qty * rate;
                    new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().AddOrder(cusid, protype, proid, proname, qty, rate, amount);
                    MessageBox.Show("Part purchase successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LoadParts();
                return;
            }
            else
            {
                ABCTraders.CarPartsDataTable data = null;
                string txt = txtSearch.Text;
                data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetByName(txt);
                if (data.Count == 0)
                {
                    data = new DataSet.ABCTradersTableAdapters.CarPartsTableAdapter().GetBySKU(txt);
                }

                PartGrid.DataSource = data.DefaultView;
                PartGrid.AutoGenerateColumns = false;
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadParts();
        }
    }
}
