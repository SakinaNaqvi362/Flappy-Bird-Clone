using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null)
        {
            Debug.LogError("MeshRenderer component missing on " + gameObject.name);
            enabled = false; // Disable the script if no MeshRenderer
        }
    }

    private void Update()
    {
        if (meshRenderer != null && meshRenderer.material != null)
        {
            meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
        }
    }
}