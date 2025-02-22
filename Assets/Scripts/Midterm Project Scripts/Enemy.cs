using UnityEngine;

public interface IAttacker
{
    void Attack();
}

public interface IHaunter
{
    void Haunt();
}

public class Enemy : MonoBehaviour
{
    public virtual void Move()
    {
        Debug.Log("Enemy moves!");
    }
}

public class GhostEnemy : Enemy, IHaunter
{
    public override void Move()
    {
        base.Move();
    }

    public void Haunt()
    {
        Debug.Log("Ghost haunts the area!");
    }
}

public class Poltergeist : Enemy, IAttacker, IHaunter
{
    public override void Move()
    {
        base.Move();
    }

    public void Attack()
    {
        Debug.Log("Poltergeist throws objects!");
    }

    public void Haunt()
    {
        Debug.Log("Poltergeist creates spooky atmosphere!");
    }
}