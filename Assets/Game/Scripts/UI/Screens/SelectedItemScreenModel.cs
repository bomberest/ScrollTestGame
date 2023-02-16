using ScrollTest.Items;
using ScrollTest.UI.Core;

namespace ScrollTest.UI.Screens
{
    public class ItemScreenModel : ScreenModel
    {
        public int Amount { get; }
        public Item Item { get; }

        public ItemScreenModel(Item item, int amount)
        {
            Amount = amount;
            Item = item;
        }
    }
}