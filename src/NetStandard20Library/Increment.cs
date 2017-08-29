using System;

namespace NetStandard20Library
{
    public static class Increment
    {
        public static int AddOne(this int x) => ++x;
    }
}
