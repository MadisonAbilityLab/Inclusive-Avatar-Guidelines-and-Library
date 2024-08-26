using UnityEngine;

public class HintAttribute : PropertyAttribute
{
    public string hint;

    public HintAttribute(string hint)
    {
        this.hint = hint;
    }
}
