using UnityEngine;

public class AttachObjectToBoneWithOffset : MonoBehaviour
{
    [SerializeField] private Animator avatarAnimator; // Avatar's Animator component
    [SerializeField] private GameObject objectToAttach; // The object to attach (e.g., a crutch)
    [SerializeField] private HumanBodyBones targetBone = HumanBodyBones.RightUpperArm; // The bone to attach to

    private Transform boneTransform;
    private Quaternion initialOffset; // Stores the offset to maintain orientation

    private void Start()
    {
        if (!ValidateInputs()) return;

        // Get the bone's transform
        boneTransform = avatarAnimator.GetBoneTransform(targetBone);
        if (boneTransform == null)
        {
            Debug.LogError($"The selected bone '{targetBone}' does not exist on the avatar.");
            return;
        }

        // Store the initial world-space offset
        initialOffset = Quaternion.Inverse(boneTransform.rotation) * objectToAttach.transform.rotation;

        // Attach the object without changing world position
        objectToAttach.transform.SetParent(boneTransform, true);

        Debug.Log($"Object '{objectToAttach.name}' successfully linked to bone '{targetBone}' while preserving its initial orientation.");
    }

    private void LateUpdate()
    {
        if (boneTransform == null) return;

        // Maintain the original offset so the object stays correctly aligned
        objectToAttach.transform.rotation = boneTransform.rotation * initialOffset;
    }

    private bool ValidateInputs()
    {
        if (avatarAnimator == null)
        {
            Debug.LogError("Avatar Animator is not assigned. Please assign a valid humanoid Animator.");
            return false;
        }

        if (!avatarAnimator.isHuman)
        {
            Debug.LogError("The assigned Animator is not humanoid. This script requires a humanoid rig.");
            return false;
        }

        if (objectToAttach == null)
        {
            Debug.LogError("Object to attach is not assigned. Please assign a valid GameObject.");
            return false;
        }

        return true;
    }
}