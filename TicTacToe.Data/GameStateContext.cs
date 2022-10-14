using Microsoft.EntityFrameworkCore;
using TicTacToe.Contracts.Models;


namespace TicTacToe.Data
{
    public class GameStateContext : DbContext
    {
        public GameStateContext(DbContextOptions<GameStateContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
    }
}