using Components;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

namespace Systems
{
    public class MoveCubeSystem : SystemBase
    {
        private Camera _camera;
        
        protected override void OnStartRunning()
        {
            _camera = Camera.main;
        }

        protected override void OnUpdate()
        {
            var currentMousePositionsScreen = Input.mousePosition;
            var currentMousePositionWorld = new float3(_camera.ScreenToWorldPoint(currentMousePositionsScreen));

            var deltaTime = Time.DeltaTime;

            Entities.ForEach((Translation translation, MoveComponent moveComponent,
                ref PhysicsVelocity physicsVelocity) =>
            {
                var currentCubePosition = translation.Value.xyz;

                currentCubePosition.z = 0;
                currentMousePositionWorld.z = 0;

                var direction = currentMousePositionWorld - currentCubePosition;

                physicsVelocity.Linear += direction * moveComponent.Speed * deltaTime;
            }).Schedule();

        }
    }
}