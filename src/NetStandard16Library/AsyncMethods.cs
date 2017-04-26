using System;
using System.Threading.Tasks;

namespace NetStandard16Library
{
    public class AsyncMethods
    {
        public async Task<bool> IsTrueAsync() =>
            await Task.FromResult(true);

        public async Task<int> AddAfterDelay(int x, int y)
        {
            if (x == int.MaxValue || x == int.MinValue)
                throw new ArgumentException("Cannot be MinValue or MaxValue", nameof(x));

            await Task.Delay(10);

            if (y == int.MaxValue || y == int.MinValue)
                throw new ArgumentException("Cannot be MinValue or MaxValue", nameof(y));


            return x + y;
        }
    }
}
