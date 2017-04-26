using System;
using System.Threading.Tasks;

namespace NetStandard16Library
{
    public class AsyncMethods
    {
        public async Task<bool> IsTrueAsync() =>
            await Task.FromResult(true);
    }
}
