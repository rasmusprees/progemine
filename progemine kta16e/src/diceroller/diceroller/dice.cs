using System;
using System.Collections.Generic;
using System.Text;

namespace diceroller
{
    using System;

    public class dice
    {
        private Random Random { get; } = new Random();

        public int Roll(int sides)
        {
            var random = new Random();

            return this.Random.Next(1, sides + 1); // max value is exclusive, so we have to add +1
        }
    }
}
