using Microsoft.AspNetCore.Mvc;
using MVCPrac.Data;
using MVCPrac.Migrations;
using MVCPrac.Models;

namespace MVCPrac.Controllers
{
    public class VehicalController : Controller
    {
        private readonly ApplicationDbContext db;
        public VehicalController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var data = db.Vehicles.ToList();
            return View(data);
        }
        //DeleteVehicles Update
        public IActionResult AddVehicles()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVehicles(Vehicles v)
        {
            db.Vehicles.Add(v);
            db.SaveChanges();
            TempData["successMsg"] = "Vehicle Added Successfully";
            return RedirectToAction("Index", "Vehical");
        }
        [HttpGet]
        public IActionResult DeleteVehicles(int id)
        {
            var data = db.Vehicles.Find(id);
            if(data!=null)
            {
                db.Vehicles.Remove(data);
                db.SaveChanges();
                return RedirectToAction("Index", "Vehical");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var d = db.Vehicles.Find(id);
            return View(d);
        }
        [HttpPost]  
        public IActionResult Update(Vehicles vehi, int id)
        {
            db.Vehicles.Update(vehi);
            db.SaveChanges();
            TempData["updateMsg"] = "Update Successfully";
            return RedirectToAction("Index", "Vehical");
        }

    }
}
