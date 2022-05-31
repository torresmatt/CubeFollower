using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Transform _transform;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = transform;
    }

    private void Update()
    {
        _transform.Rotate(_rigidbody.velocity * -1);
    }
}