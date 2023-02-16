using System.Collections.Generic;
using System.Linq;

namespace ScrollTest.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(_ => UnityEngine.Random.value);
        }
    }
}