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
namespace ABC_traders.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            btnCar.BackColor = Class.ThemeColor.PrimaryColor;
            btnOrders.BackColor = Class.ThemeColor.PrimaryColor;
            btnServices.BackColor = Class.ThemeColor.PrimaryColor;
            btnParts.BackColor = Class.ThemeColor.PrimaryColor;
            btnCustomer.BackColor = Class.ThemeColor.PrimaryColor;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetData();
            ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


            for (int i = 0; i < data.Count; i++)
            {
                ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                ABCTraders.OrdersRow RecRow = null;
                RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                cr.ProId = RecRow.ProId;
                cr.OrderId = RecRow.OrderId;
                cr.ProName = RecRow.ProName;
                cr.ProType = RecRow.ProType;
                cr.Qty = RecRow.Qty;
                cr.Rate = RecRow.Rate;
                cr.CusID = RecRow.CusID;
                cr.Amount = RecRow.Amount;
                cr.OrderId = RecRow.OrderId;
                tb.Rows.Add(cr);
            }
            Orders myrpt = new Orders();
            myrpt.SetDataSource((DataTable)tb);
            crystalReportViewer1.ReportSource = myrpt;
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Car");
            ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


            for (int i = 0; i < data.Count; i++)
            {
                ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                ABCTraders.OrdersRow RecRow = null;
                RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                cr.ProId = RecRow.ProId;
                cr.OrderId = RecRow.OrderId;
                cr.ProName = RecRow.ProName;
                cr.ProType = RecRow.ProType;
                cr.Qty = RecRow.Qty;
                cr.Rate = RecRow.Rate;
                cr.CusID = RecRow.CusID;
                cr.Amount = RecRow.Amount;
                cr.OrderId = RecRow.OrderId;
                tb.Rows.Add(cr);
            }
            Orders myrpt = new Orders();
            myrpt.SetDataSource((DataTable)tb);
            crystalReportViewer1.ReportSource = myrpt;
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Parts");
            ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


            for (int i = 0; i < data.Count; i++)
            {
                ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                ABCTraders.OrdersRow RecRow = null;
                RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                cr.ProId = RecRow.ProId;
                cr.OrderId = RecRow.OrderId;
                cr.ProName = RecRow.ProName;
                cr.ProType = RecRow.ProType;
                cr.Qty = RecRow.Qty;
                cr.Rate = RecRow.Rate;
                cr.CusID = RecRow.CusID;
                cr.Amount = RecRow.Amount;
                cr.OrderId = RecRow.OrderId;
                tb.Rows.Add(cr);
            }
            Orders myrpt = new Orders();
            myrpt.SetDataSource((DataTable)tb);
            crystalReportViewer1.ReportSource = myrpt;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Service");
            ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


            for (int i = 0; i < data.Count; i++)
            {
                ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                ABCTraders.OrdersRow RecRow = null;
                RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                cr.ProId = RecRow.ProId;
                cr.OrderId = RecRow.OrderId;
                cr.ProName = RecRow.ProName;
                cr.ProType = RecRow.ProType;
                cr.Qty = RecRow.Qty;
                cr.Rate = RecRow.Rate;
                cr.CusID = RecRow.CusID;
                cr.Amount = RecRow.Amount;
                cr.OrderId = RecRow.OrderId;
                tb.Rows.Add(cr);
            }
            Orders myrpt = new Orders();
            myrpt.SetDataSource((DataTable)tb);
            crystalReportViewer1.ReportSource = myrpt;
        }
    }
}
