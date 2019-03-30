using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Reference: https://www.youtube.com/watch?v=GFNKjJ-I6rg
//Reference https://answers.unity.com/questions/1253570/creating-a-tooltip-when-hovering-over-a-ui-button.html 
public class UpgradeGenerate : MonoBehaviour
{
    public UpgradeManager upgradeManager;
    public Text upgradeText;
    //public Text upgradeCost;

    // Start is called before the first frame update
    void Start()
    {
        upgradeText.text = ("Upgrade: x" + upgradeManager.click);
        //upgradeCost.text = ("$" + upgradeManager.cost);
    }

    // Update is called once per frame

    public void Upgrade()
    {
        upgradeManager.click += 1;
        upgradeManager.Upgrade();
        upgradeText.text = ("Upgrade: x" + upgradeManager.click);
        //upgradeCost.text = ("$" + upgradeManager.cost);
    }
}
