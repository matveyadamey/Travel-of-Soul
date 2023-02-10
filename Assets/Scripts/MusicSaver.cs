using UnityEngine;
public class MusicSaver : MonoBehaviour
{
    AudioSource audio;
    [SerializeField] AudioClip[] clips;
    int curMusic=0;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audio = GetComponent<AudioSource>();
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