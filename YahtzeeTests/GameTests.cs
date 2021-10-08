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

    }
}
