using UnityEngine;

public class WheelSizeCalculator : MonoBehaviour
{
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter != null)
        {
            Vector3 meshSize = meshFilter.mesh.bounds.size;
            Vector3 worldScale = transform.lossyScale;
            Vector3 worldSize = Vector3.Scale(meshSize, worldScale);
            
            float diameter = Mathf.Max(worldSize.x, worldSize.y, worldSize.z);
            float radius = diameter / 2f;

            Debug.Log("Wheel Diameter: " + diameter + " units");
            Debug.Log("Wheel Radius: " + radius + " units");
        }
        else
        {
            Debug.LogError("No MeshFilter component found on this GameObject.");
        }
    }
}
