using UnityEngine;

public class ScreenZoom : MonoBehaviour
{
    [SerializeField] private float _screenSizeChangeAmount = 10;

    private Camera _camera;
    
    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        var scrollWheelAxis = Input.GetAxis("Mouse ScrollWheel");
        
        if (scrollWheelAxis == 0) return;
        
        var cameraSize = _camera.orthographicSize;
        cameraSize -= scrollWheelAxis * _screenSizeChangeAmount;
        cameraSize = Mathf.Clamp(cameraSize, 1, 50);
        
        _camera.orthographicSize = cameraSize;
    }
}