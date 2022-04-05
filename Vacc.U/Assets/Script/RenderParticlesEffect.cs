using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderParticlesEffect : MonoBehaviour
{
    // Here reference the camera component of the particles camera
    [SerializeField] public Camera particlesCamera;

    // Adjust the resolution in pixels
    [SerializeField] public Vector2Int imageResolution = new Vector2Int(256, 256);

    // Reference the RawImage in your UI
    [SerializeField] public RawImage targetImage;

    private RenderTexture renderTexture;

    private void Awake()
    {
        if (!particlesCamera) particlesCamera = GetComponent<Camera>();

        renderTexture = new RenderTexture(imageResolution.x, imageResolution.y, 32);
        particlesCamera.targetTexture = renderTexture;

        targetImage.texture = renderTexture;
    }
}
