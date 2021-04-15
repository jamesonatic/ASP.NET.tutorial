using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccess.Models
{
    public class ShoppingInitializer: CreateDatabaseIfNotExists<ShoppingContext>
    {
        protected override void Seed(ShoppingContext context)
        {
            var list = new List<ShoppingPlace>();
            list.Add(new ShoppingPlace() { Name = "Vegyesbolt", Address = "Első út 1." });
            list.Add(new ShoppingPlace() { Name = "Festékbolt", Address = "Masodik út 2." });
            list.Add(new ShoppingPlace() { Name = "Barkácsbolt", Address = "Harmadik utca 3." });

            context.ShoppingPlaces.AddRange(list);

            base.Seed(context);
        }
    }
}
