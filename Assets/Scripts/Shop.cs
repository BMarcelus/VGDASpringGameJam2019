using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public float triangle;
    public float square;
    public float polygon;
    public float add;
    public float complete;
    public MoneyManager money;
    AudioManager audioManager;
    public GameObject SpawnerBuy1;
    public GameObject SpawnerBuy2;
    public GameObject SpawnerBuy3;
    public Button triangleButton;
    public Button squareButton;
    public Button polygonButton;

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
        if(money.money >= square)
        {
            money.money -= square;
            audioManager.PlaySound("Purchase");
            SpawnerBuy2.SetActive(true);
            PurchaseSquare();
        }
        money.BuySquare();
    }
    public void BuyTriangle()
    {
        if (money.money >= triangle)
        {
            money.money -= triangle;
            audioManager.PlaySound("Purchase");
            SpawnerBuy1.SetActive(true);
            PurchaseTriangle();
        }
        money.BuyTriangle();
    }
    public void BuyPolygon()
    {
        if (money.money >= triangle)
        {
            money.money -= polygon;
            audioManager.PlaySound("Purchase");
            SpawnerBuy3.SetActive(true);
            PurchasePolygon();
        }
        money.BuyPolygon();
    }

    public void PurchaseTriangle()
    {
        triangleButton.interactable = false;
    }
    public void PurchaseSquare()
    {
        squareButton.interactable = false;
    }
    public void PurchasePolygon()
    {
        polygonButton.interactable = false;
    }
}
