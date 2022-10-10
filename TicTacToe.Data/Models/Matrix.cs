using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    public class Matrix
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string player { get; set; }
    }
}
