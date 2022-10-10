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
        public IActionResult Set([FromQuery] string location)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map["Id"] = gameBoard.ExecuteMove(location.Trim());
            return Ok(map);
        }
    }
}
