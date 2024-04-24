using UnityEngine;
using UnityEngine.UI;

public class OnClickRecipe : MonoBehaviour
{
    // Reference to the associated text object
    public GameObject associatedText;

    // Method to handle button click event
    public void OnButtonClick()
    {
        // Check if the associated text is active
        if (associatedText != null && !associatedText.activeSelf)
        {
            // Activate the associated text
            associatedText.SetActive(true);
        }
    }
}
