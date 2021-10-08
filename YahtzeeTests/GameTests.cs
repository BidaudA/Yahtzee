using Xunit;
using Yahtzee.Models;
using System.Collections.Generic;

namespace YahtzeeTests
{
    public class GameTests
    {

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new[] { 1, 2, 1, 4, 5 }, 2)]
        [InlineData(new[] { 1, 2, 1, 4, 1 }, 3)]
        [InlineData(new[] { 2, 2, 3, 4, 5 }, 0)]
        public void CalculatedOnes(int[] roll, int expectedScore)
        {
            var game = new Game();
            var score = game.CalculateOnes(roll);

            Assert.Equal(expectedScore, score);

        }


        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new[] { 1, 2, 1, 4, 5 }, 2)]
        [InlineData(new[] { 1, 2, 1, 4, 1 }, 2)]
        [InlineData(new[] { 2, 2, 3, 4, 5 }, 4)]
        public void CalculatedTwos(int[] roll, int expectedScore)
        {

            var game = new Game();
            var score = game.CalculateTwos(roll);

            Assert.Equal(expectedScore, score);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 3, 4, 5 }, 6)]
        [InlineData(new[] { 1, 2, 1, 4, 5 }, 0)]
        [InlineData(new[] { 1, 2, 1, 3, 1 }, 3)]
        [InlineData(new[] { 2, 2, 3, 3, 3 }, 9)]
        public void CalculatedThrees(int[] roll, int expectedScore)
        {

            var game = new Game();
            var score = game.CalculateThrees(roll);

            Assert.Equal(expectedScore, score);
        }


        


    }
}
