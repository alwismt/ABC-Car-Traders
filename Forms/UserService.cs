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
    public partial class UserService : Form
    {
        public UserService()
        {
            InitializeComponent();

            this.ServiceGrid.RowHeaderMouseDoubleClick += ServiceGrid_RowHeaderMouseDoubleClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserService_Load(object sender, EventArgs e)
        {
            btnService.BackColor = Class.ThemeColor.PrimaryColor;
            btnClear.BackColor = Class.ThemeColor.PrimaryColor;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            ServiceLoad();

        }

        private void ServiceLoad()
        {
            ABCTraders.ServicesDataTable sa = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GetData();
            ServiceGrid.DataSource = sa.DefaultView;
            ServiceGrid.AutoGenerateColumns = false;

            ServiceGrid.EnableHeadersVisualStyles = false;
            ServiceGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            ServiceGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ServiceGrid.RowTemplate.Height = 50;
        }
        private void restore()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSKU.Text = "";
            txtTime.Text = "";
            txtPrice.Text = "";
            btnClear.Visible = true;
        }
        private void ServiceGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.ServiceGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                ABCTraders.ServicesDataTable data = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GeById(id);
                txtId.Text = data[0].SId.ToString();
                txtName.Text = data[0].Name;
                txtSKU.Text = data[0].SKU;
                txtTime.Text = data[0].Time;
                txtPrice.Text = data[0].Price.ToString();

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want Purchase this service?.", "Purchase", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Service purchase successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
