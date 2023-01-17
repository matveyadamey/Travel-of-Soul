using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    Rigidbody rb;
    float x,z;
    [SerializeField] float speed;
    bool IsGround;
    int time;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        time = PlayerPrefs.GetInt("time");
    }


    void FixedUpdate()
    {
        time = Timer.time;
        if (IsGround)
        {
            x = -Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            z = -Input.GetAxis("Vertical") * speed * Time.deltaTime;
            rb.velocity = new Vector3(x, 0, z);
            
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        IsGround = true;


        if (collision.gameObject.tag == "winZone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }


        if (collision.gameObject.tag == "deadZone")
        {
            PlayerPrefs.SetInt("time", time);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}
