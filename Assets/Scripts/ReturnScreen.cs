using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScreen: MonoBehaviour
{
    public void ReturnToScreen()
    {
        SceneManager.LoadScene("MenuScreen",LoadSceneMode.Single);

    }
}
