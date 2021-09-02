using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project13__2008_2010_Xbox_games_.Models;

namespace Project13__2008_2010_Xbox_games_.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Game halo3 = new Game()
            {
                Title = "Halo 3",
                Genre = "First Person Shooter",
                DateOfRelease = new DateTime(2007, 9, 27),
                Description = "Halo 3's story centers on the interstellar war between twenty-sixth century humanity, a collection of alien races known as the Covenant, and the alien parasite Flood. The player assumes the role of the Master Chief, a cybernetically enhanced supersoldier, as he battles the Covenant and the Flood.",
                Developer = "Bungie",
                Series = "Halo",

            };
            return View(halo3);
        }
    }
}