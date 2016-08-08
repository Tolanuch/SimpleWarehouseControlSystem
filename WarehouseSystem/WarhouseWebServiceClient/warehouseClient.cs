using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WarhouseWebServiceClient
{
    public partial class warehouseClientForm : Form
    {

        DataSet dataSet = new DataSet();
        serviceRfrnce.WarehouseSoapClient client = new serviceRfrnce.WarehouseSoapClient();

        public warehouseClientForm()
        {
            InitializeComponent();
        }

        // Retrieving information from database.
        private void retrieveInformation()
        {
            // Calling service method for loading article information.            
            dataSet = client.FindAvailableArticles();

            // Load retrieved information to table.
            availableArticlesDGV.AutoGenerateColumns = true;
            availableArticlesDGV.DataSource = dataSet;
            availableArticlesDGV.DataMember = dataSet.Tables[0].TableName;

            // Load code articles to combobox of order.
            articleCodeCmbBx.DataSource = dataSet.Tables[0];
            articleCodeCmbBx.DisplayMember = "Code";
        }

        private void warehouseClienForm_Load(object sender, EventArgs e)
        {
            retrieveInformation();
        }

        // Creating order in database.
        private void orderBtn_Click(object sender, EventArgs e)
        {
            // Check ordered amount article is number.
            try
            {
                int articleAmount = Convert.ToInt32(articleAmountTxtBx.Text);
                if (articleAmount <= 0)
                {
                    MessageBox.Show("Please, check your amount field.");
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message+"\n\nPlease, check your amount field.");
                return;
            }

            // Adding order.
            string msg;
            msg = client.CreateOrder(dateDTP.Value.ToString(), clientNameTxtBx.Text,clientSurnameTxtBx.Text, 
                                                             clientAddressTxtBx.Text,articleCodeCmbBx.Text,Convert.ToInt32(articleAmountTxtBx.Text),
                                                             deliveryWayTxtBx.Text);
            MessageBox.Show(msg);

            // Clearing fields.
            dateDTP.Value = DateTime.Now;
            clientNameTxtBx.Text = "";
            clientSurnameTxtBx.Text = "";
            clientAddressTxtBx.Text = "";
            articleCodeCmbBx.Text = "";
            articleAmountTxtBx.Text = "";
            deliveryWayTxtBx.Text = "";

            // Updating table of articles.
            retrieveInformation();
        }
    }
}
