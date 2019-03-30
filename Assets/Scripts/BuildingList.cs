using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingList : MonoBehaviour
{
    public MoneyIncome currencyPerSecond;
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
        Debug.Log(overflowPercent);
        //
        Debug.Log(spawnedShapes.transform.childCount);

<<<<<<< HEAD
        float moneygernationrate = ((fillPercent * 150) - ((overflowPercent *100) + spawnedShapes.transform.childCount / 4) / 10);
        Debug.Log(moneygernationrate);
=======
        float currencyPerSecond = ((fillPercent * 150) - ((overflowPercent * 100) + spawnedShapes.transform.childCount / 4) / 10);
        Debug.Log(currencyPerSecond);
>>>>>>> 27280d5e8c73c2742bf2603339e1e0c32080275b
        Debug.Log("this is the money you make per second");
        // BuiltPercent.Add()
        Instantiate(builtbuilding);
        Debug.Log("this is an attempt to spawn");
        

    }

}