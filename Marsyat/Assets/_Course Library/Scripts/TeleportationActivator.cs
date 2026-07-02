using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationActivator : MonoBehaviour
{

    public XRRayInteractor teleportInteractor;

    public InputActionProperty teleportActivatorAction;

    void Start()
    {
        // Disable ray at the beginning
        teleportInteractor.gameObject.SetActive(false);

        // Subscribe to the performed event (button pressed)
        teleportActivatorAction.action.performed += OnActionPerformed;
    }

    private void OnActionPerformed(InputAction.CallbackContext obj)
    {

        teleportInteractor.gameObject.SetActive(true);
    }

    void Update()
    {
        // When button is released → disable the ray
        if (teleportActivatorAction.action.WasReleasedThisFrame())
        {

            teleportInteractor.gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        // Clean up subscription
        teleportActivatorAction.action.performed -= OnActionPerformed;
    }
}