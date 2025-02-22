using UnityEngine;

[CreateAssetMenu(fileName = "LightningAttack", menuName = "Attacks/Lightning")]
public class LightningAttack : Attack
{
    [SerializeField] private float chainDistance;

    public override void Execute()
    {
        Debug.Log($"Player used {attackName}! Deals {damage} damage and chains within {chainDistance} units!");
    }
}