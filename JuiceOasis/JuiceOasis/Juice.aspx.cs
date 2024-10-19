using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace JuiceOasis
{
    public partial class Juice : Page
    {
        public List<JuiceItem> Juices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FetchJuices("All"); // Load all juices by default
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            string category = ((System.Web.UI.WebControls.Button)sender).CommandArgument;
            FetchJuices(category); // Fetch juices based on the selected category
        }

        private void FetchJuices(string category)
        {
            Juices = new List<JuiceItem>();
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Description, ImageUrl, Category, Availability, Price FROM dbo.Juice";

                    // Apply filter if a specific category is selected
                    if (category != "All")
                    {
                        query += " WHERE Category = @Category"; // Filter by category
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (category != "All")
                        {
                            command.Parameters.AddWithValue("@Category", category); // Pass the parameter value
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Juices.Add(new JuiceItem
                                {
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

                // Bind data to Repeater control
                repeaterJuices.DataSource = Juices;
                repeaterJuices.DataBind();
            }
            catch (SqlException ex)
            {
                // Handle SQL-related errors
                Response.Write("<script>alert('SQL Error: " + ex.Message + "');</script>");
            }
            catch (Exception ex)
            {
                // Handle general errors
                Response.Write("<script>alert('Unexpected Error: " + ex.Message + "');</script>");
            }
        }

        public class JuiceItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string Category { get; set; }
            public string Availability { get; set; }
            public decimal Price { get; set; }
        }
    }
}
