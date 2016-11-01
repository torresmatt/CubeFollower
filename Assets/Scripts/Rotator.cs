using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        transform.Rotate(rb.velocity);
    }
}
