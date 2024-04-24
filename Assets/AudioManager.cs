using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource; // Reference to the AudioSource component

    // Method to play an audio clip
    public void PlayAudio(AudioClip audioClip)
    {
        // Ensure that the audio clip and audio source are not null
        if (audioClip != null && audioSource != null)
        {
            // Assign the audio clip to the AudioSource and play it
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
