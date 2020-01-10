using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vendor.Models;

namespace Vendor.Controllers
{
    public class ItemsController : Controller 
    {

        [HttpGet("/categories/{categoryId}/items/new")]
        public ActionResult New(int categoryId)
        {
           Category category = Category.findCategoryById(categoryId);
           return View(category);
        }

        [HttpPost("/items/delete")]
        public ActionResult DeleteAll()
        {
            Item.clearAllItems();
            return View();
        }

        [HttpGet("/categories/{categoryId}/items/{itemId}")]
        public ActionResult Show(int categoryId, int itemId)
        {
            Item item = Item.Find(itemId);
            Category category = Category.findCategoryById(categoryId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("item", item);
            model.Add("category", category);
            return View(model);
        }
    }
} 