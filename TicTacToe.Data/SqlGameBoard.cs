using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Contracts;

namespace TicTacToe.Data
{
    public class SqlGameBoard : IGameBoard
    {
        public void EmptyMatrix()
        {
            
        }

        public string ExecuteMove(string location)
        {
            throw new NotImplementedException();
        }
    }
}
