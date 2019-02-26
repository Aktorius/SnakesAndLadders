using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Models;

namespace Tests.SnakesAndLadders.Core
{
    [TestClass]
    public class BoardGameServiceTests
    {
        [TestMethod]
        public void Given_A_Token_Is_Square_97_And_Move_3_Then_The_Game_Is_Won()
        {
            // Given
            var token = new Token
            {
                SquarePosition = 97
            };

            var boardGameService = new BoardGameService();

            // When
            boardGameService.PlayTurn(token, 3);

            // Then
            Assert.IsTrue(boardGameService.IsGameWon());
        }
    }
}
