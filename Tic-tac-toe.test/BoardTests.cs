namespace Tic_tac_toe.test;

public class BoardTests
{
    [Fact]
    public void Board_Initialize_EmptyBoard()
    {
        // Arrange
        var board = new Board();

        // Act & Assert
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Assert.Equal(' ', board.Grid[i, j]);
            }
        }
    }

    [Fact]
    public void Board_PlaceMove_ValidMove()
    {
        // Arrange
        var board = new Board();

        // Act
        var result = board.PlaceMove(0, 0, 'X');

        // Assert
        Assert.True(result);
        Assert.Equal('X', board.Grid[0, 0]);
    }

    [Fact]
    public void Board_PlaceMove_InvalidMove()
    {
        // Arrange
        var board = new Board();
        board.PlaceMove(0, 0, 'X');

        // Act
        var result = board.PlaceMove(0, 0, 'O');

        // Assert
        Assert.False(result);
        Assert.Equal('X', board.Grid[0, 0]);
    }
}
