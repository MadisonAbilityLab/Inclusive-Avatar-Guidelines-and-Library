using System.Linq; // For LINQ operations
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class MaterialColorPicker : MonoBehaviour
{
    public string selectedMaterialName; // Dropdown to select the material
    public Color newColor = Color.white; // Color picker for the new color

    private string[] materialNames = new string[0]; // Stores available material names

    // Method to get all materials from child renderers
    private void RefreshMaterialList()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        materialNames = renderers
            .SelectMany(r => r.sharedMaterials) // Use sharedMaterials instead of materials
            .Where(mat => mat != null)
            .Select(mat => mat.name.Replace(" (Instance)", ""))
            .Distinct()
            .ToArray();
    }

    // Method to update the material color
    public void UpdateMaterialColor()
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            foreach (Material mat in renderer.sharedMaterials) // Use sharedMaterials here
            {
                if (mat != null && mat.name.Contains(selectedMaterialName)) // Check for null
                {
                    mat.color = newColor;
                    Debug.Log($"Updated {selectedMaterialName} to color {newColor}");
                    return; // Exit after updating
                }
            }
        }
        Debug.LogWarning($"Material '{selectedMaterialName}' not found.");
    }

#if UNITY_EDITOR
    // Custom Inspector logic
    [CustomEditor(typeof(MaterialColorPicker))]
    public class MaterialColorPickerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            MaterialColorPicker script = (MaterialColorPicker)target;

            // Refresh material list
            script.RefreshMaterialList();

            // Dropdown for material selection
            int currentIndex = System.Array.IndexOf(script.materialNames, script.selectedMaterialName);
            currentIndex = EditorGUILayout.Popup("Select Material", currentIndex, script.materialNames);
            if (currentIndex >= 0)
            {
                script.selectedMaterialName = script.materialNames[currentIndex];
            }

            // Color picker for the new color
            script.newColor = EditorGUILayout.ColorField("New Color", script.newColor);

            // Update button
            if (GUILayout.Button("Update Color"))
            {
                script.UpdateMaterialColor();
            }

            // Save changes
            if (GUI.changed)
            {
                EditorUtility.SetDirty(target);
            }
        }
    }
#endif
}