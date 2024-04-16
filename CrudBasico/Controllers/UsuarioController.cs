//Indicamos el uso de los modeloss
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
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            using (DBModels context = new DBModels())
                return View(context.Usuario.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(string matricula)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Usuario.Where(y=>y.UsuMatricula==matricula).FirstOrDefault());
            }        
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuarios)
        {
            try
            {
                using (DBModels context = new DBModels())
                {
                    context.Usuario.Add(usuarios);
                    context.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(string matricula)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Usuario.Where(y=>y.UsuMatricula==matricula).FirstOrDefault());
            }
                
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(Usuario usuarios)
        {
            try
            {
                using (DBModels context = new DBModels())
                {
                    context.Entry(usuarios).State = EntityState.Modified;
                    context.SaveChanges();
                } 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(string matricula)
        {
            using (DBModels context = new DBModels())
            {
                return View(context.Usuario.Where(y=>y.UsuMatricula==matricula).FirstOrDefault());
            }
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(string matricula, FormCollection collection)
        {
            try
            {
                using (DBModels context = new DBModels())
                {
                    Usuario usuarios = context.Usuario.Where(y=>y.UsuMatricula==matricula).FirstOrDefault();
                    context.Usuario.Remove(usuarios);
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
