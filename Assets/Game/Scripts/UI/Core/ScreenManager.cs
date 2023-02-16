using ScrollTest.UI.Screens;
using UnityEngine;

namespace ScrollTest.UI.Core
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public ItemsScrollScreen itemsScreen;
        public ItemScreen itemScreen;

        private Screen _current;

        protected override void Awake()
        {
            base.Awake();
            
            itemsScreen.Hide();
            itemScreen.Hide();
        }

        public void ShowItemScreen(ItemScreenModel model)
        {
            itemScreen.Show(model);
        }

        public void ShowItemsScreen(ScreenModel model)
        {
            itemsScreen.Show(model);
        }
    }
}