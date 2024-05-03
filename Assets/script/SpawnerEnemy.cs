using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float timeSpawn = 2;
    private float timer;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) 
        {
            timer = timeSpawn;
            Instantiate(enemyPrefab, transform);
        
        }
    }
}
