using System;
using UnityEngine;


namespace BruLibrary
{
    [Serializable]
    public struct Ref<T> where T : UnityEngine.Object
    {
        [HideInInspector]
        public T Value;
    }
}