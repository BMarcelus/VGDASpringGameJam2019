using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public MoneyDisplay display;
    AudioManager audioManager;
    
    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //CHeck MoneyIncome Script
        display.MoneyUpdate();
        //money.ToString("F2");
    }
}
