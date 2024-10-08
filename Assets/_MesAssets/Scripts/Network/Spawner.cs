using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour  // change la classe hérité
{
    public static Spawner Instance;

    [SerializeField] private float spawnTime = 1;
    public float SpawnTime => spawnTime;
    
    [SerializeField] private GameObject spawnGameObject;
    [SerializeField] private Transform[] spawnPoints;
    
    private float timer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
        
    }

    void Update()
    {
        if(timer > spawnTime)
        {

            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject spawnedZombie = Instantiate(spawnGameObject, randomPoint.position, randomPoint.rotation);
            
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    // Méthode appellé pour réduire le temps de spawn en 4
    public void ReduireSpawnTime()
    {
        spawnTime -= spawnTime / 4;
    }
}


