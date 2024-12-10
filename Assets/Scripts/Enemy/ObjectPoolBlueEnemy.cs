using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolBlueEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int poolSize = 6;
    public float spawnRate = 4.5f;

    private List<GameObject> enemyPool = new List<GameObject>();
    private float nextSpawnTime;

    void Start()
    {
        EnemyPooling();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            EnemySpawn();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void EnemyPooling()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            enemy.SetActive(false);
            enemyPool.Add(enemy);
        }
    }

    void EnemySpawn()
    {
        for (int i = 0; i < enemyPool.Count; i++)
        {
            if (!enemyPool[i].activeInHierarchy)
            {
                enemyPool[i].transform.position = transform.position;
                enemyPool[i].SetActive(true);
                return;
            }
        }
    }
}