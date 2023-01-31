using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    bool IsGround;
    Rigidbody rb;
    float x, z;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
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
            PlayerPrefs.SetInt("levelNum", activeScene+1);
            print(activeScene);
            SceneManager.LoadScene(activeScene);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        IsGround = false;
    }
}
