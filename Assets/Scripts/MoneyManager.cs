using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int money;
    public int triangle;
    public int square;
    public int polygon;
    AudioManager audioManager;
    
    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney()
    {
        money += 1000;
    }

    public void BuySquare()
    {
        if(money >= square)
        {
            money -= square;
            audioManager.PlaySound("Purchase");
        }
    }

    public void BuyTriangle()
    {
        if(money >= triangle)
        {
            money -= triangle;
            audioManager.PlaySound("Purchase");
        }
    }

    public void BuyPolygon()
    {
        if(money >= polygon)
        {
            money -= polygon;
            audioManager.PlaySound("Purchase");
        }
    }
}
