using UnityEngine;
using UnityEngine.UI;

public class FacialExpressions : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer; // The Skinned Mesh Renderer with the blendshapes
    public SkinnedMeshRenderer skinnedMeshRendererTeeth; // The Skinned Mesh Renderer with the blendshapes

    // Enum to define the dropdown options for the Inspector
    public enum EmotionPresets
    {
        Nuetral,
        Sadness,
        Happiness,
        Fear,
        Anger,
        Surprise,
        Disgust
    }
    // The dropdown that will appear in the Inspector
    public EmotionPresets selectedPreset;
    private int blendshapeCount1 = 65; // Blendshape count for the first renderer
    private int blendshapeCount2 = 31; // Blendshape count for the second renderer

    // Preset blendshape values for each emotion, dynamically initialized with zeros
    private float[][] blendshapePresets1 = new float[7][];
    private float[][] blendshapePresets2 = new float[7][];

    // Called when the script is loaded or a value changes in the Inspector
    private void OnValidate()
    {
        // Initialize each preset array for both renderers with blendshapeCount elements set to 0, if not already initialized
        for (int i = 0; i < blendshapePresets1.Length; i++)
        {
            if (blendshapePresets1[i] == null)
            {
                blendshapePresets1[i] = new float[blendshapeCount1];
                for (int j = 0; j < blendshapeCount1; j++)
                {
                    blendshapePresets1[i][j] = 0f;
                }
            }

            if (blendshapePresets2[i] == null)
            {
                blendshapePresets2[i] = new float[blendshapeCount2];
                for (int j = 0; j < blendshapeCount2; j++)
                {
                    blendshapePresets2[i][j] = 0f;
                }
            }
        }

        // Manually set values for each preset
        blendshapePresets1[1][32] = 70f; // Sadness preset: blendshape index 0
        blendshapePresets1[1][33] = 70f; // Sadness preset: blendshape index 0
        blendshapePresets1[1][54] = 50f; // Sadness preset: blendshape index 0
        blendshapePresets1[1][55] = 50f; // Sadness preset: blendshape index 0

        
        blendshapePresets1[2][28] = 70f; // Happiness preset: blendshape index 1
        blendshapePresets1[2][29] = 70f; // Happiness preset: blendshape index 1

        blendshapePresets1[3][26] = 30f; // Fear preset: blendshape index 2
        blendshapePresets1[3][32] = 25f; // Fear preset: blendshape index 2
        blendshapePresets1[3][33] = 25f; // Fear preset: blendshape index 2
        blendshapePresets1[3][47] = 100f; // Fear preset: blendshape index 2
        blendshapePresets1[3][48] = 100f; // Fear preset: blendshape index 2
        blendshapePresets2[3][29] = 100f;

        blendshapePresets1[4][32] = 75f; // Anger preset: blendshape index 3
        blendshapePresets1[4][33] = 75f; // Anger preset: blendshape index 3
        blendshapePresets1[4][62] = 100f; // Anger preset: blendshape index 3
        blendshapePresets1[4][63] = 100f; // Anger preset: blendshape index 3

        blendshapePresets1[5][4] = 65f; // Surprise preset: blendshape index 4
        blendshapePresets1[5][47] = 70f; // Surprise preset: blendshape index 4
        blendshapePresets1[5][48] = 70f; // Surprise preset: blendshape index 4
        blendshapePresets2[5][29] = 100f; // Surprise preset: blendshape index 4

        blendshapePresets1[6][34] = 75f; // Disgust preset: blendshape index 5
        blendshapePresets1[6][35] = 75f; // Disgust preset: blendshape index 5
        blendshapePresets1[6][49] = 10f; // Disgust preset: blendshape index 5
        blendshapePresets1[6][50] = 10f; // Disgust preset: blendshape index 5
        blendshapePresets1[6][62] = 50f; // Disgust preset: blendshape index 5
        blendshapePresets1[6][63] = 50f; // Disgust preset: blendshape index 5

        // Apply the selected preset based on the selectedPreset enum value
        ApplyBlendshapePreset((int)selectedPreset);
    }

    // Apply the selected preset blendshape values
    public void ApplyBlendshapePreset(int presetIndex)
    {
        if (presetIndex < 0 || presetIndex >= blendshapePresets1.Length || presetIndex >= blendshapePresets2.Length)
        {
            Debug.LogError("Invalid preset index.");
            return;
        }

        // Apply preset to the first Skinned Mesh Renderer (65 blendshapes)
        float[] selectedPreset1 = blendshapePresets1[presetIndex];
        for (int i = 0; i < selectedPreset1.Length; i++)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(i, selectedPreset1[i]);
        }

        // Apply preset to the second Skinned Mesh Renderer (31 blendshapes)
        float[] selectedPreset2 = blendshapePresets2[presetIndex];
        for (int i = 0; i < selectedPreset2.Length; i++)
        {
            skinnedMeshRendererTeeth.SetBlendShapeWeight(i, selectedPreset2[i]);
        }
    }
}