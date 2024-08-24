using UnityEngine;
using UnityEngine.UI;

public class FacialTics : MonoBehaviour
{
    public Animator animator;  // Reference to the Animator
    public Button button1, button2, button3, button4;  // References to the Buttons

    private readonly string neutralStateName = "New State";  // The name of the neutral state

    void Start()
    {
        // Add event listeners for button clicks
        button1.onClick.AddListener(() => PlayAnimation("BlinkingTrigger"));
        button2.onClick.AddListener(() => PlayAnimation("SquintingTrigger"));
        button3.onClick.AddListener(() => PlayAnimation("EyeTwitchTrigger"));
        button4.onClick.AddListener(() => PlayAnimation("LipTwitchTrigger"));
    }

    void Update()
    {
        // Continuously check the current state of the Animator
        AnimatorStateInfo currentState = animator.GetCurrentAnimatorStateInfo(0);

        // Enable or disable buttons based on the Animator's current state
        if (currentState.IsName(neutralStateName))
        {
            EnableButtons();
        }
        else
        {
            DisableButtons();
        }
    }

    void PlayAnimation(string triggerName)
    {
        // Reset all triggers before setting a new one to ensure no conflicts
        animator.ResetTrigger("BlinkingTrigger");
        animator.ResetTrigger("SquintingTrigger");
        animator.ResetTrigger("EyeTwitchTrigger");
        animator.ResetTrigger("LipTwitchTrigger");

        // Set the selected trigger to play the corresponding animation
        animator.SetTrigger(triggerName);
    }

    void DisableButtons()
    {
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;

        // Debug message
        Debug.Log("Buttons Disabled");
    }

    void EnableButtons()
    {
        button1.interactable = true;
        button2.interactable = true;
        button3.interactable = true;
        button4.interactable = true;

        // Debug message
        Debug.Log("Buttons Enabled");
    }
}
