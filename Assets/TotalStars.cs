using UnityEngine;
using TMPro;

public class TotalStars : MonoBehaviour
{
	TMP_Text totalStars;
	private void Start()
	{
		totalStars = GetComponent<TMP_Text>();
		if (PlayerPrefs.HasKey("stars"))
		{
			totalStars.text = "Total stars: "+PlayerPrefs.GetInt("stars").ToString();
		}
		else
		{
			totalStars.text = "Total stars: " + "0";
		}
	}
}
