
namespace ABC_traders.Forms
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblORate = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblOSKU = new System.Windows.Forms.Label();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.lblOImage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOQnt = new System.Windows.Forms.Label();
            this.lblOName = new System.Windows.Forms.Label();
            this.lblAddNewPart = new System.Windows.Forms.Label();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.aBCTraders = new ABC_traders.DataSet.ABCTraders();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.OrdersTableAdapter();
            this.btnUser = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblUMobile = new System.Windows.Forms.Label();
            this.lblUAddress = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.lbUUsername = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblUMobile);
            this.panel1.Controls.Add(this.lblUAddress);
            this.panel1.Controls.Add(this.txtNIC);
            this.panel1.Controls.Add(this.lblNIC);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblUEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtUName);
            this.panel1.Controls.Add(this.lbUUsername);
            this.panel1.Controls.Add(this.lblUName);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.lblORate);
            this.panel1.Controls.Add(this.picProduct);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblOPrice);
            this.panel1.Controls.Add(this.txtSKU);
            this.panel1.Controls.Add(this.lblOSKU);
            this.panel1.Controls.Add(this.txtQnt);
            this.panel1.Controls.Add(this.lblOImage);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblOQnt);
            this.panel1.Controls.Add(this.lblOName);
            this.panel1.Controls.Add(this.lblAddNewPart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 592);
            this.panel1.TabIndex = 0;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(141, 225);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(190, 28);
            this.txtRate.TabIndex = 116;
            // 
            // lblORate
            // 
            this.lblORate.AutoSize = true;
            this.lblORate.Location = new System.Drawing.Point(19, 233);
            this.lblORate.Name = "lblORate";
            this.lblORate.Size = new System.Drawing.Size(38, 17);
            this.lblORate.TabIndex = 117;
            this.lblORate.Text = "Rate";
            // 
            // picProduct
            // 
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.Location = new System.Drawing.Point(144, 393);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(187, 97);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 115;
            this.picProduct.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(141, 326);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 28);
            this.txtPrice.TabIndex = 108;
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Location = new System.Drawing.Point(19, 334);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(40, 17);
            this.lblOPrice.TabIndex = 114;
            this.lblOPrice.Text = "Price";
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSKU.Enabled = false;
            this.txtSKU.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.Location = new System.Drawing.Point(141, 167);
            this.txtSKU.Multiline = true;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(190, 28);
            this.txtSKU.TabIndex = 107;
            // 
            // lblOSKU
            // 
            this.lblOSKU.AutoSize = true;
            this.lblOSKU.Location = new System.Drawing.Point(18, 167);
            this.lblOSKU.Name = "lblOSKU";
            this.lblOSKU.Size = new System.Drawing.Size(89, 17);
            this.lblOSKU.TabIndex = 113;
            this.lblOSKU.Text = "Product SKU";
            // 
            // txtQnt
            // 
            this.txtQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtQnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQnt.Enabled = false;
            this.txtQnt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQnt.Location = new System.Drawing.Point(141, 273);
            this.txtQnt.Multiline = true;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(190, 28);
            this.txtQnt.TabIndex = 109;
            // 
            // lblOImage
            // 
            this.lblOImage.AutoSize = true;
            this.lblOImage.Location = new System.Drawing.Point(18, 393);
            this.lblOImage.Name = "lblOImage";
            this.lblOImage.Size = new System.Drawing.Size(99, 17);
            this.lblOImage.TabIndex = 111;
            this.lblOImage.Text = "Product Image";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(141, 107);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 28);
            this.txtName.TabIndex = 106;
            // 
            // lblOQnt
            // 
            this.lblOQnt.AutoSize = true;
            this.lblOQnt.Location = new System.Drawing.Point(19, 281);
            this.lblOQnt.Name = "lblOQnt";
            this.lblOQnt.Size = new System.Drawing.Size(61, 17);
            this.lblOQnt.TabIndex = 110;
            this.lblOQnt.Text = "Quantity";
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(18, 115);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(98, 17);
            this.lblOName.TabIndex = 112;
            this.lblOName.Text = "Product Name";
            // 
            // lblAddNewPart
            // 
            this.lblAddNewPart.AutoSize = true;
            this.lblAddNewPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPart.Location = new System.Drawing.Point(88, 43);
            this.lblAddNewPart.Name = "lblAddNewPart";
            this.lblAddNewPart.Size = new System.Drawing.Size(132, 24);
            this.lblAddNewPart.TabIndex = 105;
            this.lblAddNewPart.Text = "Order Details";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(973, 45);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(104, 32);
            this.btnClearFilter.TabIndex = 34;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(916, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 32);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(358, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(309, 24);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search by Order Id or Product Type";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(684, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 29);
            this.txtSearch.TabIndex = 32;
            // 
            // OrderGrid
            // 
            this.OrderGrid.AutoGenerateColumns = false;
            this.OrderGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.proTypeDataGridViewTextBoxColumn,
            this.ProID,
            this.proNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.OrderGrid.DataSource = this.ordersBindingSource;
            this.OrderGrid.GridColor = System.Drawing.Color.LightGray;
            this.OrderGrid.Location = new System.Drawing.Point(361, 126);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.Size = new System.Drawing.Size(758, 381);
            this.OrderGrid.TabIndex = 30;
            // 
            // aBCTraders
            // 
            this.aBCTraders.DataSetName = "ABCTraders";
            this.aBCTraders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.aBCTraders;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(22, 546);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(309, 43);
            this.btnUser.TabIndex = 118;
            this.btnUser.Text = "Show Customer";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(145, 360);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(186, 28);
            this.txtContact.TabIndex = 124;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(145, 256);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 28);
            this.txtAddress.TabIndex = 122;
            // 
            // lblUMobile
            // 
            this.lblUMobile.AutoSize = true;
            this.lblUMobile.Location = new System.Drawing.Point(20, 360);
            this.lblUMobile.Name = "lblUMobile";
            this.lblUMobile.Size = new System.Drawing.Size(110, 17);
            this.lblUMobile.TabIndex = 126;
            this.lblUMobile.Text = "Contact Number";
            // 
            // lblUAddress
            // 
            this.lblUAddress.AutoSize = true;
            this.lblUAddress.Location = new System.Drawing.Point(21, 261);
            this.lblUAddress.Name = "lblUAddress";
            this.lblUAddress.Size = new System.Drawing.Size(60, 17);
            this.lblUAddress.TabIndex = 130;
            this.lblUAddress.Text = "Address";
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIC.Enabled = false;
            this.txtNIC.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(146, 207);
            this.txtNIC.Multiline = true;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(185, 28);
            this.txtNIC.TabIndex = 121;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(21, 216);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(30, 17);
            this.lblNIC.TabIndex = 129;
            this.lblNIC.Text = "NIC";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(145, 159);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 28);
            this.txtEmail.TabIndex = 120;
            // 
            // lblUEmail
            // 
            this.lblUEmail.AutoSize = true;
            this.lblUEmail.Location = new System.Drawing.Point(21, 161);
            this.lblUEmail.Name = "lblUEmail";
            this.lblUEmail.Size = new System.Drawing.Size(42, 17);
            this.lblUEmail.TabIndex = 128;
            this.lblUEmail.Text = "Email";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(145, 306);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 28);
            this.txtUsername.TabIndex = 123;
            // 
            // txtUName
            // 
            this.txtUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUName.Enabled = false;
            this.txtUName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(145, 115);
            this.txtUName.Multiline = true;
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(186, 28);
            this.txtUName.TabIndex = 119;
            // 
            // lbUUsername
            // 
            this.lbUUsername.AutoSize = true;
            this.lbUUsername.Location = new System.Drawing.Point(21, 306);
            this.lbUUsername.Name = "lbUUsername";
            this.lbUUsername.Size = new System.Drawing.Size(73, 17);
            this.lbUUsername.TabIndex = 125;
            this.lbUUsername.Text = "Username";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(21, 115);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(45, 17);
            this.lblUName.TabIndex = 127;
            this.lblUName.Text = "Name";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(24, 546);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(309, 43);
            this.btnOrder.TabIndex = 131;
            this.btnOrder.Text = "Show Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "OrderId";
            this.Id.HeaderText = "Order Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // proTypeDataGridViewTextBoxColumn
            // 
            this.proTypeDataGridViewTextBoxColumn.DataPropertyName = "ProType";
            this.proTypeDataGridViewTextBoxColumn.HeaderText = "Product Type";
            this.proTypeDataGridViewTextBoxColumn.Name = "proTypeDataGridViewTextBoxColumn";
            this.proTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.proTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ProID
            // 
            this.ProID.DataPropertyName = "ProId";
            this.ProID.HeaderText = "Pro Id";
            this.ProID.Name = "ProID";
            this.ProID.ReadOnly = true;
            this.ProID.Visible = false;
            // 
            // proNameDataGridViewTextBoxColumn
            // 
            this.proNameDataGridViewTextBoxColumn.DataPropertyName = "ProName";
            this.proNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.proNameDataGridViewTextBoxColumn.Name = "proNameDataGridViewTextBoxColumn";
            this.proNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.proNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 592);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrdersForm";
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblORate;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblOSKU;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.Label lblOImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOQnt;
        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblAddNewPart;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView OrderGrid;
        private DataSet.ABCTraders aBCTraders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet.ABCTradersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblUMobile;
        private System.Windows.Forms.Label lblUAddress;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lbUUsername;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}