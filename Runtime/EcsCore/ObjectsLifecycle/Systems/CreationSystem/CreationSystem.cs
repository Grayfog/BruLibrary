using Leopotam.Ecs;


namespace BruLibrary
{
    public class CreationSystem : IEcsRunSystem
    {
        private readonly EcsEntityGameObjectFactory entityGameObjectFactory = default;

        private readonly EcsFilter<CreateRequest> createRequestsFilter = default;


        public void Run()
        {
            foreach (var entityIndex in createRequestsFilter)
            {
                var createRequest = createRequestsFilter.Get1(entityIndex);
                entityGameObjectFactory.Create(createRequest.PrefabId, createRequest.Position, createRequest.Rotation, createRequest.Scale);
            }
        }
    }
}