using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerController : MonoBehaviour
{
    public float jumpForce = 2.0f;     public float speed = -0.5f;     public bool isGrounded;     public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)         {             rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);              isGrounded = false;         }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "star")
        {
            Destroy(col.gameObject);
        }         if (col.gameObject.tag == "stick")
        {
                        isGrounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "stick")
        {
            isGrounded = false;
        }
    }
}
