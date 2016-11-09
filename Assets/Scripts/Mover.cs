using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public Camera camera;
    public float maxForce;
    public float maxVelocity;
    public Rigidbody rb;
    public float dist;
		
    void Start()
    {
        camera = Camera.main;
    }

	// Update is called once per frame
	void Update () 
	{
		// store mouse position in terms of screen cooordinates
        	Vector3 mousePos = Input.mousePosition;
		
		// store this transform (the cube's) in terms of screen coordinates
       		Vector3 cubePos = camera.WorldToScreenPoint(transform.position);
		
		// store a vector representing the vector between the mouse and the transform of this object (cube)		
        	Vector3 force = mousePos - cubePos;
		
		// store the distance between the mouse and the cube
        	dist = Vector3.Distance(mousePos, cubePos);
		
		// reduce the magnitude of the force vector to whatever the maxForce variable is set to in the editor
        	force = Vector3.ClampMagnitude(force, maxForce);
		
		// add the force to the cube
        	rb.AddForce(force);

		// is the cube closer than 20 pixels to the mouse?
        	if (dist < 20)
        	{
			// clamp the velocity to a value determined by the distance between the mouse and the cube
			// divide by 100 to make sure the velocity is very small (we dont want to go shooting past the pointer)
            		rb.velocity = Vector3.ClampMagnitude(rb.velocity, dist / 100);
            		return;
        	}
		
		// clamp velocity by distance divided by 10 to reduce it slightly but not too much
        	rb.velocity = Vector3.ClampMagnitude(rb.velocity, dist / 10);
	}
}
