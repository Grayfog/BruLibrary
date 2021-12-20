using Leopotam.Ecs;
using UnityEngine;


namespace BruLibrary
{
    public class EcsEntityGameObject : MonoBehaviour
    {
        public BaseEcsComponentProvider[] ComponentsProviders = new BaseEcsComponentProvider[0];
        public int PrefabId = -1;
        public EcsEntity Entity = default;
        public int IndexInPool = -1;
    }
}