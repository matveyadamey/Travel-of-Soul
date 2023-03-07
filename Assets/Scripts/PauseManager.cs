using UnityEngine;
public class PauseManager : MonoBehaviour
{
    bool IsPaused = false;
    [SerializeField] GameObject PauseMenu,PauseButton;
    public void Check()
    {
        if (!IsPaused)
        {
            Time.timeScale = 0f;
            IsPaused = true;
            PauseMenu.SetActive(true);
            PauseButton.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            IsPaused = false;
            PauseButton.SetActive(true);
            PauseMenu.SetActive(false);
        }
    }
}
