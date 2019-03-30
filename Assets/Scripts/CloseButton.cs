using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    AudioManager audio;
    
    public void doExitGame() 
    {
    Application.Quit();
    Debug.Log("quits game");
    }
}