using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Store.Models
{
    public class Pet
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string AnimalType { get; set; }
    }
}