using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public MoneyManager money;
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }
    public void AddMoney()
    {
        money.AddMoney();
    }

    public void BuySquare()
    {
        money.BuySquare();
    }
    public void BuyTriangle()
    {
        money.BuyTriangle();
    }
    public void BuyPolygon()
    {
        money.BuyPolygon();
    }
}
