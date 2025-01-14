using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Rigidbody rb;
    private FirstPersonController player;
    private MeshCollider meshCollider;

    private void Awake()
    {
        player = FindFirstObjectByType<FirstPersonController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.parent == player.GetHand())
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, Vector3.zero, Time.deltaTime * 10f);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * 10f);
        }
    }

    public void PickUp()
    {
        transform.parent = player.GetHand();
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void Drop()
    {
        transform.parent = null;
        rb.constraints = RigidbodyConstraints.None;
    }

    public void Throw(float force, Vector3 direction)
    {
        transform.parent = null;
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(direction * force, ForceMode.Impulse);
    }
}