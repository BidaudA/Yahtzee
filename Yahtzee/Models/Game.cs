using System;
using System.Linq;

namespace Yahtzee.Models
{
    public class Game
    {
        public Game()
        {
        }

        public int CalculateNumber(int[] roll, int number)
        {
            var result = 0;

            foreach (var item in roll)
            {

                if (item == number)
                {

                    result = result + number;

                }

            }

            return result;
        }

        public int CalculateFourOfAKind(int[] roll, int number)
        {
            var count = roll.Where(n => n.Equals(number)).Select(n => n).Count();
            var result = 0;

            if(count == 4)
            {
                result = roll.Sum();

            }

            return result;

        }

    }
}
