using UnityEngine;
using UnityEngine.InputSystem;

public class EmotionController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

    

        if (keyboard.digit1Key.wasPressedThisFrame)
            animator.CrossFade("Happy", 0.1f);

        if (keyboard.digit2Key.wasPressedThisFrame)
            animator.CrossFade("Rejected", 0.1f);

        if (keyboard.digit3Key.wasPressedThisFrame)
            animator.CrossFade("Chapa", 0.1f);

        if (keyboard.digit4Key.wasPressedThisFrame)
            animator.CrossFade("DigerAnimasyonAdý", 0.1f);

        if (keyboard.digit0Key.wasPressedThisFrame)
            animator.CrossFade("Idle", 0.1f);
    }
}