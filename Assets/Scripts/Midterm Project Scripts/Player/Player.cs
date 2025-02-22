using UnityEngine;

[RequireComponent(typeof(PlayerHealthHandler)), RequireComponent(typeof(PlayerDeathHandler)), RequireComponent(typeof(PlayerDataHandler))]
public class Player : MonoBehaviour
{
    private PlayerHealthHandler health;
    private PlayerDataHandler dataManager;
    private PlayerDeathHandler deathHandler;
    private PlayerAttack attackSystem;

    private void Awake()
    {
        health = GetComponent<PlayerHealthHandler>();
        dataManager = GetComponent<PlayerDataHandler>();
        deathHandler = GetComponent<PlayerDeathHandler>();
        attackSystem = GetComponent<PlayerAttack>();
    }

    private void Start()
    {
        if (health == null || dataManager == null || deathHandler == null)
        {
            Debug.LogError("Missing required player components!");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackSystem.Attack(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackSystem.Attack(1);
        }
    }
}