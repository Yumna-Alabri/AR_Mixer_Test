using UnityEngine;

public class Scalable : MonoBehaviour
{
    public float scaleSpeed = 1f; // Adjust scale speed as needed
    public float minScale = 1f; // Minimum scale limit, adjust based on your need
    public float maxScale = 10f; // Maximum scale limit, adjust based on your need

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale; // Remember original scale
    }

    void Update()
    {
        // Adjust scale based on mouse wheel for desktop testing
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            float scaleChange = Input.GetAxis("Mouse ScrollWheel") * scaleSpeed;
            ScaleObject(scaleChange);
        }

        // Adjust scale based on pinch for touch devices
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            ScaleObject(-deltaMagnitudeDiff * scaleSpeed * 0.01f); // Adjust scaling factor for pinch
        }
    }

    private void ScaleObject(float scaleChange)
    {
        // Calculate new scale based on change
        Vector3 scale = transform.localScale + Vector3.one * scaleChange;
        // Ensure new scale is within limits
        scale = new Vector3(
            Mathf.Clamp(scale.x, originalScale.x * minScale, originalScale.x * maxScale),
            Mathf.Clamp(scale.y, originalScale.y * minScale, originalScale.y * maxScale),
            Mathf.Clamp(scale.z, originalScale.z * minScale, originalScale.z * maxScale)
        );

        transform.localScale = scale;
    }
}
