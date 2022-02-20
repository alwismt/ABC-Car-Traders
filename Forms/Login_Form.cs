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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToRegisterForm_Click(object sender, EventArgs e)
        {
            //new frmRegister().Show();
            this.Hide();
            Forms.SplashScreen sp = new Forms.SplashScreen();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                new Forms.RegisterForm().Show();
            }

            //new Forms.RegisterForm().Show();
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //check fields are empty or not
            if (txtUsername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Username and Password fields can not be empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            //if both field filled proceed login checking
            else
            {
                string username = txtUsername.Text;
                string password = txtpassword.Text;
                //Check username and password with DB calling dataset
                ABCTraders.UsersDataTable tb = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().CheckLogin(username, password);
                if (tb.Count > 0)
                {
                    MessageBox.Show("Your are logged in successfully.", "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Global.UserID = tb[0].UserId.ToString();
                    Global.Username = tb[0].Username;
                    Global.Name = tb[0].Name;
                    Global.UserRole = tb[0].UserType;
                    //Check user role
                    if (tb[0].UserType == "Admin")
                    {
                        new Forms.AdminDashboard().Show();
                        this.Hide();
                    }
                    else if(tb[0].UserType == "Customer")
                    {
                        new Forms.UserDashboard().Show();
                        this.Hide();
                    }

                    txtUsername.Text = "";
                    txtpassword.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("UserName or Password is Incorrect.", "Incorrect Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                        
                
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }
    }
}
