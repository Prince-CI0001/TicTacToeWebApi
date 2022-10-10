namespace TicTacToe.Contracts
{
    public interface IGameBoard
    {
        public string ExecuteMove(string location);

        public void EmptyMatrix();
    }
}
