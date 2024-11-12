using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class wheelController : MonoBehaviour{

    [SerializeField] WheelCollider bigLeft; 
    [SerializeField] WheelCollider bigRight;
    [SerializeField] WheelCollider smallLeft;
    [SerializeField] WheelCollider smallRight;
    
    [SerializeField] Transform bigRightTransform;
    [SerializeField] Transform bigLeftTransform;
    [SerializeField] Transform smallRightTransform;
    [SerializeField] Transform smallLeftTransform;


    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 30f;

    private float currentAcceleration = 0f; 
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Get forward/reverse acceleration from the vertical axis (W and S keys)
        currentAcceleration = acceleration * Input.GetAxis("Vertical");
        
        // If we're pressing space, give currentBreakinForce a value.
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else 
            currentBreakForce = 0f;

        // Apply acceleration to front wheels.
        bigLeft.motorTorque = currentAcceleration;
        bigRight.motorTorque = currentAcceleration;
        //smallLeft.motorTorque = currentAcceleration;
        //smallRight.motorTorque = currentAcceleration;

        // Apply braking to front wheels.
        bigLeft.brakeTorque = currentBreakForce;
        bigRight.brakeTorque = currentBreakForce;
        smallLeft.brakeTorque = currentBreakForce;
        smallRight.brakeTorque = currentBreakForce;

        // Take care of the steering
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        smallLeft.steerAngle = currentTurnAngle;
        smallRight.steerAngle = currentTurnAngle;

        // Update the wheel meshes
        UpdateWheel(bigLeft, bigLeftTransform);
        UpdateWheel(bigRight, bigRightTransform);
        UpdateWheel(smallLeft, smallLeftTransform);
        UpdateWheel(smallRight, smallRightTransform);
    }
    
    void UpdateWheel(WheelCollider col, Transform trans) 
    {
        // Get wheel collider state
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);   

        // Adjust the rotation to fix the axis
        rotation *= Quaternion.Euler(0, 0, 90); // Rotate around y-axis

        // Set wheel transform state
        trans.position = position;
        trans.rotation = rotation;

    } 

}
