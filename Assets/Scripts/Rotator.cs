using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Rotate(_rigidbody.velocity * -1);
    }
}