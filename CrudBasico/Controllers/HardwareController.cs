//Indicamos el uso de los modelos
using CrudBasico.Models;

using System.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudBasico.Controllers
{
    public class HardwareController : Controller
    {
        // GET: Hardware
        public ActionResult Index()
        {
            using (DBModels context = new DBModels())
                return View(context.Hardware.ToList());
        }

        // GET: Hardware/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Hardware.Where(x=>x.HardId == id).FirstOrDefault());
            }
        }

        // GET: Hardware/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hardware/Create
        [HttpPost]
        public ActionResult Create(Hardware hardwares)
        {
            try
            {
                using (DBModels context = new DBModels())
                {
                    context.Hardware.Add(hardwares);
                    context.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hardware/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Hardware.Where(x => x.HardId == id).FirstOrDefault());
            }
        }

        // POST: Hardware/Edit/5
        [HttpPost]
        public ActionResult Edit(Hardware hardwares)
        {
            try
            {
                using (DBModels context = new DBModels()) 
                {
                    context.Entry(hardwares).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hardware/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Hardware.Where(x => x.HardId == id).FirstOrDefault());
            }
                
        }

        // POST: Hardware/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DBModels context = new DBModels()) 
                {
                    Hardware hardwares = context.Hardware.Where(x => x.HardId == id).FirstOrDefault();
                    context.Hardware.Remove(hardwares);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
