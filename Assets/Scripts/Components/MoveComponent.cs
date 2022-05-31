using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Components
{
    [GenerateAuthoringComponent]
    public struct MoveComponent : IComponentData
    {
        [HideInInspector] public float3 TargetPosition;
        public float Speed;
    }
}