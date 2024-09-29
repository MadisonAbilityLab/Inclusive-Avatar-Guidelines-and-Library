using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ColorPickerInspector : MonoBehaviour
{
    [Tooltip("Select the tag of the objects whose color you want to change")]
    [TagSelector]
    public string targetTag = "Untagged";  // Dropdown to select tag

    [Tooltip("Change color of objects with the selected tag")]
    public Color newColor;

    void OnValidate()
    {
        if (!string.IsNullOrEmpty(targetTag))
        {
            // Find all objects with the specified tag
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(targetTag);

            foreach (GameObject obj in taggedObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    // Use MaterialPropertyBlock to change the color without modifying the material asset
                    MaterialPropertyBlock block = new MaterialPropertyBlock();
                    renderer.GetPropertyBlock(block);
                    block.SetColor("_Color", newColor);
                    renderer.SetPropertyBlock(block);
                }
            }
        }
    }

    // Custom attribute to create the dropdown for tag selection
    public class TagSelectorAttribute : PropertyAttribute { }
}

#if UNITY_EDITOR
// Custom property drawer for the TagSelector attribute
[CustomPropertyDrawer(typeof(ColorPickerInspector.TagSelectorAttribute))]
public class TagSelectorDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.String)
        {
            // Get all tags from the TagManager
            string[] tags = UnityEditorInternal.InternalEditorUtility.tags;

            // Find the current tag in the list
            int index = Mathf.Max(0, System.Array.IndexOf(tags, property.stringValue));

            // Create a dropdown menu in the inspector
            index = EditorGUI.Popup(position, label.text, index, tags);

            // Update the string property with the selected tag
            property.stringValue = tags[index];
        }
        else
        {
            EditorGUI.LabelField(position, label.text, "Use [TagSelector] with strings.");
        }
    }
}
#endif
