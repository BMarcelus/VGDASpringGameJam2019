using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsToMainMenu : MonoBehaviour
{
    AudioManager audioManager;
    public string sceneName;
    [SerializeField]
    string hoverSound = "HoverSound";
    [SerializeField]
    string uIClick = "UIClick";

    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void accessCredits()
    {
        SceneManager.LoadScene("CreditsScene",LoadSceneMode.Single);
    }

    public void HoverSound()
    {
        audioManager.PlaySound(hoverSound);
    }
    
    public void UIClick()
    {
        audioManager.PlaySound(uIClick);
    }
}