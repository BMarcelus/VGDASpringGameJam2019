using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineManager : MonoBehaviour
{
    public GameObject[] outlines;
    public GameObject selected;
    public float timer;
    public bool waiting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>0) {
          timer -= Time.deltaTime;
        } else if(waiting) {
          selected = outlines[Random.Range(0,outlines.Length)];
          selected.transform.position = Vector3.zero;
          selected.transform.Rotate(new Vector3(0,0, Random.Range(0, 360f)));
          waiting = false;
        }
    }

    public void pickRandomOutline() {
      // selected.SetActive(false);
      selected.transform.position = Vector3.down * 100;
      waiting = true;
      timer = 0.2f;
    }
}
