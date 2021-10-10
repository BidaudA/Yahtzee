﻿using Xunit;
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



    }
}
