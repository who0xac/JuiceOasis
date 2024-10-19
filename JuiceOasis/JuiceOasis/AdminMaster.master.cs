using System;
using System.Web.UI;

namespace JuiceOasis
{
    public partial class AdminMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Any code to execute during page load
        }

        protected void btnAddJuice_Click(object sender, EventArgs e)
        {
            // Redirect to the Add Juice page
            Response.Redirect("~/AddJuice.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Log the admin out and redirect to the admin login page
            Session["AdminLoggedIn"] = null;
            Response.Redirect("~/AdminLogin.aspx");
        }
    }
}
