using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ScanInputHandler : MonoBehaviour
{
    [SerializeField] private InputActionReference scanButton; // drag "Activate" here
    [SerializeField] private XRRayInteractor scanRay; // your dedicated scan ray

    void OnEnable() => scanButton.action.performed += OnScanPressed;
    void OnDisable() => scanButton.action.performed -= OnScanPressed;

    void OnScanPressed(InputAction.CallbackContext ctx)
    {
        if (scanRay.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            var scannable = hit.collider.GetComponent<ScannableObject>();
            if (scannable != null && scannable.IsHovered)
                scannable.TriggerScan();
        }
    }
}