using UnityEngine;
using UnityEngine.SceneManagement;
//This returns the user to the start scene
public class ReturnScreen: MonoBehaviour
{
    public void ReturnToScreen()
    {
        SceneManager.LoadScene("MenuScreen",LoadSceneMode.Single);

    }
}
