using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project13__2008_2010_Xbox_games_.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {

            ViewBag.Title = "2008-2010 Xbox Games";
            ViewBag.Name = "Chris";
            ViewBag.GroceryList = new string[] { "Apples", "Oranges", "Bananas" };
            return View();
        }
    }
}