using ShoppingDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Shopping
{
    public partial class AddShoppingItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (var db = new ShoppingContext())
                {
                    var shoppingPlaces = db.ShoppingPlaces.Select(x => new ListItem(){ Text=x.Name, Value=x.ShoppingPlaceID.ToString() }).ToArray();
                    ddlPlace.Items.AddRange(shoppingPlaces);                    
                    var shoppingOccasions = db.ShoppingOccasions.Select(x => new ListItem(){ Text=x.Description, Value=x.ShoppinOccasionID.ToString() }).ToArray();
                    ddlOcc.Items.AddRange(shoppingOccasions);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new ShoppingContext())
                {
                    int id;
                    id = Convert.ToInt32(ddlPlace.SelectedValue);
                    var shoppingPlace = db.ShoppingPlaces.FirstOrDefault(x => x.ShoppingPlaceID == id);
                    id = Convert.ToInt32(ddlOcc.SelectedValue);
                    var shoppingOcc = db.ShoppingOccasions.FirstOrDefault(x => x.ShoppinOccasionID == id);

                    var shoppingItem = new ShoppingItem()
                    {
                        ItemName = txtName.Text,
                        Unit = txtUnit.Text,
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        Occasion = shoppingOcc,
                        Place = shoppingPlace
                    };
                    db.ShoppingItems.Add(shoppingItem);
                    db.SaveChanges();

                    ltrResult.Text = "Successfully added";
                }
            }
            catch (Exception)
            {
                ltrResult.Text = "Error occurred";
            }
        }
    }
}