using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public float triangle;
    public float square;
    public float polygon;
    public float rotationCost;
    public float upgradeCost;
    [Range(2, 20)]
    public int costMultiply;
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
    public Button rotationButton;
    public bool purchaseRotation;
    UpgradeManager upgradeManager;
    UpgradeGenerate upgradeGenerate;

    private void Awake()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        upgradeGenerate = gameObject.GetComponent<UpgradeGenerate>();
        purchaseRotation = false;
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
    }
    public void BuyPolygon()
    {
        if (money.money >= polygon)
        {
            money.money -= polygon;
            audioManager.PlaySound("Purchase");
            SpawnerBuy3.SetActive(true);
            PurchasePolygon();
        }
    }
    public void BuyRotation()
    {
        if (money.money >= rotationCost)
        {
            money.money -= rotationCost;
            PurchaseRotation();
        }
    }

    public void BuyUpgrade()
    {
        if (money.money >= upgradeCost)
        {
            money.money -= upgradeCost;
            upgradeCost *= costMultiply;
            PurchaseUpgrade();
        }
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
    public void PurchaseRotation()
    {
        purchaseRotation = true;
        rotationButton.interactable = false;
    }
    public void PurchaseUpgrade()
    {
        upgradeGenerate.Upgrade();
    }
}
