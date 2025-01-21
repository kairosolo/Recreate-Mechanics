using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] private KeyCode forwardKey = KeyCode.W;

    [SerializeField] private KeyCode backwardKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private MovementController movementController;

    private void Awake()
    {
        movementController = GetComponent<MovementController>();
    }

    private void Update()
    {
        float xInput = 0;
        float zInput = 0;

        if (Input.GetKey(forwardKey)) zInput++;
        if (Input.GetKey(backwardKey)) zInput--;
        if (Input.GetKey(leftKey)) xInput--;
        if (Input.GetKey(rightKey)) xInput++;

        movementController.SetInput(new Vector3(xInput, 0, zInput));
    }
}