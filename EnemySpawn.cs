using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform EnemySpawnPoint;
    public GameObject spawnEffect;
    public GameObject EnemyPrefab;
    public float spawnSpeed;
    public bool spawnTimer;

    void Start()
    {
        spawnTimer = true;
    }
    void Update()
    {
        if (spawnTimer == true)
        {
            spawnSpeed -= Time.deltaTime;
            if (spawnSpeed <= 0)
            {
                GameObject effect = Instantiate(spawnEffect, transform.position, Quaternion.identity);
                Destroy(effect, 5f);
                Spawn();
                spawnSpeed = Random.Range(15.0f, 40.0f);
            }
        }
    }

    void Spawn()
    {
        GameObject Enemy = Instantiate(EnemyPrefab, EnemySpawnPoint.position, EnemySpawnPoint.rotation);
    }
}
