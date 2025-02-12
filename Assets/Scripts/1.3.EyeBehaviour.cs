using System.Collections;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class EyeBehaviour : MonoBehaviour
{
    GameObject leftEyeBall;
    GameObject rightEyeBall;

    [Range(-0.5f, 0.5f)]
    public float leftEyeSize = 1;
    [Range(-0.5f, 0.5f)]
    public float rightEyeSize = 1;

    public bool autoAnimate = false;
    // Start is called before the first frame update
    void Start()
    {
        Transform reference = transform.Find("master/Reference");
        if (reference != null)
        {
            Transform head = reference.Find("Hips/Spine/Spine1/Spine2/Neck/Head");
            if (head != null)
            {
                leftEyeBall = head.Find("LeftEye")?.gameObject;
                rightEyeBall = head.Find("RightEye")?.gameObject;
            }
            else
            {
                Debug.LogWarning("Head not found in the hierarchy.");
            }
        }

        if (leftEyeBall == null || rightEyeBall == null)
        {
            Debug.LogWarning("Eye objects not found in the hierarchy.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftEyeBall)
        {
            Vector3 newScale = leftEyeBall.transform.localScale;
            newScale.x = leftEyeSize * 0.2f + 1;
            newScale.y = leftEyeSize * 0.1f + 1;
            leftEyeBall.transform.localScale = newScale;
        }

        if (rightEyeBall)
        {
            Vector3 newScale = rightEyeBall.transform.localScale;
            newScale.x = rightEyeSize * 0.2f + 1;
            newScale.y = rightEyeSize * 0.1f + 1;
            rightEyeBall.transform.localScale = newScale;
        }
    }
}
