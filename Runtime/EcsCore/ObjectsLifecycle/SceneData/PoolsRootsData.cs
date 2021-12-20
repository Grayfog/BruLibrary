using System;
using UnityEngine;


namespace BruLibrary
{
    [Serializable]
    public class PoolsRootsData
    {
        public GameObject Root = default;
        public GameObject PoolsRoot = default;


        public void CheckData()
        {
#if DEBUG
            Debug.Assert(Root != null);
            Debug.Assert(PoolsRoot != null);
#endif
        }
    }
}