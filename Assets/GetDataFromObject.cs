using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDataFromObject : MonoBehaviour
{
    public Manager percent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //not void because it is trying to return a real value
    public void OnButtonClick()
    {
        Debug.Log("this is attempting to get data from the grid, the percent completed");
        Debug.Log(percent.GetPercent().ToString());
        percent.ToString("#.00");


    }





}
