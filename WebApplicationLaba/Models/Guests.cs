using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLaba.Models
{
    public class Guests
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Teacher { get; set; }
    }
    

    /* // GET: Guests
     public ActionResult Index()
     {
         return View();
     }

     // GET: Guests/Details/5
     public ActionResult Details(int id)
     {
         return View();
     }

     // GET: Guests/Create
     public ActionResult Create()
     {
         return View();
     }

     // POST: Guests/Create
     [HttpPost]
     [ValidateAntiForgeryToken]
     public ActionResult Create(IFormCollection collection)
     {
         try
         {
             // TODO: Add insert logic here

             return RedirectToAction(nameof(Index));
         }
         catch
         {
             return View();
         }
     }

     // GET: Guests/Edit/5
     public ActionResult Edit(int id)
     {
         return View();
     }

     // POST: Guests/Edit/5
     [HttpPost]
     [ValidateAntiForgeryToken]
     public ActionResult Edit(int id, IFormCollection collection)
     {
         try
         {
             // TODO: Add update logic here

             return RedirectToAction(nameof(Index));
         }
         catch
         {
             return View();
         }
     }

     // GET: Guests/Delete/5
     public ActionResult Delete(int id)
     {
         return View();
     }

     // POST: Guests/Delete/5
     [HttpPost]
     [ValidateAntiForgeryToken]
     public ActionResult Delete(int id, IFormCollection collection)
     {
         try
         {
             // TODO: Add delete logic here

             return RedirectToAction(nameof(Index));
         }
         catch
         {
             return View();
         }
     } */
     
}



//Model(state = validation)