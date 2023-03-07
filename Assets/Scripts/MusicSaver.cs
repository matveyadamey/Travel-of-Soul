using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicSaver : MonoBehaviour
{
    [SerializeField] AudioSource audio;
    [SerializeField] AudioClip[] clips;
    int curMusic=0;
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "end")
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        audio.Play();
    }
    private void Update()
    {
        if (!audio.isPlaying)
        {
            if (curMusic < clips.Length-1) {
                audio.clip = clips[curMusic + 1];
            }
            else
            {
                audio.clip = clips[0];
                curMusic = 0;
            }
        }
    }
}