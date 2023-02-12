using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    Vector3 direction;
    [SerializeField] float jumpspeed;
    bool isGrounded;
    Animator anim;
    Vector3 startPosition;
    [SerializeField] GameObject beginagain;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
       anim = GetComponent<Animator>();
       rb.transform.position = beginagain.transform.position;
       startPosition = transform.position;  
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = transform.TransformDirection(x, 0, z);

        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                rb.AddForce(new Vector3(0, jumpspeed, 0), ForceMode.Impulse);
            }
        }

        //change anims
        if (direction.magnitude > 0) {
            anim.SetBool("Run", true);

    }
    else anim.SetBool("Run", false);

    if (transform.position.y < -10) {
        transform.position = startPosition;
    }
}

    private void FixedUpdate() {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }
    
    private void OnCollisionStay( Collision collision) {
        if (collision != null) {
            isGrounded = true;
            anim.SetBool("Jump", false);
        }

    }
    private void OnCollisionExit(Collision collision) {
        isGrounded = false;
        anim.SetBool("Jump", true);
    }

    private void OnTriggerEnter(Collider collider ) {
        if (collider.CompareTag("plate")) {
            Destroy(collider.gameObject);
        }

        if (collider.CompareTag("Checkpoint")) {
            startPosition = transform.position;
        }

        if (collider.CompareTag("home")) {
            rb.transform.position = new Vector3(0,3,0);
            startPosition = transform.position;
            Cursor.lockState = CursorLockMode.None;
            GetComponent<Move>().enabled = false;
            GetComponent<Look>().enabled = false;
            SceneManager.LoadScene(1);
        }
    }
}    
