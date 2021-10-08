using System;
namespace Yahtzee.Models
{
    public class Roll
    {
        

        public Roll(Dice dice1, Dice dice2, Dice dice3, Dice dice4, Dice dice5)
        {
            Dice2 = dice2;
            Dice3 = dice3;
            Dice4 = dice4;
            Dice5 = dice5;
        }

        public Dice Dice2 { get; }
        public Dice Dice3 { get; }
        public Dice Dice4 { get; }
        public Dice Dice5 { get; }
    }
}
