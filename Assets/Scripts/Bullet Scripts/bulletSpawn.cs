using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class bulletSpawn : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bullets;

    public float bulletSpeed;
    public float spawnTime;
    
    public float positionNegativeX;
    public float positionPositiveX;
    void Start()
    {
        StartCoroutine(SpawnBullets());
    }

    IEnumerator SpawnBullets()
    {
        while (true)
        {
            float randomRange = Random.Range(positionNegativeX, positionPositiveX);
            Vector2 randomPosition = new Vector2(randomRange, 20);

            Instantiate(bullets, randomPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);

            rb.velocity = -transform.up * bulletSpeed;
        }
    }
}

