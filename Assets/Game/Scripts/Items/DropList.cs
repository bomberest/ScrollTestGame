using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScrollTest.Items
{
    [CreateAssetMenu(fileName = "DropList", menuName = "Game/DropList")]
    public class DropList : ScriptableObject
    {
        public List<Container> items = new();

        public (Item item, int amount) GetRandom()
        {
            var randomIndex = RandomUtility.GetRandomIndexByChance(
                items.Select(container => container.chance));
            var item = items[randomIndex];
            return (item.item, item.amount);
        }

        [Serializable]
        public class Container
        {
            public Item item;
            [Range(0f, 1f)] public float chance = 1f;
            [Min(1)] public int amount = 1;
        }
    }
}