using System;

namespace NetStandard13Library
{
    public class Addition
    {
        public int Add(int x, int y)
        {
            if (x == int.MaxValue || x == int.MinValue)
                throw new ArgumentException("Cannot be MinValue or MaxValue", nameof(x));

            if (y == int.MaxValue || y == int.MinValue)
                throw new ArgumentException("Cannot be MinValue or MaxValue", nameof(y));

            return x + y;
        }
    }
}
