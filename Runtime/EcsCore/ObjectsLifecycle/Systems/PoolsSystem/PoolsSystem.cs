using UnityEngine;
using Leopotam.Ecs;


namespace BruLibrary
{
    public class PoolsSystem : IEcsInitSystem, IEcsDestroySystem
    {
        private readonly EcsWorld world = default;
        private readonly EcsEntityGameObjectFactory entityGameObjectFactory = default;

        private readonly PrefabsLookup prefabsLookup = default;
        private readonly PoolCapacitiesProvider poolCapacitiesProvider = default;

        private readonly PoolsRootsData poolsRootsData = default;


        public void Init()
        {
            entityGameObjectFactory.Init(
                prefabsLookup,
                poolCapacitiesProvider.GetPoolCapacities(),
                world,
                poolsRootsData.Root,
                poolsRootsData.PoolsRoot);
            
            Debug.Log("Pools Inited");            
        }


        public void Destroy()
        {
            Debug.Log("Destroy Pools [Do nothing for now]");
        }
    }
}