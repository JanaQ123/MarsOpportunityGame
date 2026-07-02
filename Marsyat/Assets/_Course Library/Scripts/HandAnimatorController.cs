using UnityEngine;
using UnityEngine.InputSystem;
public class HandAnimatorController : MonoBehaviour
{
    public InputActionProperty triggerAction;
    public InputActionProperty gripAction;
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float triggerValue = triggerAction.action.ReadValue<float>();
        float gripValue = gripAction.action.ReadValue<float>();

        anim.SetFloat("Trigger", triggerValue);
        anim.SetFloat("Grip", gripValue);
    }
}