using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab nepřítele
    public Transform[] spawnPoints; // Pole s spawnpointy
    public float spawnTime = 5f; // Čas v sekundách mezi spawnováním nepřátel

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    void SpawnEnemy()
    {
        if (spawnPoints.Length == 0)
            return;

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
