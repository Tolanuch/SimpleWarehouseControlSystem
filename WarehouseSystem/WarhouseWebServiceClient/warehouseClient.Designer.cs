namespace WarhouseWebServiceClient
{
    partial class warehouseClientForm
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
            System.Windows.Forms.Label articleCodeLabel;
            System.Windows.Forms.Label deliveryWayLbl;
            System.Windows.Forms.Label articleAmountLbl;
            System.Windows.Forms.Label clientAddressLbl;
            System.Windows.Forms.Label clientSurnameLbl;
            System.Windows.Forms.Label clientNameLbl;
            System.Windows.Forms.Label dateLbl;
            this.availableArticlesDGV = new System.Windows.Forms.DataGridView();
            this.orderGrpBx = new System.Windows.Forms.GroupBox();
            this.deliveryWayTxtBx = new System.Windows.Forms.TextBox();
            this.clientAddressTxtBx = new System.Windows.Forms.TextBox();
            this.clientSurnameTxtBx = new System.Windows.Forms.TextBox();
            this.clientNameTxtBx = new System.Windows.Forms.TextBox();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.articleCodeCmbBx = new System.Windows.Forms.ComboBox();
            this.articleAmountTxtBx = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            articleCodeLabel = new System.Windows.Forms.Label();
            deliveryWayLbl = new System.Windows.Forms.Label();
            articleAmountLbl = new System.Windows.Forms.Label();
            clientAddressLbl = new System.Windows.Forms.Label();
            clientSurnameLbl = new System.Windows.Forms.Label();
            clientNameLbl = new System.Windows.Forms.Label();
            dateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.availableArticlesDGV)).BeginInit();
            this.orderGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableArticlesDGV
            // 
            this.availableArticlesDGV.AllowUserToAddRows = false;
            this.availableArticlesDGV.AllowUserToDeleteRows = false;
            this.availableArticlesDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.availableArticlesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableArticlesDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.availableArticlesDGV.Location = new System.Drawing.Point(0, 0);
            this.availableArticlesDGV.Name = "availableArticlesDGV";
            this.availableArticlesDGV.ReadOnly = true;
            this.availableArticlesDGV.Size = new System.Drawing.Size(367, 372);
            this.availableArticlesDGV.TabIndex = 0;
            // 
            // orderGrpBx
            // 
            this.orderGrpBx.Controls.Add(this.orderBtn);
            this.orderGrpBx.Controls.Add(this.deliveryWayTxtBx);
            this.orderGrpBx.Controls.Add(this.clientAddressTxtBx);
            this.orderGrpBx.Controls.Add(this.clientSurnameTxtBx);
            this.orderGrpBx.Controls.Add(this.clientNameTxtBx);
            this.orderGrpBx.Controls.Add(this.dateDTP);
            this.orderGrpBx.Controls.Add(this.articleCodeCmbBx);
            this.orderGrpBx.Controls.Add(articleCodeLabel);
            this.orderGrpBx.Controls.Add(deliveryWayLbl);
            this.orderGrpBx.Controls.Add(articleAmountLbl);
            this.orderGrpBx.Controls.Add(this.articleAmountTxtBx);
            this.orderGrpBx.Controls.Add(clientAddressLbl);
            this.orderGrpBx.Controls.Add(clientSurnameLbl);
            this.orderGrpBx.Controls.Add(clientNameLbl);
            this.orderGrpBx.Controls.Add(dateLbl);
            this.orderGrpBx.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderGrpBx.Location = new System.Drawing.Point(373, 0);
            this.orderGrpBx.Name = "orderGrpBx";
            this.orderGrpBx.Size = new System.Drawing.Size(318, 372);
            this.orderGrpBx.TabIndex = 1;
            this.orderGrpBx.TabStop = false;
            this.orderGrpBx.Text = "Create order";
            // 
            // deliveryWayTxtBx
            // 
            this.deliveryWayTxtBx.Location = new System.Drawing.Point(158, 203);
            this.deliveryWayTxtBx.Name = "deliveryWayTxtBx";
            this.deliveryWayTxtBx.Size = new System.Drawing.Size(148, 20);
            this.deliveryWayTxtBx.TabIndex = 32;
            // 
            // clientAddressTxtBx
            // 
            this.clientAddressTxtBx.Location = new System.Drawing.Point(158, 115);
            this.clientAddressTxtBx.Name = "clientAddressTxtBx";
            this.clientAddressTxtBx.Size = new System.Drawing.Size(148, 20);
            this.clientAddressTxtBx.TabIndex = 33;
            // 
            // clientSurnameTxtBx
            // 
            this.clientSurnameTxtBx.Location = new System.Drawing.Point(158, 87);
            this.clientSurnameTxtBx.Name = "clientSurnameTxtBx";
            this.clientSurnameTxtBx.Size = new System.Drawing.Size(148, 20);
            this.clientSurnameTxtBx.TabIndex = 34;
            // 
            // clientNameTxtBx
            // 
            this.clientNameTxtBx.Location = new System.Drawing.Point(158, 63);
            this.clientNameTxtBx.Name = "clientNameTxtBx";
            this.clientNameTxtBx.Size = new System.Drawing.Size(148, 20);
            this.clientNameTxtBx.TabIndex = 35;
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(106, 37);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(200, 20);
            this.dateDTP.TabIndex = 31;
            // 
            // articleCodeCmbBx
            // 
            this.articleCodeCmbBx.FormattingEnabled = true;
            this.articleCodeCmbBx.Location = new System.Drawing.Point(158, 143);
            this.articleCodeCmbBx.Name = "articleCodeCmbBx";
            this.articleCodeCmbBx.Size = new System.Drawing.Size(148, 21);
            this.articleCodeCmbBx.TabIndex = 30;
            // 
            // articleCodeLabel
            // 
            articleCodeLabel.AutoSize = true;
            articleCodeLabel.Location = new System.Drawing.Point(18, 148);
            articleCodeLabel.Name = "articleCodeLabel";
            articleCodeLabel.Size = new System.Drawing.Size(66, 13);
            articleCodeLabel.TabIndex = 29;
            articleCodeLabel.Text = "Article code:";
            // 
            // deliveryWayLbl
            // 
            deliveryWayLbl.AutoSize = true;
            deliveryWayLbl.Location = new System.Drawing.Point(17, 206);
            deliveryWayLbl.Name = "deliveryWayLbl";
            deliveryWayLbl.Size = new System.Drawing.Size(70, 13);
            deliveryWayLbl.TabIndex = 28;
            deliveryWayLbl.Text = "Delivery way:";
            // 
            // articleAmountLbl
            // 
            articleAmountLbl.AutoSize = true;
            articleAmountLbl.Location = new System.Drawing.Point(17, 174);
            articleAmountLbl.Name = "articleAmountLbl";
            articleAmountLbl.Size = new System.Drawing.Size(77, 13);
            articleAmountLbl.TabIndex = 26;
            articleAmountLbl.Text = "Article amount:";
            // 
            // articleAmountTxtBx
            // 
            this.articleAmountTxtBx.Location = new System.Drawing.Point(158, 171);
            this.articleAmountTxtBx.Name = "articleAmountTxtBx";
            this.articleAmountTxtBx.Size = new System.Drawing.Size(148, 20);
            this.articleAmountTxtBx.TabIndex = 27;
            // 
            // clientAddressLbl
            // 
            clientAddressLbl.AutoSize = true;
            clientAddressLbl.Location = new System.Drawing.Point(17, 119);
            clientAddressLbl.Name = "clientAddressLbl";
            clientAddressLbl.Size = new System.Drawing.Size(48, 13);
            clientAddressLbl.TabIndex = 25;
            clientAddressLbl.Text = "Address:";
            // 
            // clientSurnameLbl
            // 
            clientSurnameLbl.AutoSize = true;
            clientSurnameLbl.Location = new System.Drawing.Point(17, 94);
            clientSurnameLbl.Name = "clientSurnameLbl";
            clientSurnameLbl.Size = new System.Drawing.Size(52, 13);
            clientSurnameLbl.TabIndex = 24;
            clientSurnameLbl.Text = "Surname:";
            // 
            // clientNameLbl
            // 
            clientNameLbl.AutoSize = true;
            clientNameLbl.Location = new System.Drawing.Point(18, 69);
            clientNameLbl.Name = "clientNameLbl";
            clientNameLbl.Size = new System.Drawing.Size(38, 13);
            clientNameLbl.TabIndex = 23;
            clientNameLbl.Text = "Name:";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Location = new System.Drawing.Point(17, 44);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new System.Drawing.Size(33, 13);
            dateLbl.TabIndex = 22;
            dateLbl.Text = "Date:";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(207, 278);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(99, 30);
            this.orderBtn.TabIndex = 36;
            this.orderBtn.Text = "Save order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // warehouseClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 372);
            this.Controls.Add(this.orderGrpBx);
            this.Controls.Add(this.availableArticlesDGV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "warehouseClientForm";
            this.Text = "Warehouse client";
            this.Load += new System.EventHandler(this.warehouseClienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableArticlesDGV)).EndInit();
            this.orderGrpBx.ResumeLayout(false);
            this.orderGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView availableArticlesDGV;
        private System.Windows.Forms.GroupBox orderGrpBx;
        private System.Windows.Forms.TextBox deliveryWayTxtBx;
        private System.Windows.Forms.TextBox clientAddressTxtBx;
        private System.Windows.Forms.TextBox clientSurnameTxtBx;
        private System.Windows.Forms.TextBox clientNameTxtBx;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.ComboBox articleCodeCmbBx;
        private System.Windows.Forms.TextBox articleAmountTxtBx;
        private System.Windows.Forms.Button orderBtn;
    }
}

