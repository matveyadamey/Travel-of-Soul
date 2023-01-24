using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    Rigidbody rb;
    float x,z;
    [SerializeField] float speed;
    bool IsGround;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
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
        if (collision.gameObject.tag == "deadZone")
        {
            var activeScene = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("levelNum", activeScene);
            print(activeScene);
            SceneManager.LoadScene(activeScene);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}
