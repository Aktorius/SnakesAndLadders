﻿using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders.Models;
using SnakesAndLadders.Models.Extensions;

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

        [TestMethod]
        public void Given_Token_Is_On_Square_1_When_Moved_By_3_Then_Token_Is_On_Square_4()
        {
            // Given
            var token = new Token();

            var expectedSquarePosition = 4;

            // When
            token.Move(3);

            // Then
            Assert.AreEqual(expectedSquarePosition, token.SquarePosition);
        }

        [TestMethod]
        public void Given_Token_IS_Square_97_And_Move_4_Then_Token_Should_Be_Square_97()
        {
            // Given
            var token = new Token
            {
                SquarePosition = 97
            };
            var expectedSquarePosition = 97;

            // When
            token.Move(4);

            // Then
            Assert.AreEqual(expectedSquarePosition, token.SquarePosition);
        }
    }
}
