using System;

namespace FixtureDemo.Domain.Services
{
    public class IntCalculator
    {
        public int Value { get; set; }
        public void Subtract(int number)
        {
            Value -= number;
        }

        public void Add(int number)
        {
            Value += number;
        }
    }
}
