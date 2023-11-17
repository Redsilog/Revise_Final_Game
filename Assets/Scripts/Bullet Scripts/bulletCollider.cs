using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollider : MonoBehaviour
{
    public PlayerManager playerManager;

    public void Start()
    {
        playerManager = GameObject.Find("Player").GetComponent<PlayerManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Collide!!!");
            playerManager.hp--;
            Destroy(gameObject);
        }

    }
}