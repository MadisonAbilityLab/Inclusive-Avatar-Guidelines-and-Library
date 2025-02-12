using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

[ExecuteInEditMode]
public class BoneBehaviorScript : MonoBehaviour
{
    [Serializable]
    public struct BoneInfo
    {
        public GameObject bone;
        [Range(0, 1)] public float length;
    }

    [SerializeField]
    public List<BoneInfo> bones = new List<BoneInfo>();

    private List<BoneInfo> prevBones = new List<BoneInfo>();

    public void UpdateBones()
    {
        if (isBoneChanged())
        {
            for (int i = 0; i < prevBones.Count; i++)
            {
                if (prevBones[i].bone != null)
                {
                    MakeAllChildrenSize(prevBones[i].bone, 1);
                    prevBones[i].bone.transform.localScale = new Vector3(1, 1, 1);
                }
            }
            setPrevBonesToCurrent();
        }

        for (int i = 0; i < bones.Count; i++)
        {
            if (bones[i].bone != null)
            {
                MakeAllChildrenSize(bones[i].bone, 0);
                bones[i].bone.transform.localScale = new Vector3(1, bones[i].length, 1);
            }
        }
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

    void MakeAllChildrenSize(GameObject gameObject, float size = 0)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            GameObject go = gameObject.transform.GetChild(i).gameObject;
            go.transform.localScale = new Vector3(size, size, size);
        }
    }
#if UNITY_EDITOR
    private void OnValidate()
    {
        UpdateBones();
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(BoneBehaviorScript))]
public class BoneBehaviorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        BoneBehaviorScript script = (BoneBehaviorScript)target;

        if (GUILayout.Button("Update Bones"))
        {
            script.UpdateBones();
        }
    }
}
#endif
