using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineManager : MonoBehaviour
{
    public GameObject[] outlines;
    public GameObject selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pickRandomOutline() {
      selected.SetActive(false);
      selected = outlines[Random.Range(0,outlines.Length)];
      selected.SetActive(true);
      selected.transform.Rotate(new Vector3(0,0, Random.Range(0, 360f)));
    }
}
