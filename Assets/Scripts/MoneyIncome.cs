using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyIncome : MonoBehaviour
{
    public float currencyPerSecond;
    public MoneyManager moneyManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyManager.money += Time.deltaTime * currencyPerSecond;
    }
}
