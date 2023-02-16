using ScrollTest.UI.Core;
using UnityEngine;

namespace ScrollTest
{
    public class EntryPoint : MonoBehaviour
    {
        private void Start()
        {
            ScreenManager.Instance.ShowItemsScreen(new ScreenModel());
        }
    }
}