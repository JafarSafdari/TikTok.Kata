namespace Tic_tac_toe.test;

using Xunit;

public class PlayerTests
{
    [Fact]
    public void Player_MakeMove_PlacesValidMove()
    {
        // Arrange
        var board = new Board();
        var player = new Player('X');

        // Act
        player.MakeMove(board);

        // Assert
        var moveMade = false;
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (board.Grid[i, j] == 'X')
                {
                    moveMade = true;
                    break;
                }
            }
        }
        Assert.True(moveMade);
    }
}
