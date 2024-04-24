using UnityEngine;
using UnityEngine.UI;

public class OnClickRecipe : MonoBehaviour
{
    public GameObject associatedText;
    public AudioClip audioClip;

    private CanvasGroup textCanvasGroup;
    private AudioSource audioSource;

    void Start()
    {
        // Get the CanvasGroup component attached to the associated text
        textCanvasGroup = associatedText.GetComponent<CanvasGroup>();

        // Ensure that the text is initially transparent
        textCanvasGroup.alpha = 0f;

        // Add an AudioSource component to this GameObject
        audioSource = gameObject.AddComponent<AudioSource>();

        // Ensure that the AudioSource is not playing on awake
        audioSource.playOnAwake = false;

        // Assign the audio clip to the AudioSource
        audioSource.clip = audioClip;
    }

    // Method to handle button click event
    public void OnButtonClick()
    {
        // Fade in the associated text when the button is clicked
        if (associatedText != null)
        {
            // Activate the associated text
            associatedText.SetActive(true);

            // Fade in the text
            FadeInText();

            // Play the audio clip
            if (audioSource != null && audioClip != null)
            {
                audioSource.Play();
            }
        }
    }

    // Helper method to fade in the associated text
    private void FadeInText()
    {
        // Start a coroutine to gradually increase the alpha value
        StartCoroutine(FadeInCoroutine());
    }

    // Coroutine to fade in the text gradually
    private System.Collections.IEnumerator FadeInCoroutine()
    {
        float duration = 1f; // Duration of the fade-in animation
        float elapsedTime = 0f;
        
        while (elapsedTime < duration)
        {
            // Incrementally increase the alpha value over time
            textCanvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsedTime / duration);

            // Update the elapsed time
            elapsedTime += Time.deltaTime;

            yield return null; // Wait for the next frame
        }

        // Ensure that the alpha value is exactly 1
        textCanvasGroup.alpha = 1f;
    }
}
