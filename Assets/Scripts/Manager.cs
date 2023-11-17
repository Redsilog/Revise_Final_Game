using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI order;
    public TextMeshProUGUI score;


    public GameObject gameOver;
    public PlayerManager playerManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameOver();
        order.SetText("Order: " + playerManager.holder);
        score.SetText("Score: " + playerManager.score);



    }

    public void GameOver()
    {
        health.SetText("HP: " + playerManager.hp);

        if (playerManager.hp <= 0)
        {
            gameOver.SetActive(true);
        }
    }

    
}

