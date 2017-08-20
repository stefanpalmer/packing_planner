using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PackingPlanner1.Models;
using PackingPlanner1.ViewModels;

namespace PackingPlanner1.Controllers
{
    public class ItemsController : Controller
    {
        private ApplicationDbContext _context;

        public ItemsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Items
        public ActionResult Index()
        {
            var itemsInDb = _context.Items.Include(i => i.Category).ToList();
            return View(itemsInDb);
        }

    }
}