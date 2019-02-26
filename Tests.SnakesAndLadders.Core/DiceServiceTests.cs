using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Core;

namespace Tests.SnakesAndLadders.Core
{
    [TestClass]
    public class DiceServiceTests
    {
        [TestMethod]
        public void Given_A_Die_Is_Rolled_Then_Result_Should_Be_Between_1_And_6()
        {
            // Given
            var diceFaces = 6;
            var diceService = new DiceService();

            var expectedLowerBound = 1;
            var expectedHigherBound = 6;

            // When
            var result = diceService.RollDie(diceFaces);

            // Then
            Assert.IsTrue(expectedLowerBound <= result);
            Assert.IsTrue(expectedHigherBound >= result);
        }
    }
}
