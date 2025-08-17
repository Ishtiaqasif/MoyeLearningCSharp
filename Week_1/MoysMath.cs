using System.ComponentModel.Design;

namespace Week_1
{
    internal static class MoyesMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return input * -1;
            }

            return input;
        }

        public static int Square(int input)
        {
            return input * input;
        }

        public static int Exponential(int input, int power)
        {
            int res = 1;

            for (int i = 1; i <= power; i++)
            {
                res *= input;
            }

            return res;
        }

        public static int Sum(int[] a)
        {
            int sum = 0;

            foreach (int item in a)
            {
                sum += item;
            }

            return sum;
        }
    }
}