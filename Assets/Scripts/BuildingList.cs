using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingList : MonoBehaviour
{
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


    }

}