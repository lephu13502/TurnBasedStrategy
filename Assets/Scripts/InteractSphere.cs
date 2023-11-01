using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSphere : MonoBehaviour
{
    [SerializeField] private Material greenMaterial;
    [SerializeField] private Material redMaterial;
    [SerializeField] private MeshRenderer meshRenderer;
    private bool isGreen;

    private void Start()
    {
        SetColorGreen();
    }

    private void SetColorGreen()
    {
        meshRenderer.material = greenMaterial;
        isGreen = true;
    }
    private void SetColorRed()
    {
        meshRenderer.material = redMaterial;
        isGreen = false;
    }
}
