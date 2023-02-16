using UnityEngine;

namespace ScrollTest.Extensions
{
    public static class TransformExtensions
    {
        public static void Reset(this Transform transform)
        {
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
            transform.localPosition = Vector3.zero;
        }
    }
}