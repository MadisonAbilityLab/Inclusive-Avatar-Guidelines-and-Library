using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RotateAxes
{
    X,
    Y,
    Z
}

public class WheelsRotate : MonoBehaviour
{
    public GameObject frontWheel;
    public GameObject backWheel;
    public RotateAxes frontAxes;
    public RotateAxes backAxes;

    public float frontSpeed = 1;
    public float backSpeed = 1;
    public float scale = 1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (frontWheel && frontAxes)
        {
            frontWheel.
        }
    }
}
