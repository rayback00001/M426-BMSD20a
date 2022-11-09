using System;
using System.Collections.Generic;
using System.Transactions;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int>numbers)
        {
            numbers.Sort();

            if(numbers.Count % 2 == 0)
            {
                return (double)(numbers[])
            }
        }
    }
}
