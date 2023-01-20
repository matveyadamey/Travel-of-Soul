using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "winZone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            print(Timer.time);
            print(Collectioner.stars);
        }
    }
}
