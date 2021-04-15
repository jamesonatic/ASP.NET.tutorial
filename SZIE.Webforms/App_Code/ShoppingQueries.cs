using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication4.App_Code
{
    public class ShoppingQueries
    {
        public IEnumerable<ListItem> GetFutureShoppingOccs()
        {
            using (var db = new ShoppingContext())
            {
                var currentDate = DateTime.Now.Date;
                var query = db.ShoppingOccasions
                    .Where(x=> currentDate <= x.Date)
                    .OrderBy(x=>x.Date)
                    .ToList()
                    .Select(x => new ListItem() 
                    {
                        Text = x.Date.ToShortDateString(), Value = x.ShoppinOccasionID.ToString() 
                    });

                return query;
            }
        }
    }
}