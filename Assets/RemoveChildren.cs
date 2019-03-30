using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RemoveChildren : MonoBehaviour
{
    public GameObject other;
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    public void OnButtonClick()
    {

        foreach (Transform child in other.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }



    void Update()
    {
    }
}
