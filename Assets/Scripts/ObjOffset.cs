using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjOffset : MonoBehaviour
{
  public  GameObject target;
    Vector3 targetDefaultPos;

    Vector3 thisDefaultPos;


    Quaternion rotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        if (!target)
        {
            target = GameObject.Find("Player");
        }

        targetDefaultPos = target.transform.position;
        thisDefaultPos = transform.position;


        // Print for debugging
        Debug.Log("Target: " + target.transform.position);
        Debug.Log("This: " + this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var thisCurrPos = transform.position;
        Vector3 offset = thisCurrPos - thisDefaultPos;

        target.transform.position = targetDefaultPos + offset;
        target.transform.rotation = transform.rotation;
    }
}
