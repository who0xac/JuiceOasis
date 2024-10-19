using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace JuiceOasis
{
    public partial class AddJuice : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any necessary actions when the page loads
        }

        protected void btnAddJuice_Click(object sender, EventArgs e)
        {
            // Get the juice details from the form
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            string imageUrl = txtImageUrl.Text.Trim();
            decimal price = decimal.Parse(txtPrice.Text.Trim());
            string category = ddlCategory.SelectedValue;
            string availability = ddlAvailability.SelectedValue;

            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            // Insert the new juice into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO dbo.Juice (Name, Description, ImageUrl, Category, Price, Availability) " +
                               "VALUES (@Name, @Description, @ImageUrl, @Category, @Price, @Availability)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ImageUrl", imageUrl);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Availability", availability);

                    command.ExecuteNonQuery();
                }
            }

            // Redirect back to the Admin Dashboard after adding the juice
            Response.Redirect("~/AdminDashboard.aspx");
        }
    }
}
