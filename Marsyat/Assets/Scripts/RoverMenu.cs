using UnityEngine;
using UnityEngine.InputSystem;

public class RoverMenu : MonoBehaviour
{
    public InputActionReference menuButtonAction;
    public GameObject popupUI;
    private void Start()
    {
        popupUI.SetActive(false);
    }

    void OnEnable()
    {
        menuButtonAction.action.performed += TogglePopup;
        menuButtonAction.action.Enable();
    }

    void OnDisable()
    {
        menuButtonAction.action.performed -= TogglePopup;
        menuButtonAction.action.Disable();
    }

    void TogglePopup(InputAction.CallbackContext ctx)
    {
        popupUI.SetActive(!popupUI.activeSelf);
    }
}
