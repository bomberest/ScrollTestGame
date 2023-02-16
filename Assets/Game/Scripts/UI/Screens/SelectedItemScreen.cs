using ScrollTest.UI.Core;

namespace ScrollTest.UI.Screens
{
    public class ItemScreen : Screen<ItemScreenModel>
    {
        public ItemView item;

        public override void OnShow(ItemScreenModel screenModel)
        {
            item.Set(screenModel.Item.icon, screenModel.Item.nameKey, screenModel.Amount);
        }

        public void Ok()
        {
            Hide();

            ScreenManager.Instance.ShowItemsScreen(new ScreenModel());
        }
    }
}