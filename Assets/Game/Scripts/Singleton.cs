using UnityEngine;

namespace ScrollTest
{
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public static T Instance { get; private set; }

        protected virtual void Awake()
        {
            Instance = this as T;
        }
    }
}