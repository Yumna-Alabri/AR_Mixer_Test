using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject blade; // Drag the blade object here in the inspector
    private RotationController rotationController; // Make sure your blade has the RotationController script
    private bool isPressed = false;
    private Vector3 originalPosition;
    public float movementDistance = 0.1f; // How far the button moves in

    private void Start()
    {
        rotationController = blade.GetComponent<RotationController>();
        originalPosition = transform.localPosition;
    }

    private void OnMouseDown() // This works for mouse clicks. For touch, you might need to use touch input detection if working with AR or 3D objects not in the UI layer.
    {
        if (!isPressed)
        {
            // Move button in
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - movementDistance, transform.localPosition.z);
            rotationController.rotationVector.z = 400; // Set to desired rotation speed
            isPressed = true;
        }
        else
        {
            // Move button back to original position
            transform.localPosition = originalPosition;
            rotationController.rotationVector.z = 0; // Stop rotation
            isPressed = false;
        }
    }
}
