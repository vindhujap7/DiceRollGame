using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    internal class Dice
    {
        private readonly Random _random;
        private readonly int _sideCount;

        public Dice(Random random, int sideCount)
        {
            _random = random;
            _sideCount = sideCount;
        }

        public int Roll()
        {
            return _random.Next(1, _sideCount + 1);
        }
    }
}
