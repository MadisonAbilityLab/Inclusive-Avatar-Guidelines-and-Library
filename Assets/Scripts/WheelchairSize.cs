using UnityEngine;

[ExecuteInEditMode]
public class WheelchairSize : MonoBehaviour
{
    [Header("Size Parameters")]
    [Range(0.8f, 1.2f)]
    public float sizeMultiplier = 1.0f;

    [SerializeField]
    private Vector3 originalScale = Vector3.zero;

    void Awake()
    {
        // Ensure originalScale is set when the script awakens
        if (originalScale == Vector3.zero)
        {
            originalScale = transform.localScale;
        }
        UpdateSize();
    }

#if UNITY_EDITOR
    void OnValidate()
    {
        // Ensure originalScale is set when changes are made in the Inspector
        if (originalScale == Vector3.zero)
        {
            originalScale = transform.localScale;
        }
        UpdateSize();
    }
#endif

    void UpdateSize()
    {
        // Apply the size multiplier to the original scale
        transform.localScale = originalScale * sizeMultiplier;
    }
}
