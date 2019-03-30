using UnityEngine;
using UnityEngine.SceneManagement;

public class screenchanger: MonoBehaviour
{
    public void ChangScreen()
    {
        SceneManager.LoadScene("ScreenSwitchTest",LoadSceneMode.Single);

    }
}
    