using UnityEngine;

public class Rotatable : MonoBehaviour
{
    private float rotationSpeed = 20f; // Adjust rotation speed as needed

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        // Rotate around the world y-axis and local x-axis
        transform.Rotate(Vector3.down, XaxisRotation, Space.World);
        transform.Rotate(Vector3.right, YaxisRotation, Space.Self);
    }
}
