using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public float SpawnPeriod = 5f;
    public GameObject EnemyPrefab;
    public Transform[] SpawnPoints;

    public BoxCollider Trigger;
    public Transform Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartSpawn();
            Trigger.enabled = false;
        }
    }

    private void StartSpawn()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(SpawnPeriod);
        }
    }

    private void SpawnEnemy()
    {
        var spawnPosition = GetRandomPosition();
        var enemy = Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);

        enemy.GetComponent<EnemyMovement>().Player = Player;
    }

    private Vector3 GetRandomPosition()
    {
        var randomIndex = Random.Range(0, SpawnPoints.Length);
        return SpawnPoints[randomIndex].position;
    }
}
