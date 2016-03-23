using System;
using Pet_Store.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Pet_Store.DAL
{
    public class PetStoreContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }   
}