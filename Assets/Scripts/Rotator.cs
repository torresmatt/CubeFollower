using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{

    public Rigidbody rb;
    
    // Update is called once per frame
    void Update () {
        // rotate the cube in the direction the rigidbody is moving
        transform.Rotate(rb.velocity);
    }
}
