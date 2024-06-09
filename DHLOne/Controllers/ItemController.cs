using DHLOne.Data;
using DHLOne.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace DHLOne.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Index()
        {
            List<Item> objItemList = _db.Items.ToList();
            return View(objItemList);
        }
    }
}
