using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Pet_Store.Models;

namespace Pet_Store.DAL
{
    public class PetStoreInitializer : System.Data.Entity.DropCreateDatabaseAlways<PetStoreContext>
    {
        protected override void Seed(PetStoreContext context)
        {
            context.Pets.Add(
                new Pet(){ Name = "Fluffy",
                           Age = "1 month",
                           AnimalType = "Dog"
            });
            context.SaveChanges();
        }
    }
}