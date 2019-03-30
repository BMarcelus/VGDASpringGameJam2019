using UnityEngine;
using UnityEngine.SceneManagement;
//This returns the user to the start scene
public class ReturnScreen: MonoBehaviour
{
    private AudioManager audioManager;
    
    [SerializeField]
    string hoverSound = "HoverSound";
    [SerializeField]
    string uIClick = "UIClick";

    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();  
    }
    
    public void ReturnToScreen()
    {
        audioManager.StopSound("Credits");
        audioManager.StopSound("Ingame");
        audioManager.PlaySound("Music");
        SceneManager.LoadScene("MenuScreen",LoadSceneMode.Single);
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
