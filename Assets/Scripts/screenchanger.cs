using UnityEngine;
using UnityEngine.SceneManagement;
//This takes the user to the main play scene
public class screenchanger: MonoBehaviour
{
    public void ChangScreen()
    {
        SceneManager.LoadScene("WorkingScreen",LoadSceneMode.Single);

    }
}
    