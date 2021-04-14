using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ddl1.Items.Add("Jani");
                ddl1.Items.Add("Laci");
                ddl1.Items.Add("Géza");
                ddl1.Items.Add("Tomi");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = ddl1.SelectedValue + " clicked";
        }
    }
}