using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
