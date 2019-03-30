using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int click;
    public float cost;
    [Range(2, 20)]
    public int costMultiply;
    Shop shop;
    // Start is called before the first frame update
    void Start()
    {
        click = 1;
        shop = GameObject.Find("Shop").GetComponent<Shop>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Upgrade()
    {
        shop.BuyUpgrade();
    }
}
