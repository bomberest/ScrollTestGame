using UnityEngine;

namespace ScrollTest.UI.Core
{
    public abstract class Screen<T> : MonoBehaviour where T : ScreenModel
    {
        public void Show(T screenModel)
        {
            gameObject.SetActive(true);

            OnShow(screenModel);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }


        // ReSharper disable once MemberCanBeProtected.Global
        public virtual void OnShow(T screenModel)
        {
        }

        // ReSharper disable once VirtualMemberNeverOverridden.Global
        public virtual void OnHide()
        {
        }
    }
}