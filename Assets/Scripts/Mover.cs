using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] private float _maxForce;
	[SerializeField] private int _distanceThreshold;
    
    private Camera _camera;
    private Rigidbody _rigidbody;
    
    private void Start()
    {
        _camera = Camera.main;
        _rigidbody = GetComponent<Rigidbody>();
    }

	private void Update () 
	{
        	var mousePos = Input.mousePosition;
		
       		var position = _camera.WorldToScreenPoint(transform.position);
			
        	var forceDirection = mousePos - position;
		
        	var mouseDistance = Vector3.Distance(mousePos, position);
		
        	forceDirection = Vector3.ClampMagnitude(forceDirection, _maxForce);
		
        	_rigidbody.AddForce(forceDirection);

            _distanceThreshold = 20;
            if (mouseDistance < _distanceThreshold)
        	{
            		_rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, mouseDistance / 100);
            		return;
        	}
		
        	_rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, mouseDistance / 10);
	}
}
