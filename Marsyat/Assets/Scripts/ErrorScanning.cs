using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using System.Collections;

public class ErrorScanning : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    private Renderer targetRenderer;
    private Material scanMat;
    private bool isHovered = false;
    private bool isScanned = false;
    [Header("Info Panel")]
   
    public GameObject errorCanvas;
    void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.hoverEntered.AddListener(_ => OnHoverEntered());
        interactable.hoverExited.AddListener(_ => OnHoverExited());

    
    }

    void OnHoverEntered()
    {
        isHovered = true;
        // optional: if you kept a Highlighted property for pre-scan hover glow
    }

    void OnHoverExited()
    {
        isHovered = false;
    }

    public bool IsHovered => isHovered;
    public bool IsScanned => isScanned;

    public void TriggerScan()
    {
        UIMessageController.Instance.ShowMessage(2);
        errorCanvas.SetActive(true);
        MessageMessageManager.Instance.ShowMessage(2);

    }


}