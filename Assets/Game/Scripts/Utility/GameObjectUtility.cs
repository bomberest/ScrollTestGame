using System.Collections.Generic;
using ScrollTest.Extensions;
using Unity.Mathematics;
using UnityEngine;

namespace ScrollTest.Utility
{
    public static class GameObjectUtility
    {
        public static void Populate<T>(ICollection<T> instances, GameObject prefab, Transform root, int count)
        {
            var required = math.clamp(count - instances.Count, 0, count);

            for (var i = 0; i < required; i++)
            {
                var instance = Object.Instantiate(prefab, root, false);
                instance.transform.Reset();
                var itemView = instance.GetComponent<T>();

                instances.Add(itemView);
            }
        }
    }
}