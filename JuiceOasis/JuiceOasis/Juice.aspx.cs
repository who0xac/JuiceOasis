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
                FetchJuices();
            }
        }

        private void FetchJuices()
        {
            Juices = new List<JuiceItem>();
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Description, ImageUrl, Category, Availability FROM dbo.Juice"; // Ensure this matches your table structure

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
                                    Availability = reader["Availability"].ToString() // Fetch Availability
                                });
                            }
                        }
                    }
                }

                if (Juices.Count == 0)
                {
                    Console.WriteLine("No data found in the Juice table.");
                }
                else
                {
                    Console.WriteLine($"Number of juices retrieved: {Juices.Count}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }

        public class JuiceItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string Category { get; set; }
            public string Availability { get; set; } // Availability field
        }
    }
}
