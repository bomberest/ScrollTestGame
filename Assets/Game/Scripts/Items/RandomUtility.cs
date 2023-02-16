using System.Collections.Generic;
using System.Linq;
using ScrollTest.Extensions;
using UnityEngine;

namespace ScrollTest.Items
{
    public static class RandomUtility
    {
        public static int GetRandomIndexByChance(IEnumerable<float> list)
        {
            var shuffled = list.ToList().Shuffle().ToList();

            for (var index = 0; index < shuffled.Count; index++)
            {
                var itemChance = shuffled[index];
                if (Random.value < itemChance) continue;

                return index;
            }

            return 0;
        }
    }
}