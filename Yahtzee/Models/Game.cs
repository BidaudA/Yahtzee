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

        public object CalculateTwos(int[] roll)
        {
            var result = 0;

            foreach (var item in roll)
            {
                if (item == 2)
                {
                    result = result + 2;
                }

            }

            return result;
        }

        public object CalculateThrees(int[] roll)
        {
            var result = 0;
            foreach (var item in roll)
            {

                if(item == 3)
                {
                    result = result + 3;
                }

            }

            return result;
        }

    }
}
