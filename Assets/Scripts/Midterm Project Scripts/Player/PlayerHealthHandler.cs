using UnityEngine;
using TMPro;

public class PlayerHealthHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;
    private int health = 100;
    private PlayerDeathHandler deathHandler;

    private void Awake()
    {
        deathHandler = GetComponent<PlayerDeathHandler>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            RecoverHealth(10);
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int savedHealth)
    {
        health = savedHealth;
        healthText.text = $"Health: {health}";
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            deathHandler.HandleDeath();
        }
        healthText.text = $"Health: {health}";
    }

    public void RecoverHealth(int amount)
    {
        health += amount;
        if (health >= 100)
        {
            health = 100;
        }
        healthText.text = $"Health: {health}";
    }
}