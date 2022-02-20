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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            new Forms.Login_Form().Show();
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            //Check empty fields
            if(txtName.Text == "" || txtEmail.Text == "" || txtNIC.Text == "" || txtAddress.Text == "" || txtUsername.Text == "" || txtContact.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                //Identify empty fields and print error
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNIC.Text == "")
                {
                    MessageBox.Show("NIC can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAddress.Text == "")
                {
                    MessageBox.Show("Address can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Username can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtContact.Text == "")
                {
                    MessageBox.Show("Contact Number can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Pssword can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtComPassword.Text == "")
                {
                    MessageBox.Show("Pssword confirmation can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtPassword.Text == txtComPassword.Text)
                {
                    ABCTraders.UsersDataTable username = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetByUsername(txtUsername.Text);
                    ABCTraders.UsersDataTable nic = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetbyNIC(txtNIC.Text);
                    ABCTraders.UsersDataTable mobile = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetByMobile(int.Parse(txtContact.Text));
                    if (username.Rows.Count != 0 || nic.Rows.Count != 0 || mobile.Rows.Count != 0)
                    {
                        if (username.Rows.Count != 0)
                        {
                            MessageBox.Show("This username already exists in our system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (nic.Rows.Count != 0)
                        {
                            MessageBox.Show("This nic already exists in our system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (mobile.Rows.Count != 0)
                        {
                            MessageBox.Show("This Contact Number already exists in our system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        new DataSet.ABCTradersTableAdapters.UsersTableAdapter().UserRegister(txtName.Text, txtUsername.Text, txtEmail.Text, int.Parse(txtContact.Text), txtNIC.Text, txtAddress.Text, "Customer", txtPassword.Text);
                        txtName.Text = "";
                        txtUsername.Text = "";
                        txtEmail.Text = "";
                        txtContact.Text = "";
                        txtNIC.Text = "";
                        txtAddress.Text = "";
                        txtPassword.Text = "";
                        txtComPassword.Text = "";
                        MessageBox.Show("Registration Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    
                    MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    txtPassword.Focus();
                }
            }

            
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtComPassword.PasswordChar = '•';
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }
    }
}
