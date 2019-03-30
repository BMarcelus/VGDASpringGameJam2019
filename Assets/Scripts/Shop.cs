﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public MoneyManager money;
    public MoneyDisplay display;

    public void AddMoney()
    {
        money.AddMoney();
        if (display != null)
        {
            display.MoneyUpdate();
        }
    }

    public void BuySquare()
    {
        money.BuySquare();
        if (display != null)
        {
            display.MoneyUpdate();
        }
    }
    public void BuyTriangle()
    {
        money.BuyTriangle();
        if (display != null)
        {
            display.MoneyUpdate();
        }
    }
    public void BuyPolygon()
    {
        money.BuyPolygon();
        if (display != null)
        {
            display.MoneyUpdate();
        }
    }
}
