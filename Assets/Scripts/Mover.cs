using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public Camera camera;
    public float maxForce;
    public float maxVelocity;
    public Rigidbody rb;
    public float dist;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mousePos = Input.mousePosition;
        Vector3 cubePos = camera.WorldToScreenPoint(transform.position);

        Vector3 force = mousePos - cubePos;
        dist = Vector3.Distance(mousePos, cubePos);

        force = Vector3.ClampMagnitude(force, maxForce);

        rb.AddForce(force);

        if (dist < 20)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, dist / 100);
            return;
        }

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, dist / 10);
	}
}
