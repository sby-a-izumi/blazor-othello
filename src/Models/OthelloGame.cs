namespace BlazorOthello.Models
{
    public enum Player
    {
        None,
        Black,
        White
    }

    public class OthelloGame
    {
        private Player[,] board = new Player[8, 8];

        public void InitializeBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = Player.None;
                }
            }
            board[3, 3] = Player.White;
            board[4, 4] = Player.White;
            board[3, 4] = Player.Black;
            board[4, 3] = Player.Black;
        }

        public Player GetPlayerAt(int x, int y)
        {
            return board[x, y];
        }
    }
}