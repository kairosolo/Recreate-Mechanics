using UnityEngine;

public class MovementController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed;

    [SerializeField] private float acceleration;
    [SerializeField] private float deceleration;

    private Vector3 inputVector;
    private Vector3 knockbackVector;
    private float currentSpeed;
    private CharacterController characterController;
    private float initialYPosition;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        initialYPosition = transform.position.y;
    }

    private void Update()
    {
        Move(inputVector);
    }

    public void SetInput(Vector3 input)
    {
        inputVector = input;
    }

    public void ApplyKnockback(Vector3 direction, float strength)
    {
        knockbackVector = direction.normalized * strength;
    }

    private void Move(Vector3 inputVector)
    {
        if (knockbackVector.magnitude > 0.1f)
        {
            characterController.Move(knockbackVector * Time.deltaTime);
            knockbackVector = Vector3.Lerp(knockbackVector, Vector3.zero, Time.deltaTime * 5);
            return;
        }

        if (inputVector == Vector3.zero)
        {
            currentSpeed = Mathf.Max(currentSpeed - deceleration * Time.deltaTime, 0);
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, moveSpeed, Time.deltaTime * acceleration);
        }

        Vector3 movement = inputVector.normalized * currentSpeed * Time.deltaTime;
        characterController.Move(movement);
        transform.position = new Vector3(transform.position.x, initialYPosition, transform.position.z);
    }
}