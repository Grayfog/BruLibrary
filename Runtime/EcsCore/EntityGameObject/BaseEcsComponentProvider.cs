using UnityEngine;


namespace BruLibrary
{
    [RequireComponent(typeof(EcsEntityGameObject))]
    public abstract class BaseEcsComponentProvider : MonoBehaviour
    {
        public abstract void AddOrResetComponent(EcsEntityGameObject entityGameObject);
    }
}