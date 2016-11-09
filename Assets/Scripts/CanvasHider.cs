using UnityEngine;
using System.Collections;

public class CanvasHider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (CubeCounter.cubeCount > 0)
            gameObject.SetActive(false);
	}
}
