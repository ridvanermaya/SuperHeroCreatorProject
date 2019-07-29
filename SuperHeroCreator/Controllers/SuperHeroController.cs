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
        // GET: SuperHeroController
        public ActionResult Index()
        {
            var superHeroesList = _context.SuperHeroes.ToList();
            return View(superHeroesList);
        }

        // GET: SuperHeroController/Details/5
        public ActionResult Details(int id)
        {
            var superHero = _context.SuperHeroes.Where(i => i.Id == id).FirstOrDefault();
            return View(superHero);
        }

        // GET: SuperHeroController/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View();
        }

        // POST: SuperHeroController/Create
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

        // GET: SuperHeroController/Edit/5
        public ActionResult Edit(int id)
        {
            var superHero = _context.SuperHeroes.Where(x => x.Id == id).FirstOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroController/Edit/5
        [HttpPost]
        public ActionResult Edit(SuperHero superHero)
        {
            try
            {
                // TODO: Add update logic here
                _context.Update(superHero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroController/Delete/5
        public ActionResult Delete(int id)
        {
            var superHero = _context.SuperHeroes.Where(x => x.Id == id).FirstOrDefault();
            return View(superHero);
        }

        // POST: SuperHeroController/Delete/5
        [HttpPost]
        public ActionResult Delete(SuperHero superHero)
        {
            try
            {
                // TODO: Add delete logic here
                _context.Remove(superHero);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}