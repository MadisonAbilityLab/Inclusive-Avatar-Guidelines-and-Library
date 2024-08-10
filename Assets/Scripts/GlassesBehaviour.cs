using System.Collections;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class GlassBehaviour : MonoBehaviour
{
    [Tooltip("Show more felids for advanced users.")]
    public bool showMore;

    [ConditionalField("showMore")]
    public GameObject frame;
    [ConditionalField("showMore")]
    public GameObject lens;

    [ConditionalField("showMore")]
    public GameObject frameArmBone;

    [Tooltip("Frame Color sets the color of the glasses frame.")]
    public Color frameColor;

    [Tooltip("Arm Length adjusts the length of the frame arms.")]
    public float armLength = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnValidate()
    {
        Debug.Log("Validating...");

        if (frame)
        {
            var frameRenderer = frame.GetComponent<Renderer>();

            frameRenderer.material.SetColor("_Color", frameColor);
        }

        if (frameArmBone)
        {
            frameArmBone.transform.localScale = (
                new Vector3(1f, armLength, 1f)
            );
        }
    }
}
