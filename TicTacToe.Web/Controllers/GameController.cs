using Microsoft.AspNetCore.Mvc;
using TicTacToe.Core;

namespace TicTacToe.Web
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameBoard gameBoard;

        public GameController()
        {
            gameBoard = new GameBoard();
         }

        [HttpPost]
        public IActionResult Set([FromBody] string location)
        {
           
            var index = gameBoard.ExecuteMove(location.Trim());
            return Ok(index);
        }

        [HttpGet]
        public IActionResult EmptyMatrix()
        {
            gameBoard.EmptyMatrix();
            return Ok();
        }
    }
}
