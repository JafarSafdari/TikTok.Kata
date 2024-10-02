namespace Tic_tac_toe;
public class Board
{
    public char[,] Grid { get; private set; }

    public Board()
    {
        Grid = new char[3, 3];
        InitializeBoard();
    }

    // Initialize the board with empty spaces
    public void InitializeBoard()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Grid[i, j] = ' ';
            }
        }
    }

    // Display the board
    public void DisplayBoard()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Console.Write(Grid[i, j]);
                if (j < 2) Console.Write("|");
            }
            if (i < 2) Console.WriteLine("\n-+-+-");
        }
        Console.WriteLine();
    }

    // Place move on the board
    public bool PlaceMove(int row, int col, char player)
    {
        if (Grid[row, col] == ' ')
        {
            Grid[row, col] = player;
            return true;
        }
        return false;
    }

    // Check if the board is full
    public bool IsFull()
    {
        foreach (var cell in Grid)
        {
            if (cell == ' ') return false;
        }
        return true;
    }
}
