using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TicTacToe.Data
{
     class MatrixContext :DbContext
    {
        public MatrixContext(DbContextOptions<MatrixContext> options) : base(options) { }

        public DbSet<Matrix> BoardMatrices { get; set; }
    }
}
