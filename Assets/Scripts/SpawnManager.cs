using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);//Repeatedly call the "SpawnRandomAnimal" function when the game starts, with an initial delay of startDelay and repeating delay of spawnInterval
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()//Spawn a random animal at a random point along the screen
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
