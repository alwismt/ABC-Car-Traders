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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void txtProfile_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Class.ThemeColor.PrimaryColor;
            btnReset.BackColor = Class.ThemeColor.PrimaryColor;
            LoadProfile();
        }

        public void LoadProfile()
        {
            ABCTraders.UsersDataTable data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetDataByID(int.Parse(Global.UserID));
            if(data.Count == 0)
            {
                MessageBox.Show("The section undermaintain! Please contact support center. 0770061547", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtName.Text = data[0].Name;
                txtUsername.Text = data[0].Username;
                txtEmail.Text = data[0].Email;
                txtContact.Text = data[0].Mobile.ToString();
                txtNIC.Text = data[0].NIC;
                txtAddress.Text = data[0].Address;
                txtPassword.Text = data[0].Password;
                txtComPassword.Text = data[0].Password;
                txtUsername.Enabled = false;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "" || txtEmail.Text == "" || txtNIC.Text == "" || txtAddress.Text == "" || txtUsername.Text == "" || txtContact.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
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
                int id = int.Parse(Global.UserID);
                string name = txtName.Text;
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                int mobile = int.Parse(txtContact.Text);
                string nic = txtNIC.Text;
                string address = txtAddress.Text;
                string password = txtPassword.Text;
                string compassword = txtComPassword.Text;

                if (password == compassword)
                {
                    DialogResult dr = MessageBox.Show("Do you want update your profile data?.", "Update Profile", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            new DataSet.ABCTradersTableAdapters.UsersTableAdapter().ProfileUpdate(name,username, email, mobile, nic, address, password, id);
                            LoadProfile();
                            MessageBox.Show("Profile Update Successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something went Wrong, Please try again shotly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadProfile();
                        }
                    }
                }
                
            }
        }
    }
}
