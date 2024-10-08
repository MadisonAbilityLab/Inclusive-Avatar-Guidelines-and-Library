using UnityEngine;

public class WheelchairMovement : MonoBehaviour
{
    public Transform avatar;  // The avatar the wheelchair is attached to
    public Transform[] wheels;  // Array of the wheelchair's wheel transforms
    public float wheelRadius = 0.3f;  // Radius of the wheels (adjust as needed)
    
    private Vector3 previousPosition;  // To store the avatar's previous position
    
    void Start()
    {
        // Store the initial position of the avatar
        if (avatar != null)
        {
            previousPosition = avatar.position;
        }
    }

    void Update()
    {
        // Sync the wheelchair's position with the avatar's
        if (avatar != null)
        {
            // Move the wheelchair to the avatar's position
            transform.position = avatar.position;
            
            // Calculate the distance traveled by the avatar in this frame
            float distanceTraveled = Vector3.Distance(previousPosition, avatar.position);

            // Call the method to roll the wheels based on the distance traveled
            RollWheels(distanceTraveled);

            // Update the previous position for the next frame
            previousPosition = avatar.position;
        }
    }

    void RollWheels(float distanceTraveled)
    {
        // Calculate how much each wheel should rotate based on the distance traveled
        float wheelRotationAngle = (distanceTraveled / (2 * Mathf.PI * wheelRadius)) * 360f;

        // Apply the rotation to each wheel
        foreach (Transform wheel in wheels)
        {
            wheel.Rotate(Vector3.right, wheelRotationAngle, Space.Self);  // Rotate around the X-axis (assuming that wheels rotate around the X-axis)
        }
    }
}
