using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingList : MonoBehaviour
{
    public MoneyManager moneyManager;
    public GameObject builtbuilding;
    public GameObject spawnedShapes;
    public Manager manager;

    public List<float> BuiltPercent = new List<float>();
    public List<float> persecond = new List<float>();
    // float realpersecond = (actualPositive / targetPositive - falsePositive)
    public void OnButtonClick()
    {
        //  BuiltPercent.Add(percent);
        //  persecond.Add()
        float fillPercent = manager.getFilledPercent();
        Debug.Log(fillPercent);
        float overflowPercent = manager.getOverflowPercent();
        Debug.Log("this is the % you got correct");

        Debug.Log(overflowPercent);
        Debug.Log("this is out of bounds shapes");

        Debug.Log(spawnedShapes.transform.childCount);
        Debug.Log("this is the shapes you used");
        //float currencyPerSecond = (spawnedShapes.transform.childCount);
        float currencyPerSecond = (fillPercent * (fillPercent * 105)) - ((overflowPercent * spawnedShapes.transform.childCount));
        Debug.Log(currencyPerSecond);
        Debug.Log("this is the money you make per second");
        spawn(currencyPerSecond); 
   
        
       


    }
    public void spawn(float currencyPerSecond)
    {
        GameObject building = Instantiate(builtbuilding);
        MoneyIncome moneyScript = building.GetComponent<MoneyIncome>();
        moneyScript.moneyManager = moneyManager;
        moneyScript.currencyPerSecond = currencyPerSecond;
        Debug.Log(moneyManager);
    }
}   