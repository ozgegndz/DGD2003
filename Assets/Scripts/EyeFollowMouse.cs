using UnityEngine;
using UnityEngine.InputSystem;

public class EyeFollowMouse : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();

        Ray ray = cam.ScreenPointToRay(mousePos);

        Vector3 target = ray.origin + ray.direction * 100f;

        transform.LookAt(target);
    }
}