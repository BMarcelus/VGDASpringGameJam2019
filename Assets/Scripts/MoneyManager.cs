using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int money;
    public int triangle;
    public int square;
    public int polygon;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }

    public void BuyTriangle()
    {
        if(money >= triangle)
        {
            money -= triangle;
        }
    }

    public void BuyPolygon()
    {
        if(money >= polygon)
        {
            money -= polygon;
        }
    }
}
