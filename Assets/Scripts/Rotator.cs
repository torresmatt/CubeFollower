using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{

    public Rigidbody rb;
    
    // Update is called once per frame
    void Update () {
        // rotate the cube in the direction the rigidbody is moving
        // had to invert it so it would look more natural spinning "toward" pointer instead of away
        transform.Rotate(rb.velocity * -1);
    }
}
