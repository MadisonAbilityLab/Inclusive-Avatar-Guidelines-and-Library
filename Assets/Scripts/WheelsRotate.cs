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
    public RotateAxes frontAxis;
    public RotateAxes backAxis;

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
        if (frontWheel)
        {

            switch (frontAxis)
            {
                case RotateAxes.X:
                    frontWheel.transform.Rotate(new Vector3(
                        frontSpeed * scale, 0, 0
                    ));
                    break;
                case RotateAxes.Y:
                    frontWheel.transform.Rotate(new Vector3(
                            0, frontSpeed * scale, 0
                        ));
                    break;
                case RotateAxes.Z:
                    frontWheel.transform.Rotate(new Vector3(
                                0, 0, frontSpeed * scale
                            ));
                    break;
                default:
                    break;
            }

        }

        if (backWheel)
        {
            switch (backAxis){
                 case RotateAxes.X:
                    backWheel.transform.Rotate(new Vector3(
                        backSpeed * scale, 0, 0
                    ));
                    break;
                case RotateAxes.Y:
                    backWheel.transform.Rotate(new Vector3(
                            0, backSpeed * scale, 0
                        ));
                    break;
                case RotateAxes.Z:
                    backWheel.transform.Rotate(new Vector3(
                                0, 0, backSpeed * scale
                            ));
                    break;
                default:
                    break;
            }
        }

    }
}
