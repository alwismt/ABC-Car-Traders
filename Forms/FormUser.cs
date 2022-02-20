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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = Class.ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Class.ThemeColor.SecondaryColor;


                }
            }
        }

       

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtEmail.Text == "" || txtNIC.Text == "" || txtAddress.Text == "" || txtUsername.Text == "" || txtContact.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "" || listBoxUserType.Text == "")
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
                else if (listBoxUserType.Text == "")
                {
                    MessageBox.Show("User Type can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Pssword can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtComPassword.Text == "")
                {
                    MessageBox.Show("Pssword confirmation can not be empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //txtName.Focus();
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
                        try
                        {
                            new DataSet.ABCTradersTableAdapters.UsersTableAdapter().UserRegister(txtName.Text, txtUsername.Text, txtEmail.Text, int.Parse(txtContact.Text), txtNIC.Text, txtAddress.Text, listBoxUserType.Text, txtPassword.Text);
                            txtName.Text = "";
                            txtUsername.Text = "";
                            txtEmail.Text = "";
                            txtContact.Text = "";
                            txtNIC.Text = "";
                            txtAddress.Text = "";
                            listBoxUserType.Text = "";
                            txtPassword.Text = "";
                            txtComPassword.Text = "";
                            MessageBox.Show("Registration Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Loadcustomer();
                            txtName.Focus();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Something went wrong! Please try again shortly!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void FormUser_Load(object sender, EventArgs e)
        {
            Loadcustomer();
            btnAddUser.BackColor = Class.ThemeColor.PrimaryColor;
            btnClear.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnUpdate.BackColor = Class.ThemeColor.PrimaryColor;
            btnDelete.BackColor = Class.ThemeColor.SecondaryColor;
            btnReset.BackColor = Class.ThemeColor.PrimaryColor;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnReset.Visible = false;
        }

        public void Loadcustomer()
        {
            ABCTraders.UsersDataTable sa = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetData();
            CusGrid.DataSource = sa.DefaultView;
            CusGrid.AutoGenerateColumns = false;

            CusGrid.EnableHeadersVisualStyles = false;
            CusGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            CusGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CusGrid.RowTemplate.Height = 45;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Loadcustomer();
                return;
            }
            else
            {
                bool isIntString = txtSearch.Text.All(char.IsDigit);
                ABCTraders.UsersDataTable data = null;
                if (isIntString == true)
                {
                    data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetByMobile(int.Parse(txtSearch.Text));
                    
                }
                else
                {
                    data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetbyNIC(txtSearch.Text);
                    if (data.Count == 0)
                    {
                        data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetByUsername(txtSearch.Text);
                        if(data.Count == 0)
                        {
                            data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetByUserType(txtSearch.Text);
                        }
                        
                    }
                }
                CusGrid.DataSource = data.DefaultView;
                CusGrid.AutoGenerateColumns = false;
            }

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            Loadcustomer();
        }

        private void CusGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.CusGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());

                ABCTraders.UsersDataTable data = new DataSet.ABCTradersTableAdapters.UsersTableAdapter().GetDataByID(id);
                txtUserID.Text = data[0].UserId.ToString();
                txtName.Text = data[0].Name;
                txtUsername.Text = data[0].Username;
                txtEmail.Text = data[0].Email;
                txtContact.Text = data[0].Mobile.ToString();
                txtNIC.Text = data[0].NIC;
                txtAddress.Text = data[0].Address;
                listBoxUserType.Text = data[0].UserType;
                txtPassword.Text = data[0].Password;
                txtComPassword.Text = data[0].Password;

                txtUserID.Enabled = false;
                btnAddUser.Visible = false;
                btnClear.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnReset.Visible = true;

                lblAddNewUser.Text = "Update the User";
            }
            catch (Exception)
            {

                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtNIC.Text = "";
            txtAddress.Text = "";
            listBoxUserType.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtName.Focus();
        }

        private void Reset()
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtNIC.Text = "";
            txtAddress.Text = "";
            listBoxUserType.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtName.Focus();

            Loadcustomer();

            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnReset.Visible = false;
            btnAddUser.Visible = true;
            btnClear.Visible = true;
            lblAddNewUser.Text = "Add New User";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
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
                int id = int.Parse(txtUserID.Text);
                string name = txtName.Text;
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                int mobile = int.Parse(txtContact.Text);
                string nic = txtNIC.Text;
                string address = txtAddress.Text;
                string usertype = listBoxUserType.Text;
                string password = txtPassword.Text;
                string compassword = txtComPassword.Text;

                if (password == compassword)
                {
                    DialogResult dr = MessageBox.Show("Do you want update this user record?.", "Update user", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            new DataSet.ABCTradersTableAdapters.UsersTableAdapter().UpdateUser(name, username, email, mobile, nic, address, usertype, password, id);
                            MessageBox.Show("User Update Successfully!.", "Succefull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("There are no customer data saved on this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Reset();
                        }


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want delete this customer?.", "Delete Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                
                int id = int.Parse(txtUserID.Text);
                try
                {
                    new DataSet.ABCTradersTableAdapters.UsersTableAdapter().DeleteUser(id);
                    MessageBox.Show("Customer Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                catch (Exception)
                {

                    MessageBox.Show("There no customer data saved on this ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                }
                
            }
        }
    }
}
