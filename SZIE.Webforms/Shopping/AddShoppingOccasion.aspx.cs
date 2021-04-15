using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Shopping
{
    public partial class AddShoppingOccation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var selectedDate = cndDate.SelectedDate;
            var descr = txtDescription.Text;

            using (var db = new ShoppingContext())
            {
                var isExist = db.ShoppingOccasions.Any(x => x.Date.Equals(selectedDate));
                if (isExist)
                    ltrResult.Text = "This date is already exists.";
                else
                {
                    var query = db.ShoppingOccasions.Add(new ShoppingOccasion()
                    {
                        Date = cndDate.SelectedDate,
                        Description = descr
                    }) ;
                    db.SaveChanges();
                    ltrResult.Text = selectedDate.ToShortDateString() + ": " + txtDescription.Text;
                }
            }

        }
    }
}