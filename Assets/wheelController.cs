using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class wheelController : MonoBehaviour
{
    [SerializeField] WheelCollider mainLeft; 
    [SerializeField] WheelCollider mainRight;
    //[SerializeField] WheelCollider frontLeft;
    //[SerializeField] WheelCollider frontRight;
    
    [SerializeField] Transform mainWheels;
    //[SerializeField] Transform frontWheels;


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
        
        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
        else 
            currentBreakForce = 0f;

        // Apply acceleration to front wheels
        mainLeft.motorTorque = currentAcceleration;
        mainRight.motorTorque = currentAcceleration;
        //frontLeft.motorTorque = currentAcceleration;
        //frontRight.motorTorque = currentAcceleration;

        // Apply braking to front wheels
        mainLeft.brakeTorque = currentBreakForce;
        mainRight.brakeTorque = currentBreakForce;
        //frontLeft.brakeTorque = currentBreakForce;
        //frontRight.brakeTorque = currentBreakForce;

        // Take care of the steering
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        //frontLeft.steerAngle = currentTurnAngle;
        //frontRight.steerAngle = currentTurnAngle;

        // Update the wheel meshes
        UpdateWheel(mainLeft, mainWheels);
        UpdateWheel(mainRight, mainWheels);
        //UpdateWheel(frontLeft, frontWheels);
        //UpdateWheel(frontRight, frontWheels);
    }

    void UpdateWheel(WheelCollider col, Transform trans) 
    {
        // Get wheel collider state
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);   

        // Adjust the rotation to fix the axis
        rotation *= Quaternion.Euler(0, 90, 0); // Rotate around y-axis

        // Set wheel transform state
        trans.position = position;
        trans.rotation = rotation;

    } 

}
