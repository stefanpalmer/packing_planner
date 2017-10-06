using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PackingPlanner1.Models;
using PackingPlanner1.ViewModels;
using System.Net;
using System.Web.UI;

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


        public ActionResult Index()
        {
            var itemsInDb = _context.Items.Include(i => i.Category).ToList();
            return View(itemsInDb);
        }

        public ActionResult New()
        {
            var viewModel = new ItemFormViewModel
            {
                Item = new Item(),
                Category = _context.Categories.ToList()
            };
            return View("ItemForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                return HttpNotFound();

            var viewModel = new ItemFormViewModel
            {
                Item = itemInDb,
                Category = _context.Categories.ToList()
            };

            return View("ItemForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Item item)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ItemFormViewModel
                {
                    Item = item,
                    Category = _context.Categories.ToList()
                };

                return View("ItemForm", viewModel);
            }

            if (item.Id == 0)
                _context.Items.Add(item);
            else
            {
                var itemInDb = _context.Items.Single(i => i.Id == item.Id);

                itemInDb.Name = item.Name;
                itemInDb.Quantity = item.Quantity;
                itemInDb.CategoryId = item.CategoryId;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Items");
        }


        public ActionResult Delete(int id)
        {
            var itemInDb = _context.Items.SingleOrDefault(i => i.Id == id);

            if (itemInDb == null)
                return HttpNotFound();

            _context.Items.Remove(itemInDb);
            _context.SaveChanges();

            return RedirectToAction("Index", "Items");
        }
    }
}