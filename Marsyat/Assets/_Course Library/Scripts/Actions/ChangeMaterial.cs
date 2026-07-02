using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

/// <summary>
/// This script makes it easier to toggle between a new material, and the objects original material.
/// </summary>
public class ChangeMaterial : MonoBehaviour
{
    [Tooltip("The material that's switched to.")]
    public Material otherMaterial = null;
    Material currentColor;

    private bool usingOther = false;
    private MeshRenderer meshRenderer = null;
    private Material originalMaterial = null;
    void Start()
    {
        currentColor = this.GetComponent<MeshRenderer>().material;
    }
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.material;
    }

    public void SetOtherMaterial()
    {
        usingOther = true;
        meshRenderer.material = otherMaterial;
    }

    public void SetOriginalMaterial()
    {
        usingOther = false;
        meshRenderer.material = originalMaterial;
    }

    public void ToggleMaterial()
    {
        usingOther = !usingOther;

        if(usingOther)
        {
            meshRenderer.material = otherMaterial;
        }
        else
        {
            meshRenderer.material = originalMaterial;
        }
    }
    public void SetNewMaterial(SelectEnterEventArgs args)
    {
        
        this.GetComponent<MeshRenderer>().material = args.interactorObject.transform.GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void OnSelectExited(SelectExitEventArgs args)
    {
        args.interactorObject.transform.GetComponent<XRBaseInteractor>().allowSelect = true;
    }
}
