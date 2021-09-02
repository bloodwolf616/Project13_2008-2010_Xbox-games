using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project13__2008_2010_Xbox_games_.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public DateTime DateOfRelease { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        

        //one to many relationship
        public string Series { get; set; }
     



    }
}