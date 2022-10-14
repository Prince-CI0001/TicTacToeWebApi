namespace TicTacToe.Contracts
{
    public interface IGameBoard
    {
            public string Move(string location,int id);

            public void ResetBoard();
    }
}
