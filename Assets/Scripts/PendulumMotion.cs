using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMotion : MonoBehaviour
{
    // Reference to the avatar's Animator component
    public Animator avatarAnimator;

    // Maximum swing angle in degrees
    public float swingAmplitude = 15f;

    // Speed multiplier for the swing
    public float swingSpeedMultiplier = 1f;

    void Start()
    {
        // If the Animator is not assigned, try to find it in the parent GameObjects
        if (avatarAnimator == null)
        {
            avatarAnimator = GetComponentInParent<Animator>();
            if (avatarAnimator == null)
            {
                Debug.LogError("Animator component not found. Please assign the avatar's Animator to the PendulumMotion script.");
            }
        }
    }

    void Update()
    {
        if (avatarAnimator != null)
        {
            // Get the avatar's movement speed from the Animator
            // Replace "Speed" with the actual parameter name used in your Animator
            float speed = avatarAnimator.GetFloat("Speed");

            // Determine if the avatar is walking based on the speed threshold
            bool isWalking = speed > 0.1f; // Adjust the threshold as needed

            if (isWalking)
            {
                // Calculate the swing angle using a sine wave
                float swingAngle = Mathf.Sin(Time.time * swingSpeedMultiplier * speed) * swingAmplitude;

                // Apply the rotation to the cane
                transform.localRotation = Quaternion.Euler(swingAngle, 0f, 0f);
            }
            else
            {
                // Reset rotation when the avatar is not walking
                transform.localRotation = Quaternion.identity;
            }
        }
    }
}
