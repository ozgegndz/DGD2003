using UnityEngine;

public class EmotionTest : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            anim.SetFloat("Emotion", 0);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            anim.SetFloat("Emotion", 1);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            anim.SetFloat("Emotion", 2);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            anim.SetFloat("Emotion", 3);
    }
}