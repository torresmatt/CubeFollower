using UnityEngine;
using System.Collections;

public class ScreenZoom : MonoBehaviour {

    private Camera camera;
    private float scroll;

    public float scrollSpeed = 10;

	// Use this for initialization
	void Start () {
        camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0)
        {
            camera.orthographicSize -= scroll * scrollSpeed;
            camera.orthographicSize = Mathf.Clamp(camera.orthographicSize, 1, 50);
        }
	}
}
