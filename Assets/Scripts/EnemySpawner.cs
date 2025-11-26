using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Configurações")]
    public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float respawnDelay = 2f;

    private GameObject currentEnemy;

    void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        currentEnemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        currentEnemy.GetComponent<EnemyAI>().spawner = this;
    }

    public void OnEnemyKilled()
    {
        Invoke(nameof(SpawnEnemy), respawnDelay);
    }
}
