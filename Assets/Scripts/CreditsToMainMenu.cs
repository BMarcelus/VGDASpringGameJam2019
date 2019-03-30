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
    [SerializeField]
    string music = "Music";
    [SerializeField]
    string inGame = "Ingame";
    [SerializeField]
    string credits = "Credits";
    
    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void accessCredits()
    {
        audioManager.StopSound("Music");
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

    public void Music()
    {
        audioManager.PlaySound(music);
    }

    public void Ingame()
    {
        audioManager.StopSound(inGame);
    }

    public void Credits()
    {
        audioManager.PlaySound(credits);
    }
}