﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Divide(int DividentA, int DividentB)
        {
            if(D)
            {
                throw new ArgumentException();
            }
            return DividentA / DividentB;
        }

    }
}
