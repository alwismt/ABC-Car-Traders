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
//using System.Runtime.InteropServices;

namespace ABC_traders.Forms
{
    public partial class AdminDashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public AdminDashboard()
        {
            InitializeComponent();
            random = new Random();
            //This one working
            lblUserName.Text = Global.Name;
            int count = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetData().Columns.Count;
            lblOrder.Text = count.ToString();

            int cuscount = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Customer").Columns.Count;
            lblUsers.Text = cuscount.ToString();
        }


        //This not working
        //private void AdminDashboard_Load(object sender, EventArgs e)
        //{
        //    lblUserName.Text = Global.Username;
        //}



        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(Class.ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Class.ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = Class.ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //currentButton.Font = new System.Draw.Font("Microsoft Sans Serif", 12.5 F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = Class.ThemeColor.ChangeColorBrightness(color, -0.3);
                    Class.ThemeColor.PrimaryColor = color;
                    Class.ThemeColor.SecondaryColor = Class.ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                    btn_close.BackColor = color;
                    btnMinimize.BackColor = color;
                    btnMaximize.BackColor = color;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    //previousBtn.Font = new System.Draw.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();

            lblTitle.Text = childForm.Text;
            childForm.Show();
        }



        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUser(),sender);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCars(), sender);
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CarParts(), sender);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ServicesForm(), sender);
        }
        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OrdersForm(), sender);
        }

        private void btnInq_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.ReportForm(), sender);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
           if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                //this.WindowState = FormWindowState.Maximized;
                this.btnMaximize.BackgroundImage = ABC_traders.Properties.Resources.restore_down_32px;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.btnMaximize.BackgroundImage = ABC_traders.Properties.Resources.maximize_button_32px;
            }
            
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Forms.Login_Form().Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblOrder_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
