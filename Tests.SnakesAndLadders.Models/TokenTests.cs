using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.SnakesAndLadders.Models
{
    [TestClass]
    public class TokenTests
    {
        [TestMethod]
        public void Given_A_Token_Is_Created_The_Position_Should_Be_1()
        {
            // Given
            int expectedSquarePosition = 1;

            // When
            var token = new Token();

            // Then
            Assert.AreEqual(token.SquarePosition, expectedSquarePosition);
        }
    }
}
