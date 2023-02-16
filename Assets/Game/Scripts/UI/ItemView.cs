using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScrollTest.UI
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Image icon;
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text countText;
        [SerializeField] private string countFormat = "x{0}";

        public void Set(Sprite sprite, string nameValue, int count)
        {
            icon.overrideSprite = sprite;
            nameText.text = nameValue;
            countText.text = string.Format(countFormat, count);
        }

        public void Highlight()
        {
            icon.color = Color.red;
        }
        
        public void Unhighlight()
        {
            icon.color = Color.white;
        }
    }
}