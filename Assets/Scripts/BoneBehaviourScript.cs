using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneBehaviorScript : MonoBehaviour
{
    [SerializeField]
    public GameObject bone;

    private GameObject lastBone;

    bool changed = true;

    public bool reset = false;
   
    float childrenSize = 0;

     [SerializeField]
    float length = 1;

    // public Vector3 scale = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {

    }

    void MakeAllChildrenSize(GameObject gameObject, float size = 0)
    {
       
        // Debug.Log(gameObject.transform.child);

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            GameObject go = gameObject.transform.GetChild(i).gameObject;

            // Debug.Log(go);

            go.transform.localScale = new Vector3(size, size, size);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (bone != lastBone) {
            lastBone = bone;
            changed = true;
        }

        if (changed){
            childrenSize = 0;
            changed = false;
        }

        if (reset) {
            childrenSize = 1;
            reset = false;
        }

        MakeAllChildrenSize(bone, childrenSize);

        bone.transform.localScale = new Vector3(1, length, 1);
    }
}
