using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace JuiceOasis
{
    public partial class EditJuice : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int juiceID = Convert.ToInt32(Request.QueryString["JuiceID"]);
                LoadJuiceDetails(juiceID);
            }
        }

        private void LoadJuiceDetails(int juiceID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Name, Description, ImageUrl, Category, Price, Availability FROM dbo.Juice WHERE JuiceID = @JuiceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@JuiceID", juiceID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            txtImageUrl.Text = reader["ImageUrl"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            ddlCategory.SelectedValue = reader["Category"].ToString();
                            ddlAvailability.SelectedValue = reader["Availability"].ToString();
                        }
                    }
                }
            }
        }

        protected void btnSaveJuice_Click(object sender, EventArgs e)
        {
            int juiceID = Convert.ToInt32(Request.QueryString["JuiceID"]);
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string imageUrl = txtImageUrl.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text.Trim());
            string category = ddlCategory.SelectedValue;
            string availability = ddlAvailability.SelectedValue;

            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE dbo.Juice SET Name = @Name, Description = @Description, ImageUrl = @ImageUrl, " +
                               "Category = @Category, Price = @Price, Availability = @Availability WHERE JuiceID = @JuiceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ImageUrl", imageUrl);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@JuiceID", juiceID);

                    command.ExecuteNonQuery();
                }
            }

            // Redirect back to the Admin Dashboard after saving the changes
            Response.Redirect("~/AdminDashboard.aspx");
        }
    }
}
