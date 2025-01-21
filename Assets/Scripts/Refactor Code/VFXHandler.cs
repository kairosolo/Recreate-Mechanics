using UnityEngine;

public class VFXHandler : MonoBehaviour
{
    public static VFXHandler Instance;

    [Header("Effects")]
    [SerializeField] private ParticleSystem explosionVFX;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayExplosionVFX()
    {
        if (explosionVFX != null)
        {
            explosionVFX.Play();
        }
    }
}