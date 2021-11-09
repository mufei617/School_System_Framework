using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewForMidterm.DAL;
using ReviewForMidterm.BLL;
using System.Windows.Forms;

namespace ReviewForMidterm.GUI
{
    public partial class WebFormTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("connected" + UtilityDB.ConnectDB().State.ToString());
        }
    }
}