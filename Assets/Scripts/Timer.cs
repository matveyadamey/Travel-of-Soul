using System.Collections;
using UnityEngine;


public class Timer : MonoBehaviour
{
    TMPro.TextMeshProUGUI text;
    public static int time;
    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<TMPro.TextMeshProUGUI>();
        StartCoroutine(timer());
    }
    IEnumerator timer()
    {
        while (true)
        {
            time++;
            text.text = time.ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
