using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WarehouseWWW
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection sqlConnect;
        SqlCommand sqlCmd;
        SqlDataAdapter dataAdapter;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initializing connection to sql server.
            sqlConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["warehouse_dbConnectionString"].ConnectionString);

            try
            {
                sqlConnect.Open();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + ex.Message + "\n\nPlease, check your connection to SQL Server')", true);
            }
            finally
            {
                sqlConnect.Close();
            }

            // Creating connection objects.
            sqlCmd = sqlConnect.CreateCommand();
            dataAdapter = new SqlDataAdapter();
        }

        // Make visible calendar on button click.
        protected void calenderImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            orderDateCal.Visible = true;
        }

        // Hide calender on selected date.
        protected void orderDateCal_SelectionChanged(object sender, EventArgs e)
        {
            orderDateCal.Visible = false;
        }

        // Creating record about order in database.
        protected void saveBtn_Click(object sender, EventArgs e)
        {
            // Check ordered amount article is number.
            try
            {
                int temp = Convert.ToInt32(articleAmountTxtBx.Text);
                if (temp<=0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please, check your amount field.')", true);
                    return;
                }
            }
            catch (FormatException)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please, check your amount field.')", true);
                return;
            }

            var dataTable = new DataTable();

            // Executing query to take articles amount.
            sqlCmd.CommandText = "Execute selectArticleAmount @code";

            sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCmbBx.Text;

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
            diff = haveAmount - Convert.ToInt32(articleAmountTxtBx.Text);
            if (diff >= 0)
            {
                // In case if warejouse has selected amount.
                sqlCmd.CommandText = "Execute updateArticleAmount @code, @amount";

                sqlCmd.Parameters.Add("@code", SqlDbType.NChar, 10).Value = articleCmbBx.Text;
                sqlCmd.Parameters.Add("@amount", SqlDbType.Int).Value = diff;

                sqlConnect.Open();
                dataAdapter.SelectCommand = sqlCmd;
                dataAdapter.Fill(dataTable);
                sqlConnect.Close();
                sqlCmd.Parameters.Clear();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Warehouse does not have this amount of selected article.')", true);
                return;
            }

            // Executing query to add entered order.
            sqlCmd.CommandText = "Execute insertOrder @date, @name, @surname, @address, @articlecode, @article_amount, @delivery_way";

            sqlCmd.Parameters.Add("@date", SqlDbType.Date).Value = orderDateCal.SelectedDate.ToString();
            sqlCmd.Parameters.Add("@name", SqlDbType.NChar, 30).Value = nameTxtBx.Text;
            sqlCmd.Parameters.Add("@surname", SqlDbType.NChar, 30).Value = surnameTxtBx.Text;
            sqlCmd.Parameters.Add("@address", SqlDbType.NChar, 40).Value = addressTxtBx.Text;
            sqlCmd.Parameters.Add("@articlecode", SqlDbType.NChar, 10).Value = articleCmbBx.Text;
            sqlCmd.Parameters.Add("article_amount", SqlDbType.Int).Value = articleAmountTxtBx.Text;
            sqlCmd.Parameters.Add("@delivery_way", SqlDbType.NChar, 20).Value = deliveryWayTxtBx.Text;

            sqlConnect.Open();
            sqlCmd.ExecuteNonQuery();
            sqlConnect.Close();
            sqlCmd.Parameters.Clear();
            
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Order added')", true);

            Response.Redirect("default.aspx");
        }
    }
}