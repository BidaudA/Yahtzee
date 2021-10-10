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

        public int CalculateTwos(int[] roll)
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

        public int CalculateThrees(int[] roll)
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

        public int CalculateFours(int[] roll)
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

        public int CalculateFives(int[] roll)
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

        public int CalculateSix(int[] roll)
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

    }
}
