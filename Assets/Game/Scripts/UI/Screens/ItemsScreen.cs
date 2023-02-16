using ScrollTest.Items;
using ScrollTest.UI.Core;
using UnityEngine;

namespace ScrollTest.UI.Screens
{
    public class ItemsScrollScreen : Screen<ScreenModel>
    {
        public ItemsScrollView itemsScrollView;
        public DropList dropList;

        public float delay = 1f;

        private bool _inProgress = false;

        private void Start()
        {
            itemsScrollView.ResetPosition();
        }

        public override void OnShow(ScreenModel screenModel)
        {
            itemsScrollView.Fill(dropList);
        }

        public void Play()
        {
            if (_inProgress)
            {
                return;
            }

            _inProgress = true;

            var random = dropList.GetRandom();

            itemsScrollView.SetTarget(random.item, random.amount);
            itemsScrollView.Animate(delay, () =>
            {
                Debug.Log("Complete!");

                _inProgress = false;

                Hide();
                ScreenManager.Instance.ShowItemScreen(new ItemScreenModel(random.item, random.amount));
            });
        }
    }
}