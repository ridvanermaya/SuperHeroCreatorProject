using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroCreator.Models;
using SuperHeroCreator.Services;

namespace SuperHeroCreator.Controllers
{
    public class SuperHeroController : Controller
    {
        readonly SuperHeroesDbContext _context;

        public SuperHeroController(SuperHeroesDbContext context)
        {
            _context = context;
        }
        // GET: RedsCon
        public ActionResult Index()
        {
            var superHeroesList = _context.SuperHeroes.ToList();
            return View(superHeroesList);
        }

        // GET: RedsCon/Details/5
        public ActionResult Details(int id)
        {
            var superHero = _context.SuperHeroes.Where(i => i.Id == id).FirstOrDefault();
            return View(superHero);
        }

        // GET: RedsCon/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // POST: RedsCon/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Add(superHero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RedsCon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RedsCon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RedsCon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RedsCon/Delete/5
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