using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(HintAttribute))]
public class HintDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Get the HintAttribute
        HintAttribute hint = (HintAttribute)attribute;

        // Calculate the rects for the label and the hint
        Rect labelRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        Rect hintRect = new Rect(position.x, position.y + EditorGUIUtility.singleLineHeight, position.width, EditorGUIUtility.singleLineHeight);

        // Draw the property field
        EditorGUI.PropertyField(labelRect, property, label);

        // Draw the hint below the field
        EditorGUI.LabelField(hintRect, hint.hint, EditorStyles.helpBox);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        // Adjust the height of the property to include the hint
        return EditorGUIUtility.singleLineHeight * 2;
    }
}
