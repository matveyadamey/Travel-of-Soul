using UnityEngine;

public class CameraControlle : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
