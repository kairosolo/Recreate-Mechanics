using UnityEngine;

[CreateAssetMenu(fileName = "FireAttack", menuName = "Attacks/Fire")]
public class FireAttack : Attack
{
    [SerializeField] private float burnDuration;

    public override void Execute()
    {
        Debug.Log($"Player used {attackName}! Deals {damage} damage and burns for {burnDuration} seconds!");
    }
}