﻿using CrudBasico.Models;
using System;
using System.Collections.Generic;
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
                return View(context.Usuario.Where(x=>x.UsuMatricula==matricula).FirstOrDefault());
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
                return View(context.Usuario.Where(x=>x.UsuMatricula==matricula));
            }
                
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}