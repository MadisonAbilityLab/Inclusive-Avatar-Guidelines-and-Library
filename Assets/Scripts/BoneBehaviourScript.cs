using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
// using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor;
using System.Reflection;
using System.Linq;



public class BoneBehaviorScript : MonoBehaviour
{
    [Serializable]
    public struct BoneInfo
    {
        public GameObject bone;
        public float length;
    }

    [SerializeField]
    public List<BoneInfo> bones = new List<BoneInfo>();
    private List<BoneInfo> prevBones = new List<BoneInfo>();

    void onBonesChange()
    {
        Debug.Log("On Bone Change");
    }
    bool isBoneChanged()
    {
        if (prevBones.Count != bones.Count)
        {
            return true;
        }

        for (int i = 0; i < bones.Count; i++)
        {
            if (bones[i].bone != prevBones[i].bone)
            {
                return true;
            }
        }
        return false;
    }
    void setPrevBonesToCurrent()
    {
        prevBones.Clear();
        foreach (var bone in bones)
        {
            prevBones.Add(bone);
        }
    }

    public GameObject root;

    // private GameObject lastBone;

    // [SerializeField]
    // bool changed = true;

    // public bool reset = false;

    // float childrenSize = 0;

    // [SerializeField]
    // float length = 1;

    // public Vector3 scale = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {

    }

    void MakeAllChildrenSize(GameObject gameObject, float size = 0)
    {
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
        if (isBoneChanged())
        {
            for (int i = 0; i < prevBones.Count; i++)
            {
                var bone = prevBones[i];
                MakeAllChildrenSize(bone.bone, 1);
                bone.bone.transform.localScale = new Vector3(1, 1, 1);
            }

            setPrevBonesToCurrent();
        }

        for (int i = 0; i < bones.Count; i++)
        {
            var bone = bones[i];
            if (bone.length < 0)
            {
                bone.length = 0;
            }
            if (bone.length > 1)
            {
                bone.length = 1;
            }

            MakeAllChildrenSize(bone.bone, 0);

            bone.bone.transform.localScale = new Vector3(1, bone.length, 1);
        }
    }
}
