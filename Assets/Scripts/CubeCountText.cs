using UnityEngine;
using UnityEngine.UI;

public class CubeCountText : MonoBehaviour
{
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = "Cube Count: " + CubeCounter.CubeCount;
    }
}