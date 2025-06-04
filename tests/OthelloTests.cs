using Xunit;

namespace OthelloTests
{
    public class OthelloGameTests
    {
        [Fact]
        public void TestInitialSetup()
        {
            // Arrange
            var game = new OthelloGame();

            // Act
            game.InitializeBoard();

            // Assert
            Assert.Equal(Player.None, game.GetPlayerAt(3, 3));
            Assert.Equal(Player.None, game.GetPlayerAt(3, 4));
            Assert.Equal(Player.None, game.GetPlayerAt(4, 3));
            Assert.Equal(Player.None, game.GetPlayerAt(4, 4));
        }

        // Other test methods...
    }
}