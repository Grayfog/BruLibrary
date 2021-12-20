using System;

namespace BruLibrary
{
    [Serializable]
    public struct PrefabsGroup
    {
        public string Name;
        public PrefabPair[] Pairs;


        public PrefabsGroup(string name)
        {
            Name = name;
            Pairs = new PrefabPair[0];
        }
    }
}