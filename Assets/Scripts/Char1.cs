using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1 : WheelsRotate
{
    public float speed = 1;
    
    void Start()
    {
        frontWheel = transform.Find("Circle.002").gameObject;
        Debug.Log(frontWheel);
        backWheel = transform.Find("WheelDetail.001").gameObject;

        frontAxis = RotateAxes.Y;
        backAxis = RotateAxes.Z;
        frontSpeed = -3.5f;
        backSpeed = 2.25f;
    }

    // Update is called once per frame
    protected override void VUpdate()
    {
        scale = speed;
        base.VUpdate();
    }
}
