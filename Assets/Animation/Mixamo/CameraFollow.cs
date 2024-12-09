using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target; // Reference to the player
    public Vector3 offset; // Offset from the player
    public float smoothSpeed = 0.125f; // Smoothness of the camera movement

    void LateUpdate() {
        // Desired position of the camera based on the player's position and the offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate between the camera's current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply the smoothed position to the camera
        transform.position = smoothedPosition;

        // Optionally, make the camera always look at the player
        transform.LookAt(target);
    }
}