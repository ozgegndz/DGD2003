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
            animator.SetInteger("Emotion", 1);

        if (keyboard.digit2Key.wasPressedThisFrame)
            animator.SetInteger("Emotion", 2);

        if (keyboard.digit3Key.wasPressedThisFrame)
            animator.SetInteger("Emotion", 3);

        if (keyboard.digit4Key.wasPressedThisFrame)
            animator.SetInteger("Emotion", 4);

        if (keyboard.digit0Key.wasPressedThisFrame)
            animator.SetInteger("Emotion", 0);
    }
}