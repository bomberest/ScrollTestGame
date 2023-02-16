using UnityEngine;

namespace ScrollTest.Items
{
    [CreateAssetMenu(fileName = "Item", menuName = "Game/Item")]
    public class Item : ScriptableObject
    {
        public string nameKey;
        public Sprite icon;
    }
}