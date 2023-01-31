using UnityEngine;
public class MusicSaver : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}