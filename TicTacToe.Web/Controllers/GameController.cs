using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Contracts;
using TicTacToe.Contracts.Models;
using TicTacToe.Core;

namespace TicTacToe.Web
{
    [Route("api/Game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGameBoard _gameBoard;
        public GameController(IGameRepository gameRepository, IGameBoard gameBoard)
        {
            _gameRepository = gameRepository ??
                throw new ArgumentNullException(nameof(gameRepository));
            _gameBoard = gameBoard;
        }

        [HttpPost]
        public Game CreateGame()
        {
            var newGame = new Game();
            _gameBoard.ResetBoard();
            _gameRepository.AddGame(newGame);
            _gameRepository.save();
            return newGame;
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateGameState([FromBody] string location, [FromRoute] int id)
        {
           
            var index = _gameBoard.Move(location,id);
            return Ok(index);
        }

        [HttpPatch("{id}/winner")]
        public IActionResult UpdateWinner([FromBody] string winner, [FromRoute] int id)
        {

            _gameRepository.Winner(id,winner);
            return Ok();
        }
        
    }
}
