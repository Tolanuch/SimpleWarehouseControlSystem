using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Configuration;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace WarehouseWebService
{
    /// <summary>
    /// Summary description for Warehouse
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Warehouse : System.Web.Services.WebService
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCmd;
        SqlDataAdapter dataAdapter;

        // Additional method to initialize connection to database.
        private void initializeConnect()
        {
            // Initializing connection to sql server.
            sqlConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["warehouse_dbConnectionString"].ConnectionString);

            try
            {
                sqlConnect.Open();
                sqlConnect.Close();
            }
            catch (Exception)
            {
                sqlConnect.Close();
                return;
            }
          
            // Creating connection objects.
            sqlCmd = sqlConnect.CreateCommand();
            dataAdapter = new SqlDataAdapter();
        }
       
        [WebMethod]
        // Creating order in database.
        public string CreateOrder(string date, string name, string surname, string address, string articleCode, int articleAmount, string deliveryWay)
        {
            // Checking for negative amount of articles.
            if (articleAmount <= 0)
                return "Error! Please, check your entered amount.";
            initializeConnect();

            var dataTable = new DataTable();

            // Executing query to take articles amount.
            sqlCmd.CommandText = "Execute selectArticleAmount @code";

            sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCode;

            sqlConnect.Open();
            dataAdapter.SelectCommand = sqlCmd;
            dataAdapter.Fill(dataTable);
            sqlConnect.Close();
            sqlCmd.Parameters.Clear();
            int haveAmount;
            haveAmount = Convert.ToInt32(dataTable.Rows[0][0]);

            dataTable.Clear();

            // Computing defference between ordered amount and what has warehouse.
            int diff = 0;
            diff = haveAmount - Convert.ToInt32(articleAmount);
            if (diff >= 0)
            {
                // In case if warejouse has selected amount.
                sqlCmd.CommandText = "Execute updateArticleAmount @code, @amount";

                sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCode;
                sqlCmd.Parameters.Add("@amount", SqlDbType.Int).Value = diff;

                sqlConnect.Open();
                dataAdapter.SelectCommand = sqlCmd;
                dataAdapter.Fill(dataTable);
                sqlConnect.Close();
                sqlCmd.Parameters.Clear();
            }
            else
            {                
                return "Warehouse does not have this amount of selected article.";
            }

            // Executing query to add entered order.
            sqlCmd.CommandText = "Execute insertOrder @date, @name, @surname, @address, @articlecode, @article_amount, @delivery_way";

            sqlCmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            sqlCmd.Parameters.Add("@name", SqlDbType.NChar, 30).Value = name;
            sqlCmd.Parameters.Add("@surname", SqlDbType.NChar, 30).Value = surname;
            sqlCmd.Parameters.Add("@address", SqlDbType.NChar, 40).Value = address;
            sqlCmd.Parameters.Add("@articlecode", SqlDbType.NChar, 10).Value = articleCode;
            sqlCmd.Parameters.Add("article_amount", SqlDbType.Int).Value = articleAmount;
            sqlCmd.Parameters.Add("@delivery_way", SqlDbType.NChar, 20).Value = deliveryWay;

            sqlConnect.Open();
            sqlCmd.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCmd.Parameters.Clear();

            return "Order successfully added";
        }

        [WebMethod]
        // Method to find available articles in warehouse.
        public DataSet FindAvailableArticles()
        {
            initializeConnect();

            // Creating sql command.
            sqlCmd.CommandText = "Execute collectAvailableArticles";

            var dataSet = new DataSet();
            sqlConnect.Open();
            dataAdapter.SelectCommand = sqlCmd;
            dataAdapter.Fill(dataSet);
            sqlConnect.Close();
            
            return dataSet;
        }

    }
}
