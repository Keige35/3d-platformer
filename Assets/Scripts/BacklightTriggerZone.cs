using UnityEngine;

public class BacklightTriggerZone : MonoBehaviour
{
    MeshRenderer meshRenderer;
    private void OnTriggerEnter(Collider other)
    {
        meshRenderer = other.GetComponent<MeshRenderer>();
        meshRenderer.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        meshRenderer = other.GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }
}
