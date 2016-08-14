using System;

namespace Kata.Calculator
{
    public class FibonacciOutOfRangeException : ArgumentOutOfRangeException
    {
        public FibonacciOutOfRangeException() : base(@"i doit être positif")
        {
        }
    }
}