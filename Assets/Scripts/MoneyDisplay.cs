using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    public Text money;
    public MoneyManager manager;
    // Start is called before the first frame update
    void Start()
    {
        money.text = ("Currency: $" + manager.money);
    }

    public void MoneyUpdate()
    {
        money.text = ("Currency: $" + manager.money);
    }
}
