using Leopotam.Ecs;

namespace BruLibrary
{
    public class DestroySystem : IEcsRunSystem
    {
        private readonly EcsEntityGameObjectFactory entityGameObjectFactory = default;

        private readonly EcsFilter<Ref<EcsEntityGameObject>, DestroyRequest> destroySignals = null;


        public void Run()
        {
            foreach (var signalIndex in destroySignals)
            {
                var entityGameObject = destroySignals.Get1(signalIndex).Value;
                entityGameObjectFactory.Destroy(entityGameObject);
            }
        }
    }
}