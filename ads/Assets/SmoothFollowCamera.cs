using UnityEngine;

public class SmoothFollowCamera : MonoBehaviour
{
    public Transform plane; // The plane to follow
    public Vector3 offset = new Vector3(0, 5, -10); // Position offset from the plane
    public float smoothSpeed = 0.125f; // Speed for smoothing position
    public float rotationSmoothSpeed = 5.0f; // Speed for smoothing rotation

    void LateUpdate()
    {
        // Desired position based on the plane's position and offset
        Vector3 desiredPosition = plane.position + offset;

        // Smoothly interpolate to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Smoothly rotate the camera to face the same direction as the plane
        Quaternion targetRotation = Quaternion.LookRotation(plane.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSmoothSpeed * Time.deltaTime);
    }
}