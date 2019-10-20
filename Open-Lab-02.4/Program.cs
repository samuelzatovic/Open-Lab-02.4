using System;

namespace Open_Lab_02._4
{
    class Program
    {
        public static int GetLegsCount(int chickens, int cows, int pigs)
        {
            int legs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return legs;
        }
    }
}
