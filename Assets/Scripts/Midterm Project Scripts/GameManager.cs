using UnityEngine;

public class GameManager : MonoBehaviour
{
    private IEnemyBehavior enemyBehavior;

    public void SetEnemyBehavior(IEnemyBehavior behavior)
    {
        enemyBehavior = behavior;
    }

    private void Start()
    {
        if (enemyBehavior == null)
        {
            enemyBehavior = new EnemyAI();
        }

        enemyBehavior.StartChasing();
    }
}

public interface IEnemyBehavior
{
    void StartChasing();
}

public class EnemyAI : IEnemyBehavior
{
    public void StartChasing()
    {
        Debug.Log("Enemy is chasing the player.");
    }
}

public class StealthEnemyAI : IEnemyBehavior
{
    public void StartChasing()
    {
        Debug.Log("Enemy is stealthily stalking the player.");
    }
}

public class EnemyBehaviorFactory
{
    public static IEnemyBehavior CreateEnemyBehavior(string type)
    {
        switch (type.ToLower())
        {
            case "stealth":
                return new StealthEnemyAI();

            default:
                return new EnemyAI();
        }
    }
}