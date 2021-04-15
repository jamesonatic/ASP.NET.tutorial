using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebApplication4.ViewModels;

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



        public IEnumerable<ShoppingItem> GetShoppingItems(string ID)
        {
            var selectedID = Convert.ToInt32(ID);

            using (var db = new ShoppingContext())
            {
                var query = db.ShoppingItems
                    .Where(x => x.Occasion.ShoppinOccasionID == selectedID)
                    .OrderBy(x => x.ItemName)
                    .ToList();

                return query;
            }
        }
        public IEnumerable<ShoppingItemsGridViewModel> GetShoppingItemsViewModel(string ID)
        {
            var selectedID = Convert.ToInt32(ID);

            using (var db = new ShoppingContext())
            {
                var query = db.ShoppingItems
                    .Where(x => x.Occasion.ShoppinOccasionID == selectedID)
                    .OrderBy(x => x.Place.ShoppingPlaceID)
                    .Select(x => new ShoppingItemsGridViewModel()
                    {   
                        ShoppingPlaceName = x.Place.Name,
                        Quantity = x.Quantity.ToString(),
                        Unit = x.Unit,
                        ShoppingItemName = x.ItemName,
                    })
                    .ToList();

                return query;
            }
        }
    }
}