using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IntervalSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private Transform spawnPointTransform;

    private float spawnTimer;

    private void Start()
    {
        StartCoroutine(SpawnTimerCoroutine());
    }
    
    private IEnumerator SpawnTimerCoroutine()
    {
        var counter = 0;
        while (true) //This create a infinite loop. Be really careful when using infinite loops. We is here because we can pause execution inside the coroutine.
        {
            //yield return null; //this spawns every one frame. 
            yield return new WaitForSeconds(spawnInterval); //This pauses the coroutine for spawnInterval amount of seconds. 
            SpawnPrefab();
        } 
    }
    
    //example of a timer using Update();
    // private void Update()
    // {
    //     RunSpawnTimer();
    // }
    // private void RunSpawnTimer()
    // {
    //     spawnTimer += Time.deltaTime;
    //     if (spawnTimer > spawnInterval)
    //     {
    //         spawnTimer = 0; //reset timer to 0
    //         spawnTimer -= spawnInterval; //Decrease time by spawnInterval. This gives i slightly more accurate timer.
    //         SpawnPrefab();
    //     }
    // }

    private void SpawnPrefab()
    {
        Instantiate(prefabToSpawn, spawnPointTransform.position, spawnPointTransform.rotation);
    }
}
