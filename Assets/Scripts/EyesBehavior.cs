using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class EyeBehavior : MonoBehaviour
{
    [Hint("Change the eyes direction inward/outward.")]
    [Range(-1, 1)]
    public float eyeDirection = 0;

    float range = 60;

    GameObject leftEye;
    float lY = 0;
    GameObject rightEye;
    float rY = 0;

    void OnValidate()
    {
        InitObjects();
        var lTrans = leftEye.transform;
        lTrans.eulerAngles = new Vector3(
            lTrans.eulerAngles.x,
            lY - range * eyeDirection,
            lTrans.eulerAngles.z
        );

        var rTrans = rightEye.transform;
        rTrans.eulerAngles = new Vector3(
            rTrans.eulerAngles.x,
            rY + range * eyeDirection,
            rTrans.eulerAngles.z
        );
    }

    void InitObjects()
    {
        if (this.leftEye && this.rightEye)
        {
            return;
        }
        var master = GetObj(transform.gameObject, "master");
        var reference = GetObj(master, "Reference");
        var hips = GetObj(reference, "Hips");
        var spine = GetObj(hips, "Spine");
        var spine1 = GetObj(spine, "Spine1");
        var spine2 = GetObj(spine1, "Spine2");
        var neck = GetObj(spine2, "Neck");
        var head = GetObj(neck, "Head");
        var leftEye = GetObj(head, "LeftEye");
        var rightEye = GetObj(head, "RightEye");
        this.leftEye = leftEye;
        this.rightEye = rightEye;
        // lY = leftEye.transform.eulerAngles.y;
        // rY = rightEye.transform.eulerAngles.y;
        lY = 90;
        rY = 90;
    }

    GameObject GetObj(GameObject parent, string childName)
    {
        var res = parent.transform.Find(childName).gameObject;
        if (!res)
        {
            Debug.LogError("Name " + childName + " does not exist...");
        }

        return res;
    }
}
