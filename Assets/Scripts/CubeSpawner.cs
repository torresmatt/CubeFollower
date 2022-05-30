using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;


    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.Set(mousePos.x, mousePos.y, 0);
        Instantiate(prefabToSpawn, mousePos, Quaternion.identity);
        CubeCounter.CubeCount++;
    }
}