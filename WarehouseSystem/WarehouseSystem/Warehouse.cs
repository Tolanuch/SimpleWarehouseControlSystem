using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WarehouseSystem
{
    public partial class Warehouse : Form
    {
        // Variables for SQL Queries.        
        SqlConnection sqlConnect;
        SqlCommand sqlCmd;
        SqlDataAdapter dataAdapter;

        public Warehouse()
        {
            InitializeComponent();
        }

        private void articlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articlesBS.EndEdit();
            this.updateAM.UpdateAll(this.dataSet);
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTA.Fill(this.dataSet.Orders);
            // TODO: This line of code loads data into the 'dataSet.Articles' table. You can move, or remove it, as needed.
            this.articlesTA.Fill(this.dataSet.Articles);

            // Initializing connection to sql server.
            sqlConnect = new SqlConnection(WarehouseSystem.Properties.Settings.Default.warehouse_dbConnectionString);
             try
            {
                sqlConnect.Open();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nPlease, check your connection to SQL Server");
            }
            finally
            {
                sqlConnect.Close();
            }

            sqlCmd = sqlConnect.CreateCommand();
            dataAdapter = new SqlDataAdapter();
        }

        // Saving order to the database.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();

            // Executing query to take articles amount.
            sqlCmd.CommandText = "Execute selectArticleAmount @code";

            sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCodeCmbBx.Text;
            
            sqlConnect.Open();
            dataAdapter.SelectCommand = sqlCmd;
            dataAdapter.Fill(dataTable);
            sqlConnect.Close();
            sqlCmd.Parameters.Clear();
            int haveAmount;
            haveAmount= Convert.ToInt32(dataTable.Rows[0][0]);

            dataTable.Clear();

            // Computing defference between ordered amount and what has warehouse.
            int diff = 0;
            diff = haveAmount - Convert.ToInt32(articleAmountTxtBx.Text);
            if (diff>=0)
            {
                // In case if warejouse has selected amount.
                sqlCmd.CommandText = "Execute updateArticleAmount @code, @amount";

                sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCodeCmbBx.Text;
                sqlCmd.Parameters.Add("@amount", SqlDbType.Int).Value = diff;

                sqlConnect.Open();
                dataAdapter.SelectCommand = sqlCmd;
                dataAdapter.Fill(dataTable);
                sqlConnect.Close();
                sqlCmd.Parameters.Clear();                               
            }
            else
            {
                MessageBox.Show("Warehouse does not have this amount of selected article.");
                return;
            }

            // Executing query to add entered order.
            sqlCmd.CommandText = "Execute insertOrder @date, @name, @surname, @address, @articlecode, @article_amount, @delivery_way";

            sqlCmd.Parameters.Add("@date", SqlDbType.Date).Value = dateDTP.Value.ToString();
            sqlCmd.Parameters.Add("@name", SqlDbType.NChar, 30).Value = clientNameTxtBx.Text;
            sqlCmd.Parameters.Add("@surname", SqlDbType.NChar, 30).Value = clientSurnameTxtBx.Text;
            sqlCmd.Parameters.Add("@address", SqlDbType.NChar, 40).Value = clientAddressTxtBx.Text;
            sqlCmd.Parameters.Add("@articlecode", SqlDbType.NChar, 10).Value = articleCodeCmbBx.Text;
            sqlCmd.Parameters.Add("article_amount", SqlDbType.Int).Value = articleAmountTxtBx.Text;
            sqlCmd.Parameters.Add("@delivery_way", SqlDbType.NChar, 20).Value = deliveryWayTxtBx.Text;

            sqlConnect.Open();
            sqlCmd.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCmd.Parameters.Clear();

            // Updating information in tables of application.
            ordersTA.Fill(dataSet.Orders);
            articlesTA.Fill(dataSet.Articles);
        }
        
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.articlesTA.Fill(this.dataSet.Articles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // Filling combobox with article code in order form.
        private void Warehouse_Shown(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            // Executing query to take articles code.
            sqlCmd.CommandText = "Execute selectArticlesCode";

            sqlConnect.Open();
            dataAdapter.SelectCommand = sqlCmd;
            dataAdapter.Fill(dataTable);
            sqlConnect.Close();

            articleCodeCmbBx.DataSource = dataTable;
            articleCodeCmbBx.DisplayMember = "code";
            articleCodeCmbBx.ValueMember = "Article code";
            articleCodeCmbBx.Text = "";

        }

        // Reseting order form.
        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            dateDTP.Value = DateTime.Now;
            clientNameTxtBx.Text = "";
            clientSurnameTxtBx.Text = "";
            clientAddressTxtBx.Text = "";
            articleAmountTxtBx.Text = "";
            deliveryWayTxtBx.Text = "";
        }
    }
}
