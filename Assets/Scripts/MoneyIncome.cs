using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyIncome : MonoBehaviour
{
    public float currencyPerSecond;
    public MoneyManager moneyManager;

   
    void Update()
    {
        moneyManager.money += Time.deltaTime * currencyPerSecond;
    }
}
