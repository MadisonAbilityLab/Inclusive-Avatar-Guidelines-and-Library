using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class EyeBehavior : MonoBehaviour
{
    // [Hint("Change the eyes direction inward/outward.")]
    [Range(-1, 1)]
    public float lEyeDirectionX = 0;
    [Range(-1, 1)]
    public float lEyeDirectionY = 0;
    [Range(-1, 1)]
    public float rEyeDirectionX = 0;
    [Range(-1, 1)]
    public float rEyeDirectionY = 0;

    float scaleX = 20;
    float scaleY = 20;

    GameObject leftEye;
    GameObject rightEye;

    void OnValidate()
    {
        InitObjects();
        // Apply rotations to the left and right eyes based on slider values
        var lTrans = leftEye.transform;
        lTrans.localRotation = Quaternion.Euler(0, lEyeDirectionX * scaleX, (-lEyeDirectionY - 1) * scaleY);

        var rTrans = rightEye.transform;
        rTrans.localRotation = Quaternion.Euler(0, rEyeDirectionX * scaleX, (-rEyeDirectionY - 1) * scaleY);

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
        // lY = 90;
        // rY = 90;
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
