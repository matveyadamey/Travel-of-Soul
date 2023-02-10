using UnityEngine;
using UnityEngine.UI;
public class PauseManager : MonoBehaviour
{
    bool IsPaused = false;
    [SerializeField] Sprite pause, resume;
    public void Check()
    {
        if (!IsPaused)
        {
            Time.timeScale = 0f;
            GetComponent<Image>().sprite = resume;
            IsPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            GetComponent<Image>().sprite = pause;
            IsPaused = false;
        }
    }
}
