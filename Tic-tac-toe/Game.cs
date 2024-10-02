namespace Tic_tac_toe;
public class Game
{
    public Board Board { get; private set; } = new();
    private readonly Player _playerX = new('X');
    private readonly Player _playerO = new('O');

    public void Play()
    {
        var currentPlayer = _playerX;
        var gameEnded = false;

        while (!gameEnded)
        {
            Board.DisplayBoard();
            Console.WriteLine($"PLAYER {currentPlayer.Symbol}'S turn ");
            currentPlayer.MakeMove(Board);

            if (CheckForWinner(currentPlayer.Symbol))
            {
                Board.DisplayBoard();
                Console.WriteLine($"PLAYER {currentPlayer.Symbol} WON!");
                gameEnded = true;
            }
            else if (Board.IsFull())
            {
                Board.DisplayBoard();
                Console.WriteLine("IT'S A DRAW!");
                gameEnded = true;
            }

            currentPlayer = (currentPlayer == _playerX) ? _playerO : _playerX;
        }
    }

    // Check for a winner
    public bool CheckForWinner(char player)
    {
        var grid = Board.Grid;

        // Check rows, columns, and diagonals
        for (var i = 0; i < 3; i++)
        {
            if (grid[i, 0] == player && grid[i, 1] == player && grid[i, 2] == player) return true;
            if (grid[0, i] == player && grid[1, i] == player && grid[2, i] == player) return true;
        }

        if (grid[0, 0] == player && grid[1, 1] == player && grid[2, 2] == player) return true;
        if (grid[0, 2] == player && grid[1, 1] == player && grid[2, 0] == player) return true;

        return false;
    }
}


