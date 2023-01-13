using System.Collections;
using UnityEngine;

public class Fall : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(fall());
    }
    IEnumerator fall()
    {
        yield return new WaitForSeconds(1);
        rb.isKinematic = false;
        rb.AddForce(Vector3.down);
    }
}
