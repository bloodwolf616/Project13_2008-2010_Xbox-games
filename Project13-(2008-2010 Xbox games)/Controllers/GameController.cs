using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project13__2008_2010_Xbox_games_.Models;
using Project13__2008_2010_Xbox_games_.Data;


namespace Project13__2008_2010_Xbox_games_.Controllers
{
    public class GameController : Controller
    {
        GameRepository _gameRepository = null;

        public GameController()
        {
            _gameRepository = new GameRepository();
        }

        // GET: Game
        public ActionResult Index()
        {
            Game[] allGames = _gameRepository.GetAllGames();
        
            return View(allGames);
        }

        public ActionResult Detail(int? id)
        {
            Game specificGame = _gameRepository.GetGame((int)id);
            if(id == null)
            {
                return HttpNotFound();
            }
            return View(specificGame);
        }

        public ActionResult Series()
        {
            List<Game> haloGames = _gameRepository.GetHaloGames();
            if(haloGames == null)
            {
                return HttpNotFound();
            }

            return View(haloGames);

        }

    }
}