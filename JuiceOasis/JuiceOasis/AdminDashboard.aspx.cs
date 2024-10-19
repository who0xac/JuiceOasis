using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JuiceOasis
{
    public partial class AdminDashboard : Page
    {
        public List<JuiceItem> Juices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the admin is logged in
            if (Session["AdminLoggedIn"] == null || !(bool)Session["AdminLoggedIn"])
            {
                Response.Redirect("~/AdminLogin.aspx");
            }

            // Fetch the juices if the page is not a postback
            if (!IsPostBack)
            {
                FetchJuices();
            }
        }

        private void FetchJuices()
        {
            Juices = new List<JuiceItem>();
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT JuiceID, Name, Description, ImageUrl, Category, Availability, Price FROM dbo.Juice";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Juices.Add(new JuiceItem
                            {
                                JuiceID = Convert.ToInt32(reader["JuiceID"]),
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                ImageUrl = reader["ImageUrl"].ToString(),
                                Category = reader["Category"].ToString(),
                                Availability = reader["Availability"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"])
                            });
                        }
                    }
                }
            }

            // Bind the list of juices to the Repeater control
            repeaterJuices.DataSource = Juices;
            repeaterJuices.DataBind();
        }

        protected void btnAddJuice_Click(object sender, EventArgs e)
        {
            // Redirect to the Add Juice page
            Response.Redirect("~/AddJuice.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Get the JuiceID from the CommandArgument
            Button btnEdit = (Button)sender; // Cast sender to Button
            int juiceID = Convert.ToInt32(btnEdit.CommandArgument);
            // Redirect to the Edit Juice page with the JuiceID as a query parameter
            Response.Redirect($"~/EditJuice.aspx?JuiceID={juiceID}");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the JuiceID from the CommandArgument
            Button btnDelete = (Button)sender; // Cast sender to Button
            int juiceID = Convert.ToInt32(btnDelete.CommandArgument);
            // Delete the juice from the database
            DeleteJuice(juiceID);
            // Refresh the list of juices after deletion
            FetchJuices();
        }

        private void DeleteJuice(int juiceID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM dbo.Juice WHERE JuiceID = @JuiceID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use a parameterized query to avoid SQL injection
                    command.Parameters.AddWithValue("@JuiceID", juiceID);
                    command.ExecuteNonQuery();
                }
            }
        }

        // JuiceItem class to represent a juice entity
        public class JuiceItem
        {
            public int JuiceID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string Category { get; set; }
            public string Availability { get; set; }
            public decimal Price { get; set; }
        }
    }
}
