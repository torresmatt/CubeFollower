using Unity.Entities;
using UnityEngine;

namespace Components
{
    [GenerateAuthoringComponent]
    public struct SpawnerComponent : IComponentData
    {
        public Entity EntityToSpawn;
    }
}