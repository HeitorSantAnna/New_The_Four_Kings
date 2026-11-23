using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    public void EntreSetting(GameObject settings)
    {
        settings.SetActive(true);
    }

    public void ExitSetting(GameObject settings)
    {
        settings.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void InGame(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
