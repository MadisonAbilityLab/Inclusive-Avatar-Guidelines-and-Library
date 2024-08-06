using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2 : WheelsRotate
{
    public float speed = 1;
    
    void Start()
    {
        frontWheel = transform.Find("Circle.004").gameObject;
        Debug.Log(frontWheel);
        backWheel = transform.Find("Wheel").gameObject;

        frontAxis = RotateAxes.X;
        backAxis = RotateAxes.X;
        frontSpeed = -1f;
        backSpeed = -1.5f;
    }

    // Update is called once per frame
    protected override void VUpdate()
    {
        scale = speed;
        base.VUpdate();
    }
}
