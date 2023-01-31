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
        StartCoroutine(FallCoroutine());
    }
    IEnumerator FallCoroutine()
    {
        yield return new WaitForSeconds(0.4f);
        rb.isKinematic = false;
        rb.AddForce(Vector3.down);
    }
}
