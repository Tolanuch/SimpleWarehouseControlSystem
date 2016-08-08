namespace WarehouseSystem
{
    partial class Warehouse
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
            System.Windows.Forms.Label codeLbl;
            System.Windows.Forms.Label articleNameLbl;
            System.Windows.Forms.Label expiryDateLbl;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label amountLbl;
            System.Windows.Forms.Label dateLbl;
            System.Windows.Forms.Label clientNameLbl;
            System.Windows.Forms.Label clientSurnameLbl;
            System.Windows.Forms.Label clientAddressLbl;
            System.Windows.Forms.Label articleAmountLbl;
            System.Windows.Forms.Label deliveryWayLbl;
            System.Windows.Forms.Label articleCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse));
            this.dbTabControl = new System.Windows.Forms.TabControl();
            this.articlesTab = new System.Windows.Forms.TabPage();
            this.amountTxtBx = new System.Windows.Forms.TextBox();
            this.articlesBS = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new WarehouseSystem.dataSet();
            this.typeTxtBx = new System.Windows.Forms.TextBox();
            this.expiryDateDTP = new System.Windows.Forms.DateTimePicker();
            this.articleNameTxtBx = new System.Windows.Forms.TextBox();
            this.codeTxtBx = new System.Windows.Forms.TextBox();
            this.articlesBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.articlesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.articlesDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newOrderBtn = new System.Windows.Forms.Button();
            this.deliveryWayTxtBx = new System.Windows.Forms.TextBox();
            this.clientAddressTxtBx = new System.Windows.Forms.TextBox();
            this.clientSurnameTxtBx = new System.Windows.Forms.TextBox();
            this.clientNameTxtBx = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.articleCodeCmbBx = new System.Windows.Forms.ComboBox();
            this.articleAmountTxtBx = new System.Windows.Forms.TextBox();
            this.ordersBS = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articlesTA = new WarehouseSystem.dataSetTableAdapters.ArticlesTableAdapter();
            this.updateAM = new WarehouseSystem.dataSetTableAdapters.TableAdapterManager();
            this.ordersTA = new WarehouseSystem.dataSetTableAdapters.OrdersTableAdapter();
            codeLbl = new System.Windows.Forms.Label();
            articleNameLbl = new System.Windows.Forms.Label();
            expiryDateLbl = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            amountLbl = new System.Windows.Forms.Label();
            dateLbl = new System.Windows.Forms.Label();
            clientNameLbl = new System.Windows.Forms.Label();
            clientSurnameLbl = new System.Windows.Forms.Label();
            clientAddressLbl = new System.Windows.Forms.Label();
            articleAmountLbl = new System.Windows.Forms.Label();
            deliveryWayLbl = new System.Windows.Forms.Label();
            articleCodeLabel = new System.Windows.Forms.Label();
            this.dbTabControl.SuspendLayout();
            this.articlesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBN)).BeginInit();
            this.articlesBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDGV)).BeginInit();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLbl
            // 
            codeLbl.AutoSize = true;
            codeLbl.Location = new System.Drawing.Point(236, 263);
            codeLbl.Name = "codeLbl";
            codeLbl.Size = new System.Drawing.Size(35, 13);
            codeLbl.TabIndex = 4;
            codeLbl.Text = "Code:";
            // 
            // articleNameLbl
            // 
            articleNameLbl.AutoSize = true;
            articleNameLbl.Location = new System.Drawing.Point(236, 291);
            articleNameLbl.Name = "articleNameLbl";
            articleNameLbl.Size = new System.Drawing.Size(38, 13);
            articleNameLbl.TabIndex = 6;
            articleNameLbl.Text = "Name:";
            // 
            // expiryDateLbl
            // 
            expiryDateLbl.AutoSize = true;
            expiryDateLbl.Location = new System.Drawing.Point(236, 328);
            expiryDateLbl.Name = "expiryDateLbl";
            expiryDateLbl.Size = new System.Drawing.Size(108, 13);
            expiryDateLbl.TabIndex = 8;
            expiryDateLbl.Text = "Garantee expiry date:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(236, 362);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 10;
            typeLabel.Text = "Type:";
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Location = new System.Drawing.Point(236, 394);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new System.Drawing.Size(46, 13);
            amountLbl.TabIndex = 12;
            amountLbl.Text = "Amount:";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Location = new System.Drawing.Point(216, 247);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new System.Drawing.Size(33, 13);
            dateLbl.TabIndex = 1;
            dateLbl.Text = "Date:";
            // 
            // clientNameLbl
            // 
            clientNameLbl.AutoSize = true;
            clientNameLbl.Location = new System.Drawing.Point(217, 272);
            clientNameLbl.Name = "clientNameLbl";
            clientNameLbl.Size = new System.Drawing.Size(38, 13);
            clientNameLbl.TabIndex = 3;
            clientNameLbl.Text = "Name:";
            // 
            // clientSurnameLbl
            // 
            clientSurnameLbl.AutoSize = true;
            clientSurnameLbl.Location = new System.Drawing.Point(216, 297);
            clientSurnameLbl.Name = "clientSurnameLbl";
            clientSurnameLbl.Size = new System.Drawing.Size(52, 13);
            clientSurnameLbl.TabIndex = 5;
            clientSurnameLbl.Text = "Surname:";
            // 
            // clientAddressLbl
            // 
            clientAddressLbl.AutoSize = true;
            clientAddressLbl.Location = new System.Drawing.Point(216, 322);
            clientAddressLbl.Name = "clientAddressLbl";
            clientAddressLbl.Size = new System.Drawing.Size(48, 13);
            clientAddressLbl.TabIndex = 7;
            clientAddressLbl.Text = "Address:";
            // 
            // articleAmountLbl
            // 
            articleAmountLbl.AutoSize = true;
            articleAmountLbl.Location = new System.Drawing.Point(216, 377);
            articleAmountLbl.Name = "articleAmountLbl";
            articleAmountLbl.Size = new System.Drawing.Size(77, 13);
            articleAmountLbl.TabIndex = 11;
            articleAmountLbl.Text = "Article amount:";
            // 
            // deliveryWayLbl
            // 
            deliveryWayLbl.AutoSize = true;
            deliveryWayLbl.Location = new System.Drawing.Point(216, 409);
            deliveryWayLbl.Name = "deliveryWayLbl";
            deliveryWayLbl.Size = new System.Drawing.Size(70, 13);
            deliveryWayLbl.TabIndex = 13;
            deliveryWayLbl.Text = "Delivery way:";
            // 
            // articleCodeLabel
            // 
            articleCodeLabel.AutoSize = true;
            articleCodeLabel.Location = new System.Drawing.Point(217, 351);
            articleCodeLabel.Name = "articleCodeLabel";
            articleCodeLabel.Size = new System.Drawing.Size(66, 13);
            articleCodeLabel.TabIndex = 18;
            articleCodeLabel.Text = "Article code:";
            // 
            // dbTabControl
            // 
            this.dbTabControl.Controls.Add(this.articlesTab);
            this.dbTabControl.Controls.Add(this.ordersTab);
            this.dbTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTabControl.Location = new System.Drawing.Point(0, 0);
            this.dbTabControl.Name = "dbTabControl";
            this.dbTabControl.Padding = new System.Drawing.Point(100, 10);
            this.dbTabControl.SelectedIndex = 0;
            this.dbTabControl.Size = new System.Drawing.Size(880, 491);
            this.dbTabControl.TabIndex = 0;
            // 
            // articlesTab
            // 
            this.articlesTab.AutoScroll = true;
            this.articlesTab.Controls.Add(amountLbl);
            this.articlesTab.Controls.Add(this.amountTxtBx);
            this.articlesTab.Controls.Add(typeLabel);
            this.articlesTab.Controls.Add(this.typeTxtBx);
            this.articlesTab.Controls.Add(expiryDateLbl);
            this.articlesTab.Controls.Add(this.expiryDateDTP);
            this.articlesTab.Controls.Add(articleNameLbl);
            this.articlesTab.Controls.Add(this.articleNameTxtBx);
            this.articlesTab.Controls.Add(codeLbl);
            this.articlesTab.Controls.Add(this.codeTxtBx);
            this.articlesTab.Controls.Add(this.articlesBN);
            this.articlesTab.Controls.Add(this.articlesDGV);
            this.articlesTab.Location = new System.Drawing.Point(4, 36);
            this.articlesTab.Name = "articlesTab";
            this.articlesTab.Padding = new System.Windows.Forms.Padding(3);
            this.articlesTab.Size = new System.Drawing.Size(872, 451);
            this.articlesTab.TabIndex = 0;
            this.articlesTab.Text = "Articles";
            this.articlesTab.UseVisualStyleBackColor = true;
            // 
            // amountTxtBx
            // 
            this.amountTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articlesBS, "Amount", true));
            this.amountTxtBx.Location = new System.Drawing.Point(373, 391);
            this.amountTxtBx.Name = "amountTxtBx";
            this.amountTxtBx.Size = new System.Drawing.Size(195, 20);
            this.amountTxtBx.TabIndex = 13;
            // 
            // articlesBS
            // 
            this.articlesBS.DataMember = "Articles";
            this.articlesBS.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeTxtBx
            // 
            this.typeTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articlesBS, "Type", true));
            this.typeTxtBx.Location = new System.Drawing.Point(373, 355);
            this.typeTxtBx.Name = "typeTxtBx";
            this.typeTxtBx.Size = new System.Drawing.Size(195, 20);
            this.typeTxtBx.TabIndex = 11;
            // 
            // expiryDateDTP
            // 
            this.expiryDateDTP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.articlesBS, "Garantee_expiry_date", true));
            this.expiryDateDTP.Location = new System.Drawing.Point(373, 321);
            this.expiryDateDTP.Name = "expiryDateDTP";
            this.expiryDateDTP.Size = new System.Drawing.Size(195, 20);
            this.expiryDateDTP.TabIndex = 9;
            // 
            // articleNameTxtBx
            // 
            this.articleNameTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articlesBS, "Name", true));
            this.articleNameTxtBx.Location = new System.Drawing.Point(373, 292);
            this.articleNameTxtBx.Name = "articleNameTxtBx";
            this.articleNameTxtBx.Size = new System.Drawing.Size(195, 20);
            this.articleNameTxtBx.TabIndex = 7;
            // 
            // codeTxtBx
            // 
            this.codeTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articlesBS, "Code", true));
            this.codeTxtBx.Location = new System.Drawing.Point(373, 260);
            this.codeTxtBx.Name = "codeTxtBx";
            this.codeTxtBx.Size = new System.Drawing.Size(195, 20);
            this.codeTxtBx.TabIndex = 5;
            // 
            // articlesBN
            // 
            this.articlesBN.AddNewItem = this.bindingNavigatorAddNewItem;
            this.articlesBN.BindingSource = this.articlesBS;
            this.articlesBN.CountItem = this.bindingNavigatorCountItem;
            this.articlesBN.DeleteItem = this.bindingNavigatorDeleteItem;
            this.articlesBN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.articlesBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.articlesBindingNavigatorSaveItem});
            this.articlesBN.Location = new System.Drawing.Point(3, 423);
            this.articlesBN.MoveFirstItem = null;
            this.articlesBN.MoveLastItem = null;
            this.articlesBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.articlesBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.articlesBN.Name = "articlesBN";
            this.articlesBN.PositionItem = this.bindingNavigatorPositionItem;
            this.articlesBN.Size = new System.Drawing.Size(866, 25);
            this.articlesBN.TabIndex = 1;
            this.articlesBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // articlesBindingNavigatorSaveItem
            // 
            this.articlesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.articlesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("articlesBindingNavigatorSaveItem.Image")));
            this.articlesBindingNavigatorSaveItem.Name = "articlesBindingNavigatorSaveItem";
            this.articlesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.articlesBindingNavigatorSaveItem.Text = "Save Data";
            this.articlesBindingNavigatorSaveItem.Click += new System.EventHandler(this.articlesBindingNavigatorSaveItem_Click);
            // 
            // articlesDGV
            // 
            this.articlesDGV.AutoGenerateColumns = false;
            this.articlesDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.articlesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articlesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.articlesDGV.DataSource = this.articlesBS;
            this.articlesDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.articlesDGV.Location = new System.Drawing.Point(3, 3);
            this.articlesDGV.Name = "articlesDGV";
            this.articlesDGV.Size = new System.Drawing.Size(866, 242);
            this.articlesDGV.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Garantee_expiry_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Garantee_expiry_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ordersTab
            // 
            this.ordersTab.AutoScroll = true;
            this.ordersTab.Controls.Add(this.saveBtn);
            this.ordersTab.Controls.Add(this.newOrderBtn);
            this.ordersTab.Controls.Add(this.deliveryWayTxtBx);
            this.ordersTab.Controls.Add(this.clientAddressTxtBx);
            this.ordersTab.Controls.Add(this.clientSurnameTxtBx);
            this.ordersTab.Controls.Add(this.clientNameTxtBx);
            this.ordersTab.Controls.Add(this.dateDTP);
            this.ordersTab.Controls.Add(this.articleCodeCmbBx);
            this.ordersTab.Controls.Add(articleCodeLabel);
            this.ordersTab.Controls.Add(deliveryWayLbl);
            this.ordersTab.Controls.Add(articleAmountLbl);
            this.ordersTab.Controls.Add(this.articleAmountTxtBx);
            this.ordersTab.Controls.Add(clientAddressLbl);
            this.ordersTab.Controls.Add(clientSurnameLbl);
            this.ordersTab.Controls.Add(clientNameLbl);
            this.ordersTab.Controls.Add(dateLbl);
            this.ordersTab.Controls.Add(this.ordersDGV);
            this.ordersTab.Location = new System.Drawing.Point(4, 36);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(872, 451);
            this.ordersTab.TabIndex = 1;
            this.ordersTab.Text = "Orders";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(559, 403);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 20);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.Location = new System.Drawing.Point(559, 372);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(85, 20);
            this.newOrderBtn.TabIndex = 22;
            this.newOrderBtn.Text = "Create";
            this.newOrderBtn.UseVisualStyleBackColor = true;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // deliveryWayTxtBx
            // 
            this.deliveryWayTxtBx.Location = new System.Drawing.Point(305, 406);
            this.deliveryWayTxtBx.Name = "deliveryWayTxtBx";
            this.deliveryWayTxtBx.Size = new System.Drawing.Size(200, 20);
            this.deliveryWayTxtBx.TabIndex = 21;
            // 
            // clientAddressTxtBx
            // 
            this.clientAddressTxtBx.Location = new System.Drawing.Point(305, 318);
            this.clientAddressTxtBx.Name = "clientAddressTxtBx";
            this.clientAddressTxtBx.Size = new System.Drawing.Size(200, 20);
            this.clientAddressTxtBx.TabIndex = 21;
            // 
            // clientSurnameTxtBx
            // 
            this.clientSurnameTxtBx.Location = new System.Drawing.Point(305, 290);
            this.clientSurnameTxtBx.Name = "clientSurnameTxtBx";
            this.clientSurnameTxtBx.Size = new System.Drawing.Size(200, 20);
            this.clientSurnameTxtBx.TabIndex = 21;
            // 
            // clientNameTxtBx
            // 
            this.clientNameTxtBx.Location = new System.Drawing.Point(305, 266);
            this.clientNameTxtBx.Name = "clientNameTxtBx";
            this.clientNameTxtBx.Size = new System.Drawing.Size(200, 20);
            this.clientNameTxtBx.TabIndex = 21;
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(305, 240);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(200, 20);
            this.dateDTP.TabIndex = 20;
            // 
            // articleCodeCmbBx
            // 
            this.articleCodeCmbBx.FormattingEnabled = true;
            this.articleCodeCmbBx.Location = new System.Drawing.Point(305, 348);
            this.articleCodeCmbBx.Name = "articleCodeCmbBx";
            this.articleCodeCmbBx.Size = new System.Drawing.Size(200, 21);
            this.articleCodeCmbBx.TabIndex = 19;
            // 
            // articleAmountTxtBx
            // 
            this.articleAmountTxtBx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBS, "Article_amount", true));
            this.articleAmountTxtBx.Location = new System.Drawing.Point(305, 374);
            this.articleAmountTxtBx.Name = "articleAmountTxtBx";
            this.articleAmountTxtBx.Size = new System.Drawing.Size(200, 20);
            this.articleAmountTxtBx.TabIndex = 12;
            // 
            // ordersBS
            // 
            this.ordersBS.DataMember = "Orders";
            this.ordersBS.DataSource = this.dataSet;
            // 
            // ordersDGV
            // 
            this.ordersDGV.AutoGenerateColumns = false;
            this.ordersDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.ordersDGV.DataSource = this.ordersBS;
            this.ordersDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersDGV.Location = new System.Drawing.Point(3, 3);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.ReadOnly = true;
            this.ordersDGV.Size = new System.Drawing.Size(866, 220);
            this.ordersDGV.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ArticleID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ArticleID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Article_amount";
            this.dataGridViewTextBoxColumn13.HeaderText = "Article_amount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Delivery_way";
            this.dataGridViewTextBoxColumn14.HeaderText = "Delivery_way";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // articlesTA
            // 
            this.articlesTA.ClearBeforeFill = true;
            // 
            // updateAM
            // 
            this.updateAM.ArticlesTableAdapter = this.articlesTA;
            this.updateAM.BackupDataSetBeforeUpdate = false;
            this.updateAM.OrdersTableAdapter = this.ordersTA;
            this.updateAM.UpdateOrder = WarehouseSystem.dataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersTA
            // 
            this.ordersTA.ClearBeforeFill = true;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.Controls.Add(this.dbTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.Shown += new System.EventHandler(this.Warehouse_Shown);
            this.dbTabControl.ResumeLayout(false);
            this.articlesTab.ResumeLayout(false);
            this.articlesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBN)).EndInit();
            this.articlesBN.ResumeLayout(false);
            this.articlesBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articlesDGV)).EndInit();
            this.ordersTab.ResumeLayout(false);
            this.ordersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dbTabControl;
        private System.Windows.Forms.TabPage articlesTab;
        private System.Windows.Forms.TabPage ordersTab;
        private dataSet dataSet;
        private System.Windows.Forms.BindingSource articlesBS;
        private dataSetTableAdapters.ArticlesTableAdapter articlesTA;
        private dataSetTableAdapters.TableAdapterManager updateAM;
        private System.Windows.Forms.BindingNavigator articlesBN;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton articlesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView articlesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource ordersBS;
        private dataSetTableAdapters.OrdersTableAdapter ordersTA;
        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox amountTxtBx;
        private System.Windows.Forms.TextBox typeTxtBx;
        private System.Windows.Forms.DateTimePicker expiryDateDTP;
        private System.Windows.Forms.TextBox articleNameTxtBx;
        private System.Windows.Forms.TextBox codeTxtBx;
        private System.Windows.Forms.TextBox articleAmountTxtBx;
        private System.Windows.Forms.ComboBox articleCodeCmbBx;
        private System.Windows.Forms.TextBox deliveryWayTxtBx;
        private System.Windows.Forms.TextBox clientAddressTxtBx;
        private System.Windows.Forms.TextBox clientSurnameTxtBx;
        private System.Windows.Forms.TextBox clientNameTxtBx;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newOrderBtn;
    }
}

