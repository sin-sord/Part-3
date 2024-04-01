using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float timer = 0;
    Coroutine coinspawner;


    void Start()
    {
        coinspawner = StartCoroutine(SpawnCoin());  // This is starting the coroutine
    }


    IEnumerator SpawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);  // wait 4 seconds...
            Vector3 spawn = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);  //  a vector3 that has a spawn position to be random
            Instantiate(coinPrefab, spawn, transform.rotation);   // instantiates a coin prefab that spawns at a random positon with vector3
            ScoreTracker.totalCoin += 1;  // add "1" to the total amount of coins spawned
        }
    }

}
