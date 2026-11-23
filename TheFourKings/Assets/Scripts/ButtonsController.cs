using UnityEngine;

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
}
