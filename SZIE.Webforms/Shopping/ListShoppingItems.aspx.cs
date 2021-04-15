using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Shopping
{
    public partial class ListShoppingItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSelectedDate3.DataSource = SqlDataSource2;
            ddlSelectedDate3.DataTextField = "Date";
            ddlSelectedDate3.DataValueField = "ShoppinOccasionID";
            ddlSelectedDate3.DataBind();

        }

        protected void ddlSelectedDate4_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        protected void ddlSelectedDate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView2.DataBind();
        }
    }
}