using Components;
using Unity.Entities;
using UnityEngine;

namespace Systems
{
    public class CubeSpawnSystem : SystemBase
    {
        private Camera _camera;

        protected override void OnStartRunning()
        {
            _camera = Camera.main;
        }

        protected override void OnUpdate()
        {
            if (!Input.GetMouseButton(0)) return;

            var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
            mousePos.Set(mousePos.x, mousePos.y, 0);

            Entities.ForEach((SpawnerComponent spawnerComponent) =>
            {
                EntityManager.Instantiate(spawnerComponent.EntityToSpawn);

            }).WithStructuralChanges().WithoutBurst().Run();
            
            CubeCounter.CubeCount++;
        }
    }
}