using UnityEngine;
public class Victory : MonoBehaviour
{
    GameObject victoryScreen;
    TMPro.TextMeshProUGUI timeText,timer,starsText;
    float time;

    private void Start()
	{
        time = Time.time;
        timer = GameObject.Find("timer").GetComponent<TMPro.TextMeshProUGUI>();
        victoryScreen = GameObject.Find("victoryScreen");
    }
	private void Update()
	{
        timer.text = ((int)(Time.time - time)).ToString();
    }

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "winZone")
        {
            victoryScreen.transform.GetChild(0).gameObject.SetActive(true);
            timeText = GameObject.Find("timeText").GetComponent<TMPro.TextMeshProUGUI>();
            starsText = GameObject.Find("starsText").GetComponent<TMPro.TextMeshProUGUI>();
            timeText.text = "Time: " + ((int)(Time.time - time)).ToString();
            starsText.text= "Stars:"+Collectioner.stars.ToString();
            print(Collectioner.stars);
            Time.timeScale = 0f;
        }
    }
}
