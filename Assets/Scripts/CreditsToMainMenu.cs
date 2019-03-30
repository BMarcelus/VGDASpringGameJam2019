using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsToMainMenu : MonoBehaviour
{

    public string sceneName;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void accessCredits()
    {
        SceneManager.LoadScene("CreditsScene",LoadSceneMode.Single);
    }
}
