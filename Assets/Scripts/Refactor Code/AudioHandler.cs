using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public static AudioHandler Instance;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayExplosionSFX()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}