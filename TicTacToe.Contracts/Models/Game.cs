using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Contracts.Models
{
    public class Game
    {
        [Key]
        public int id { get; set; }

        public string Gamestate { get; set; } = "---------";

        public string winner { get; set; } = "";

        public int xCount { get; set; } = 0;
        public int oCount { get; set; } = 0;
    }
}
