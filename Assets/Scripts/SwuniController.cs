using UnityEngine;
using UnityEngine.SceneManagement;

public class SwuniController : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody2D rigid2D;
    float jumpForce = 450.0f;
    Animator Sanimator;
    Animator Wanimator;
    Animator Uanimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.Sanimator = GameObject.Find("player").transform.Find("Swuri").GetComponent<Animator>();
        this.Wanimator = GameObject.Find("player").transform.Find("Wendi").GetComponent<Animator>();
        this.Uanimator = GameObject.Find("player").transform.Find("Uri").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        //jump!
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        this.Sanimator.speed = 1f;
        this.Wanimator.speed = 1f;
        this.Uanimator.speed = 1f;
    }

    
}
