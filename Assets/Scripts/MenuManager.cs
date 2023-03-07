using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    private void Start()
    {
		Time.timeScale = 1f;
	}
    public void RunScene(int sceneNumber)
	{
		SceneManager.LoadScene(sceneNumber);
	}

	public void Continue()
	{
		if (PlayerPrefs.HasKey("levelNum"))
		{
			RunScene(PlayerPrefs.GetInt("levelNum"));
		}
	}
	public void Nextlevel()
    {
		if (PlayerPrefs.HasKey("levelNum"))
		{
			RunScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
	public void Exit()
    {
		Application.Quit();
	}
}
