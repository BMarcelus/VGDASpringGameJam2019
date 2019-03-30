using UnityEngine;
using UnityEngine.SceneManagement;
//This takes the user to the main play scene
public class screenchanger: MonoBehaviour
{
    AudioManager audioManager;
    [SerializeField]
    string music = "Music";
    [SerializeField]
    string inGame = "Ingame";
    
    public void ChangScreen()
    {
        SceneManager.LoadScene("WorkingScreen",LoadSceneMode.Single);

    }
    
    public void Music()
    {
        audioManager.StopSound(music);
    }

    public void Ingame()
    {
        audioManager.PlaySound(inGame);
    }
}  