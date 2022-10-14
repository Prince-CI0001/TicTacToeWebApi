using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Contracts.Models;

namespace TicTacToe.Contracts
{
    public interface IGameRepository
    {
        void AddGame(Game game);

        bool save();

        void UpdateGame(string state,int id);

        void Winner(int id,string winner);
    }
}
