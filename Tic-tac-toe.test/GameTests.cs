using Xunit;

namespace Tic_tac_toe.test;

public class GameTests
{
    [Fact]
    public void Game_CheckForWinner_PlayerWins()
    {
        // Arrange
        var game = new Game();

        // Manipulate the board used by the game instance
        game.Board.PlaceMove(0, 0, 'X');
        game.Board.PlaceMove(1, 0, 'X');
        game.Board.PlaceMove(2, 0, 'X');

        // Act
        var result = game.CheckForWinner('X');

        // Assert
        Assert.True(result);
    }
}

