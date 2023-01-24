using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
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
}
