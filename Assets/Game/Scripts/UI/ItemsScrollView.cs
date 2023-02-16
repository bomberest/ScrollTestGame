using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using ScrollTest.Extensions;
using ScrollTest.Items;
using ScrollTest.Utility;
using UnityEngine;
using UnityEngine.UI;

namespace ScrollTest.UI
{
    public class ItemsScrollView : MonoBehaviour
    {
        private readonly List<ItemView> _instances = new();

        public ScrollRect scrollRect;
        public RectTransform itemsRoot;
        public RectTransform viewPort;
        public ItemView itemViewPrefab;
        public int populationCount = 100;
        public int targetIndex = 80;

        public float animationTime;

        private void Awake()
        {
            _instances.Add(itemViewPrefab);
        }

        public void Fill(DropList dropList)
        {
            var count = populationCount;

            GameObjectUtility.Populate(_instances, itemViewPrefab.gameObject, itemsRoot, count);

            var shuffled = dropList.items.Shuffle().ToList();

            for (var i = 0; i < count; i++)
            {
                var view = _instances[i];
                var data = shuffled[i % shuffled.Count];
                var item = data.item;
                var amount = data.amount;

                view.Set(item.icon, item.nameKey, amount);
            }
        }

        public void SetTarget(Item item, int count)
        {
            var itemView = GetTargetItemView();
            itemView.Set(item.icon, item.nameKey, count);
        }

        private ItemView GetTargetItemView()
        {
            return _instances[targetIndex];
        }

        public void Animate(float delay, Action callback)
        {
            ResetPosition();

            var targetItem = GetTargetItemView();
            var rectContent = scrollRect.content;
            var targetLocalPosition = rectContent.parent.InverseTransformPoint(targetItem.transform.position);
            var targetOffset = rectContent.position - targetLocalPosition;
            var viewPortWidth = viewPort.rect.width;
            var contentLocalPosition = rectContent.localPosition.x + targetOffset.x + viewPortWidth / 2f;

            DOTween.Sequence()
                .Append(rectContent.DOLocalMoveX(contentLocalPosition, animationTime, true))
                .AppendInterval(delay)
                .AppendCallback(() => { callback?.Invoke(); });
        }

        public void ResetPosition()
        {
            scrollRect.horizontalNormalizedPosition = 0;
        }
    }
}