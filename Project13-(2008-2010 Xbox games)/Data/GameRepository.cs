using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project13__2008_2010_Xbox_games_.Models;
namespace Project13__2008_2010_Xbox_games_.Data
{
    public class GameRepository
    {
        private static Game[] _gamesRepository = new Game[]
        {
            new Game()
            {
                Id = 1,
                Title = "Halo 2",
                DateOfRelease = new DateTime(2004, 11, 4),
                Description = "the player assumes the roles of the human Master Chief and the alien Arbiter in a 26th-century conflict between the United Nations Space Command, the genocidal Covenant, and the parasitic Flood.",
                Developer = "Bungie",
                Series = "Halo",
                Genre = "First Person Shooter"
            },
            new Game()
            {
                Id = 2,
                Title = "Halo 3",
                DateOfRelease = new DateTime(2007, 9, 25),
                Description = " The player assumes the role of the Master Chief, a cybernetically enhanced supersoldier, as he battles the Covenant and the Flood.",
                Developer = "Bungie",
                Series = "Halo",
                Genre = "First Person Shooter"
            },
            new Game()
            {
                Id = 3,
                Title = "Halo 3: ODST",
                DateOfRelease = new DateTime(2009, 9, 22),
                Description = " known as \"Orbital Drop Shock Troopers\" or ODSTs, during and after the events of Halo 2. In the game's campaign mode, players explore the ruined city of New Mombasa to discover what happened to their missing teammates in the midst of an alien invasion",
                Developer = "Bungie",
                Series = "Halo",
                Genre = "First Person Shooter"
            },
            new Game()
            {
                Id = 4,
                Title = "Assassin's Creed",
                DateOfRelease = new DateTime(2007, 11, 13),
                Description = "The plot is set in a fictional history of real-world events, taking place primarily during the Third Crusade in the Holy Land in 1191. The player character is a modern-day man named Desmond Miles who, through a machine called the \"Animus\", relives the genetic memories of his ancestor, Altaïr Ibn-La'Ahad. Through this plot device, details emerge about a centuries-old struggle between two factions: the Assassin Brotherhood, who fight for peace with free will, and the Knights Templar, ",
                Developer = "Ubisoft Montreal",
                Series = "Assassin's Creed",
                Genre = "Action Adventure"
            },
            new Game()
            {
                Id = 5,
                Title = "Bioshock",
                DateOfRelease = new DateTime(2007, 8, 21),
                Description = "BioShock is set in 1960. The player guides the protagonist, Jack, after his airplane crashes in the ocean near the bathysphere terminus that leads to the underwater city of Rapture. Built by the business magnate Andrew Ryan, the city was intended to be an isolated utopia, but the discovery of ADAM, a genetic material which can be used to grant superhuman powers, initiated the city's turbulent decline. Jack tries to find a way to escape, fighting through hordes of ADAM-obsessed enemies",
                Developer = "2k Boston",
                Series = "Bioshock",
                Genre = "Horror"
            },

        };


        public Game[] GetAllGames()
        {
            return _gamesRepository;
        }

        public Game GetGame(int id)
        {
            Game gameInRepository = null;
            
            foreach(var game in _gamesRepository)
            {
                if(gameInRepository.Id == id)
                {
                    gameInRepository = game;
                }
            }

            return gameInRepository;
        }



    }
}