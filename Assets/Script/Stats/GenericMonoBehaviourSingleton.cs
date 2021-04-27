using System;
using UnityEngine;

namespace Script.Stats
{
    public class GenericMonoBehaviourSingleton<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }
        
        
        protected void Start()
        {
            DontDestroyOnLoad(this);
        }

        protected virtual void OnValidate()
        {
            if (Instance == null)
            {
                Instance = this as T;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}

