using UnityEngine;

public class CaneAttach : MonoBehaviour
{
    // Enum to select the hand from a dropdown menu in the Inspector
    public enum Hand
    {
        LeftHand,
        RightHand
    }

    [Header("Select Hand for Cane Attachment")]
    public Hand hand = Hand.RightHand;

    [Header("Assign the GripPosition Transform")]
    public Transform gripPosition;

    void Start()
    {
        if (gripPosition == null)
        {
            Debug.LogError("GripPosition is not assigned in CaneAttach script.");
            return;
        }

        // Get the name of the hand bone based on the selected hand
        string handBoneName = hand.ToString();

        // Find the avatar (assumed to be the parent of the cane)
        Transform avatarTransform = transform.root;

        // Find the hand bone within the avatar's hierarchy
        Transform handBone = FindChildByName(avatarTransform, handBoneName);

        if (handBone != null)
        {
            // Attach the cane to the hand bone without changing its position and rotation
            transform.SetParent(handBone, false);

            // Calculate the offset between the cane's pivot and the GripPosition
            Vector3 gripOffset = transform.InverseTransformPoint(gripPosition.position);

            // Adjust the cane's local position so that GripPosition aligns with the hand bone
            transform.localPosition = -gripOffset;

            // Optional: If the cane's rotation needs adjustment
            transform.localRotation = Quaternion.identity;

            // Alternatively, match the rotation of the gripPosition to the hand bone
            // transform.rotation = gripPosition.rotation;
        }
        else
        {
            Debug.LogError("Hand bone not found: " + handBoneName);
        }
    }

    // Helper method to find a child Transform by name recursively
    Transform FindChildByName(Transform parent, string name)
    {
        foreach (Transform child in parent)
        {
            if (child.name == name)
                return child;

            Transform result = FindChildByName(child, name);
            if (result != null)
                return result;
        }
        return null;
    }
}
