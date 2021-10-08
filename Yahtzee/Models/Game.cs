using System;
namespace Yahtzee.Models
{
    public class Game
    {
        public Game()
        {
        }

        public int CalculateOnes(int[] roll)
        {
            var result = 0;

            foreach (var item in roll)
            {
                if (item == 1)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
