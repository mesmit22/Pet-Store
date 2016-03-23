using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pet_Store.Models;
using Pet_Store.DAL;

namespace Pet_Store.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            PetStoreContext context = new PetStoreContext();
            List<Pet> pets = context.Pets.ToList();
            return View(pets);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return View(pet);
            }

            try
            {
                PetStoreContext context = new PetStoreContext();
                context.Pets.Add(pet);
                context.SaveChanges();
            } catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(pet);
            }


            TempData["Message"] = "Created " + pet.Name;

            return RedirectToAction("Index");
        }
    }
}