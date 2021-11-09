using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewForMidterm.BLL;
using ReviewForMidterm.DAL;
using System.Windows.Forms;

namespace ReviewForMidterm.GUI
{
    public partial class WebFormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {

            Teachers teacher = new Teachers();
            if (TextBoxusername.Text.Length == 0)
            {
                MessageBox.Show("Enter your id ");
                return;
            }

            int id = Convert.ToInt32(TextBoxusername.Text.Trim());
            string password = TextBoxpassword.Text;
            bool result = teacher.ValidateUser(id, password);


            if ((result == true))
            {
                Session["id"] = id;
                Response.Redirect("WebFormProjectAssignment.aspx");

            }
            else
            {
                MessageBox.Show(" Invalid logIn information");
                return;
            }
        }
    }
}