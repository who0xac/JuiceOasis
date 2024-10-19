using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;

namespace JuiceOasis
{
    public partial class AdminLogin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // If the admin is already logged in, redirect to the dashboard
            if (Session["AdminLoggedIn"] != null && (bool)Session["AdminLoggedIn"])
            {
                Response.Redirect("~/AdminDashboard.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate the admin credentials
            if (IsValidAdmin(email, password))
            {
                // Set session variable indicating the admin is logged in
                Session["AdminLoggedIn"] = true;
                // Redirect to the admin dashboard
                Response.Redirect("~/AdminDashboard.aspx");
            }
            else
            {
                // Display an error message
                lblErrorMessage.Text = "Invalid email or password.";
                lblErrorMessage.Visible = true; // Show the error message
            }
        }

        private bool IsValidAdmin(string email, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["JuiceDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Admin WHERE Email = @Email AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
