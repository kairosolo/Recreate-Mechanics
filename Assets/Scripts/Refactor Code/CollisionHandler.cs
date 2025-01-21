using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [Header("Collision")]
    [SerializeField] private LayerMask wallLayer;

    [Header("Knockback")]
    [Tooltip("Strength of the knockback effect")]
    [SerializeField] private float knockbackStrength = 5f;

    private MovementController movementController;

    private void Awake()
    {
        movementController = GetComponent<MovementController>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((wallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            ApplyKnockback(hit.normal);
            AudioHandler.Instance.PlayExplosionSFX();
            VFXHandler.Instance.PlayExplosionVFX();
        }
    }

    private void ApplyKnockback(Vector3 collisionNormal)
    {
        Vector3 knockbackDirection = collisionNormal;
        movementController.ApplyKnockback(knockbackDirection, knockbackStrength);
    }
}