using UnityEngine;
public class MusicSaver : MonoBehaviour
{
    AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioClip>();
        DontDestroyOnLoad(gameObject);
    }
}