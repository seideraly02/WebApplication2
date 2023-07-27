using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        // GET
        private Context _db;

        public UsersController(Context db)
        {
            _db = db;
        }

       
        // GET
        public IActionResult Index()
        {
            List<User> Users = _db.Users.ToList();
            return View(Users);
        }
        public IActionResult Create()//http://Localhost:5000/Users/Create
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(User user)//http://Localhost:5000/Users/Create
        {
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}