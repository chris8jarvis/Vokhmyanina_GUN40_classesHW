using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    public struct Interval
    {
        private const int DefaultMaxValue = 10;
       public int Min
        {
            get; 
        }

        public int Max
        {
            get; 
        }

        public int Get
        {
            get
            {
                var rand = new Random();
                return rand.Next(Min, Max + 1); // Max+1 so the max number is included, as well as the min number
            }
        } 
        public Interval(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                int buff = minValue;
                minValue = maxValue;
                maxValue = buff;
                Console.WriteLine($"Min bound: {minValue}, max bound: {maxValue}");
                Console.WriteLine($"Incorrect input");
            }
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine($"Min bound cannot be less than 0. Min bound now is: {minValue}");
                Console.WriteLine($"Incorrect input");
            }
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine($"Incorrect input");
            }
            if (minValue == maxValue)
            {
                maxValue = maxValue + DefaultMaxValue;
                Console.WriteLine($"Min bound and Max bound cannot be equal. Max bound now is: {maxValue}");
                Console.WriteLine($"Incorrect input");
            }
            if(maxValue <= 0)
            {
                maxValue = DefaultMaxValue;
            }
        }
    }
}
