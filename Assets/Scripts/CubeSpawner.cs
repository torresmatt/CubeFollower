using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

    public GameObject prefabToSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.Set(mousePos.x, mousePos.y, 0);
            Instantiate(prefabToSpawn, mousePos, Quaternion.identity);
            CubeCounter.cubeCount++;
        }


	}
}
