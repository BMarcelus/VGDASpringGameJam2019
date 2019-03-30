using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuToGameButton : MonoBehaviour
{
    public class SceneLoader : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("ScreenSwitchTest");
            }
        }
    }
}