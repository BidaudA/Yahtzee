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

        public object CalculateFours(int[] roll)
        {
            var result = 0;
            foreach (var item in roll)
            {

                if(item == 4)
                {
                    result = result + 4;
                }

            }

            return result;
        }

        public object CalculateFives(int[] roll)
        {
            var result = 0;
            foreach (var item in roll)
            {

                if(item == 5)
                {
                    result = result + 5;
                }

            }

            return result;
        }

        public object CalculateSix(int[] roll)
        {
            var result = 0;
            foreach (var item in roll)
            {

                if(item == 6)
                {
                    result = result + 6;
                }

            }

            return result;
        }

    }
}
