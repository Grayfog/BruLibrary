using UnityEngine;
using Leopotam.Ecs;


namespace BruLibrary
{
    public class RegistrationEntitiesSystem : IEcsInitSystem
    {
        private readonly EcsEntityGameObjectFactory ecsEntityGameObjectFactory = default;


        public void Init()
        {
            Debug.Log($"Registering Entities...");

            var entitiesGameObjects = Object.FindObjectsOfType<EcsEntityGameObject>();
            foreach (var entityGameObject in entitiesGameObjects)
            {
                ecsEntityGameObjectFactory.RegisterEntity(entityGameObject);
            }

            Debug.Log($"Entities Registered. Total: {entitiesGameObjects.Length}");
        }
    }
}