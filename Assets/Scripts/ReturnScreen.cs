using UnityEngine;
using UnityEngine.SceneManagement;
//This returns the user to the start scene
public class ReturnScreen: MonoBehaviour
{
    private AudioManager audioManager;

    void Start()
    {
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();  
    }
    
    public void ReturnToScreen()
    {
        audioManager.StopSound("Credits");
        audioManager.PlaySound("Music");
        SceneManager.LoadScene("MenuScreen",LoadSceneMode.Single);
    }
}
