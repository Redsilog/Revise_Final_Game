using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime;

public class PlayerManager : MonoBehaviour
{
    public Manager manager;

    public float hp = 3;
    public float score = 0;
    public bool success = false;
    public bool fail = false;
    public string holder = "";
    public string[] colors = { "Orange", "Violet", "Green" };

    public bool blue = false;
    public bool yellow = false;
    public bool red = false;
    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
        score = 0;

        holder = SelectRandomElement(colors);
    }

    // Update is called once per frame
    void Update()
    {
        
        correctRecipe();
        if (success)
        {
            
            holder = SelectRandomElement(colors);
            StartCoroutine(Delay());
        }
    }

    void Fail()
    {
        yellow = false;
        red = false;
        blue = false;
        success = true;
    }
    void correctRecipe()
    {
        if (holder == "Orange" && red == true && yellow == true && blue == false)
        {
            score++;
            yellow = false;
            red = false;
            success = true;
        }
        else if (holder == "Orange" && blue == true)
        {
            hp--;
            fail = true;
            Fail();
        }


        if (holder == "Violet" && red == true && blue == true && yellow == false)
        {
            score++;
            blue = false;
            red = false;
            success = true;
        }
        else if (holder == "Violet" && yellow == true)
        {
            hp--;
            fail = true;
            Fail();
        }

        if (holder == "Green" && red == false && blue == true && yellow == true)
        {
            score++;
            blue = false;
            yellow = false;
            success = true;
        }
        else if (holder == "Green" && red == true)
        {
            hp--;
            fail = true;
            Fail();
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }

    static T SelectRandomElement<T>(T[] array)
    {
        System.Random rand = new System.Random();
        int randomIndex = rand.Next(0, array.Length);

        return array[randomIndex];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Red"))
        {
            red = true;
        }

        if (collision.CompareTag("Blue"))
        {
            blue = true;
        }

        if (collision.CompareTag("Yellow"))
        {
            yellow = true;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.000001f);
        success = false;
    }

}