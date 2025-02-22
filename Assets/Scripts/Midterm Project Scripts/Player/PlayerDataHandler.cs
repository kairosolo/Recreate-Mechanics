using UnityEngine;

public class PlayerDataHandler : MonoBehaviour
{
    private PlayerHealthHandler playerHealth;

    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealthHandler>();
    }

    private void Start()
    {
        LoadPlayerData();
    }

    public void SavePlayerData()
    {
        PlayerPrefs.SetInt("PlayerHealth", playerHealth.GetHealth());
        Debug.Log("Player data saved.");
    }

    public void LoadPlayerData()
    {
        if (!PlayerPrefs.HasKey("PlayerHealth"))
        {
            PlayerPrefs.SetInt("PlayerHealth", playerHealth.GetHealth());
        }

        playerHealth.SetHealth(PlayerPrefs.GetInt("PlayerHealth"));
        Debug.Log("Player data loaded.");
    }

    private void OnApplicationQuit()
    {
        SavePlayerData();
    }
}