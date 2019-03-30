using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public float complete;
    public float add;
    public int triangle;
    public int square;
    public int polygon;
    public MoneyDisplay display;
    AudioManager audioManager;
    
    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        money += complete / 10;
        display.MoneyUpdate();
    }

    public void AddMoney()
    {
        complete += add;
        money.ToString("F2");
        display.MoneyUpdate();
    }

    public void BuySquare()
    {
        display.MoneyUpdate();
    }

    public void BuyTriangle()
    {
        display.MoneyUpdate();
    }

    public void BuyPolygon()
    {
        display.MoneyUpdate();
    }
}
