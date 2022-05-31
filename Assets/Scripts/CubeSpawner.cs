using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabToSpawn;
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0)) return;

        var mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.Set(mousePos.x, mousePos.y, 0);
        Instantiate(_prefabToSpawn, mousePos, Quaternion.identity);
        CubeCounter.CubeCount++;
    }
}