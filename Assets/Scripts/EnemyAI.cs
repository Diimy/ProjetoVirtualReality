using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public int life = 3;
    public float attackDistance = 0.8f;
    public float attackCooldown = 1f;

    private float nextAttackTime = 0f;

    private NavMeshAgent agent;
    private Transform player;

    [HideInInspector]
    public EnemySpawner spawner;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        agent.SetDestination(player.position);

        float dist = Vector3.Distance(transform.position, player.position);

        if (dist <= attackDistance && Time.time >= nextAttackTime)
        {
            AttackPlayer();
            nextAttackTime = Time.time + attackCooldown;
        }
    }

    void AttackPlayer()
    {
        PlayerLife pl = player.GetComponent<PlayerLife>();
        if (pl != null)
        {
            pl.TakeDamage(1);
        }

        // aVISA O SPAWNER QUE ESTE INIMIGO "MORREU" AO ATACAR
        if (spawner != null)
            spawner.OnEnemyKilled();

        // DESTRÓI O INIMIGO
        Destroy(gameObject);
    }

    public void TakeDamage(int dmg)
    {
        life -= dmg;
        if (life <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // aVISA O SPAWNER QUANDO MORRE POR DANO
        if (spawner != null)
            spawner.OnEnemyKilled();

        Destroy(gameObject);
    }
}
