using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicTacToe.Contracts;
using TicTacToe.Contracts.Models;

namespace TicTacToe.Data
{
    public class GameRepository : IGameRepository
    {
        private readonly GameStateContext _context;

        public GameRepository(GameStateContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddGame(Game game)
        {
            if (game == null)
                throw new ArgumentNullException(nameof(game));

            _context.Games.Add(game);
        }

        public bool save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateGame(string state,int id)
        {
            var game = _context.Games.FirstOrDefault(a => a.id == id);
            game.Gamestate = state;
            _context.SaveChanges();
        }

        public void Winner(int id,string winner)
        {
            var game = _context.Games.FirstOrDefault(a => a.id == id);
            game.winner = winner;
            _context.SaveChanges();
        }
    }
}
