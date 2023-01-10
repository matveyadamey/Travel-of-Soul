using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    Rigidbody rb;
    float x;
    float z;
    [SerializeField]float speed;
    bool IsGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGround)
        {
            print(transform.forward);
            x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            rb.velocity = new Vector3(x, 0, z);
            
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        IsGround = true;
        if (collision.gameObject.tag == "deadZone")
        {
            SceneManager.LoadScene("level1");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}
