using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjOffset : MonoBehaviour
{
    GameObject target;

    

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = new GameObject();
            target.transform.position = transform.position;
            target.transform.rotation = transform.rotation;
            target.transform.localScale = transform.localScale;
            target.transform.parent = transform.parent;
            transform.parent = target.transform;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
