using System;
using System.Collections.Generic;

namespace CSharp7.Patterns
{
    public class Customer
    {
        private static Random _random = new Random();

        public static IEnumerable<Customer> GetCustomers()
        {
            var count = 50 + (int)(_random.NextDouble() * 100);
            while (count-- > 0)
            {
                yield return new Customer();
            }
        }

        public double CalculateBonus()
        {
            // Some complicated logic
            return _random.NextDouble() * 100;
        }
    }
}
