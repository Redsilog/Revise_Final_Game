using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColor : MonoBehaviour
{
    public PlayerManager playerManager;

    public GameObject[] redCount;
    public GameObject[] yellowCount;
    public GameObject[] blueCount;


    public GameObject red; 
    public GameObject yellow;   
    public GameObject blue; 

    public float minX = -10f; 
    public float maxX = 10f; 
    public float minY = -5f; 
    public float maxY = 5f; 

    void Start()
    {
        SpawnRedPreFab();
        SpawnBluePreFab();
        SpawnYellowPreFab();
    }

    private void Update()
    {
        if (playerManager.success == true)
        {
            SpawnRedPreFab();
            SpawnBluePreFab();
            SpawnYellowPreFab();
        }
    }

    void SpawnRedPreFab()
    {
        redCount = GameObject.FindGameObjectsWithTag("Red");

        if (redCount.Length < 1)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            Vector2 randomPosition = new Vector2(randomX, randomY);

            Instantiate(red, randomPosition, Quaternion.identity);
        }
        

    }
     void SpawnBluePreFab()
    {
        blueCount = GameObject.FindGameObjectsWithTag("Blue");

        if (blueCount.Length < 1)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            Vector2 randomPosition = new Vector2(randomX, randomY);

            Instantiate(blue, randomPosition, Quaternion.identity);
        }
    }
     void SpawnYellowPreFab()
    {
        yellowCount = GameObject.FindGameObjectsWithTag("Yellow");

        if (yellowCount.Length < 1)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            Vector2 randomPosition = new Vector2(randomX, randomY);

            Instantiate(yellow, randomPosition, Quaternion.identity);
        }
    }
}
