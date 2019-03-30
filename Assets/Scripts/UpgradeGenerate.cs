using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Reference: https://www.youtube.com/watch?v=GFNKjJ-I6rg
//Reference https://answers.unity.com/questions/1253570/creating-a-tooltip-when-hovering-over-a-ui-button.html 
public class UpgradeGenerate : MonoBehaviour
{
    int click;
    public UpgradeManager upgradeManager;
    public Text upgradeText;
    Shop shop;
    //public Text upgradeCost;

    // Start is called before the first frame update
    void Start()
    {
        click = 1;
        shop = GameObject.Find("Shop").GetComponent<Shop>();
        upgradeText.text = ("x" + click + " $" + shop.upgradeCost);
        //upgradeCost.text = ("$" + upgradeManager.cost);
    }

    // Update is called once per frame

    public void Upgrade()
    {
        upgradeManager.click += 1;
        upgradeManager.Upgrade();
        upgradeText.text = ("x" + upgradeManager.click + " $" + shop.upgradeCost);
        //upgradeCost.text = ("$" + upgradeManager.cost);
    }
}
