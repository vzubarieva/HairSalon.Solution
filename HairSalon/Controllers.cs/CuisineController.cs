using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
    public class CuisinesController : Controller
    {
        private readonly HairSalonContext _db;

        public CuisinesController(BestRestaurantsContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.Include(cuisine => cuisine.Restaurant).ToList();
            return View(model);
        }
    }
}
