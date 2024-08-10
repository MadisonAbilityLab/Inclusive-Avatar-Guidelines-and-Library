using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Char2 : WheelsRotate
{
    [Tooltip("The speed for the wheel chair.")]
    public float speed = 1;
    void OnValidate(){
        ShowMore = false;
    }
    
    void Start()
    {
        frontWheel = transform.Find("Circle.004").gameObject;
        Debug.Log(frontWheel);
        backWheel = transform.Find("Wheel").gameObject;

        frontAxis = RotateAxes.X;
        backAxis = RotateAxes.X;
        frontSpeed = -1f;
        backSpeed = -1.5f;

        ShowMore = false;
    }

    // Update is called once per frame
    protected override void VUpdate()
    {
        scale = speed;
        base.VUpdate();
    }
}
