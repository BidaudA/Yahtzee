using Xunit;
using Yahtzee.Models;
using System.Collections.Generic;

namespace YahtzeeTests
{
    public class GameTests
    {

        [Fact]
        public void DiceSuccessfullCreated()
        {
            var dice1 = new Dice();
            var dice2 = new Dice();
            var dice3 = new Dice();
            var dice4 = new Dice();
            var dice5 = new Dice();

            var roll = new Roll(dice1, dice2, dice3, dice4, dice5);

            Assert.NotNull(roll);
            
        }

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

    }
}
