using System.Collections;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] private Transform  pointB;
    Vector3 firstPos, secondPos,destination;
    [SerializeField] private float speed;
    void Start()
    {
        firstPos = transform.position;
        secondPos = pointB.position;
        destination = firstPos;
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position,destination)<0.1f)
        {
            destination = destination == firstPos ? secondPos : firstPos;
        }
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime*speed);
    }
}
