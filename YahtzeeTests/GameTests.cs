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
        [InlineData(new[] {2, 2, 2, 2, 3}, 11 )]
        [InlineData(new[] { 3, 3, 3, 3, 1 }, 13)]
        [InlineData(new[] { 5, 5, 5, 5, 3 }, 23)]
        public void FourOfAKind(int[] roll, int expectedScore)
        {

            var game = new Game();
            var score = game.CalculateFourOfAKind();

            Assert.Equal(expectedScore, score);

        }


    }
}
