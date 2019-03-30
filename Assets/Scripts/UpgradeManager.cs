using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int click;
    public float cost;
    [Range(2, 20)]
    public int costMultiply;
    // Start is called before the first frame update
    void Start()
    {
        click = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Upgrade()
    {
        cost *= costMultiply;
    }
}
