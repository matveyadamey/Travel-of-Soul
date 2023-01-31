using UnityEngine;
public class Victory : MonoBehaviour
{
    [SerializeField] GameObject victoryScreen;
    [SerializeField] TMPro.TextMeshProUGUI timeText,timer,starsText;
    float time;

    private void Start()
	{
        time = Time.time;
    }
	private void Update()
	{
        timer.text = ((int)(Time.time - time)).ToString();
    }

	private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "winZone")
        {
            Time.timeScale = 0f;
            victoryScreen.SetActive(true);
   
            timeText.text = "Time: " + ((int)(Time.time - time)).ToString();
            starsText.text= "Stars:"+Collectioner.stars.ToString();
            print(Collectioner.stars);
        }
    }
}
