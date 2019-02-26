using System;
using SnakesAndLadders.Core.Contracts;

namespace SnakesAndLadders.Core
{
    public class DiceService : IDiceService
    {
        private readonly Random _random;

        public DiceService()
        {
            _random = new Random();
        }

        public int RollDie(int maxValue)
        {
            return _random.Next(1, maxValue + 1);
        }
    }
}
