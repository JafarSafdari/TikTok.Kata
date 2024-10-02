using System;

namespace Tic_tac_toe;

public class Player(char symbol)
{
    public char Symbol { get; private set; } = symbol;
    private readonly Random _random = new();

    // Bot randomly places a move
    public void MakeMove(Board board)
    {
        var moveMade = false;
        while (!moveMade)
        {
            var row = _random.Next(3);
            var col = _random.Next(3);
            moveMade = board.PlaceMove(row, col, Symbol);
        }
    }
}

