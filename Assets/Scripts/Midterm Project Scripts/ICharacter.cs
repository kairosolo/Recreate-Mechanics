using UnityEngine;

public interface IMovable
{
    void Move();
}

public interface ICombatant
{
    void Attack();
}

public interface ISpellcaster
{
    void CastSpell();
}

public class Warrior : IMovable, ICombatant
{
    public void Move()
    {
        Debug.Log("Warrior moves.");
    }

    public void Attack()
    {
        Debug.Log("Warrior attacks.");
    }
}

public class Mage : IMovable, ICombatant, ISpellcaster
{
    public void Move()
    {
        Debug.Log("Mage moves.");
    }

    public void Attack()
    {
        Debug.Log("Mage attacks with staff.");
    }

    public void CastSpell()
    {
        Debug.Log("Mage casts a spell!");
    }
}

public class Rogue : IMovable
{
    public void Move()
    {
        Debug.Log("Rogue moves stealthily.");
    }

    public void Attack()
    {
        Debug.Log("Rogue attacks from shadows.");
    }
}