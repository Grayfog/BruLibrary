using UnityEngine;


namespace BruLibrary
{
    public class PoolCapacitiesProvider : MonoBehaviour
    {
        [SerializeField] private PoolCapacity[] poolCapacities = null;


        public PoolCapacity[] GetPoolCapacities()
        {
            return poolCapacities;
        }
    }
}