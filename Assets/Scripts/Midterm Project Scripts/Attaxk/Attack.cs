using UnityEngine;

public abstract class Attack : ScriptableObject
{
    [SerializeField] public string attackName;
    [SerializeField] public float damage;
    [SerializeField] public float manaCost;

    public abstract void Execute();
}