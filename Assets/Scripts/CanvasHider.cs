using UnityEngine;

public class CanvasHider : MonoBehaviour
{
    private void Update()
    {
        if (CubeCounter.CubeCount > 0) gameObject.SetActive(false);
    }
}