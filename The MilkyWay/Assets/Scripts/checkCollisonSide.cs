using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollisonSide : MonoBehaviour
{
    public PlyaerController player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"&& col.GetType()== typeof(EdgeCollider2D))
        {
            print("entered");
            player.canJump = true;
            player.isGrounded = true;
        }
    }
}
