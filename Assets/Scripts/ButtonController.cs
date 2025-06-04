using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    public void PressRetry(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
