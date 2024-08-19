using UnityEngine;
using UnityEngine.UI;

public class HeightAdjuster : MonoBehaviour
{
    public Slider heightSlider; // Reference to the slider
    public GameObject targetObject; // The object whose height will be adjusted

    void Start()
    {
        // Initialize the slider's listener
        heightSlider.onValueChanged.AddListener(delegate { AdjustHeight(); });
    }

    // Method to adjust the height of the target object
    void AdjustHeight()
    {
        if (targetObject != null)
        {
            Vector3 newPosition = targetObject.transform.position;
            newPosition.y = heightSlider.value * 0.1f;
            targetObject.transform.position = newPosition;
        }
    }
}
