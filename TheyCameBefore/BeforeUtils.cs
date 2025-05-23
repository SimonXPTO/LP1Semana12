using System;
using System.Collections.Generic;
using System.Linq;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item) where T : struct, IComparable<T>
        {
            return items.Where(x => x.CompareTo(item) < 0);
        }
    }
}
