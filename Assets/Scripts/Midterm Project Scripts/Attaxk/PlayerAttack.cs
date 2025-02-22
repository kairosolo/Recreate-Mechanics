using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private List<Attack> availableAttacks;
    [SerializeField] private TMP_Text attackDescription;

    private void Start()
    {
        attackDescription.text = "";
    }

    public void Attack(int attackIndex)
    {
        if (attackIndex >= 0 && attackIndex < availableAttacks.Count)
        {
            availableAttacks[attackIndex].Execute();
            attackDescription.text = $"Player used {availableAttacks[attackIndex].attackName}!\nDeals {availableAttacks[attackIndex].damage} damage!";
        }
        else
        {
            Debug.LogWarning("Invalid attack index!");
        }
    }
}