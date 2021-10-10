using Xunit;
using Yahtzee.Models;
using System.Collections.Generic;

namespace YahtzeeTests
{
    public class GameTests
    {


        [Theory]
        [InlineData(new[] { 3, 2, 3, 4, 6 }, 6, 3)]
        [InlineData(new[] { 1, 2, 1, 6, 6 }, 12, 6)]
        [InlineData(new[] { 1, 4, 4, 4, 1 }, 0, 2)]
        [InlineData(new[] { 2, 6, 3, 6, 6 }, 2, 2)]
        public void CalculatedNumbers(int[] roll, int expectedScore, int number)
        {

            var game = new Game();
            var score = game.CalculateNumber(roll, number);

            Assert.Equal(expectedScore, score);
        }

        [Theory]
        [InlineData(new[] {2, 2, 2, 2, 3}, 11, 2)]
        [InlineData(new[] { 3, 3, 3, 3, 1 }, 13, 3)]
        [InlineData(new[] { 5, 5, 5, 5, 3 }, 23, 5)]
        public void FourOfAKind(int[] roll, int expectedScore, int number)
        {

            var game = new Game();
            var score = game.CalculateFourOfAKind(roll, number);

            Assert.Equal(expectedScore, score);

        }

        [Theory]
        [InlineData(new[] { 2, 2, 2, 3, 3 }, 12, 2)]
        [InlineData(new[] { 3, 3, 3, 5, 1 }, 15, 3)]
        [InlineData(new[] { 5, 5, 5, 4, 3 }, 22, 5)]
        public void ThreeOfAKind(int[] roll, int expectedScore, int number)
        {

            var game = new Game();
            var score = game.CalculateThreeOfAKind(roll, number);

            Assert.Equal(expectedScore, score);

        }


    }
}
