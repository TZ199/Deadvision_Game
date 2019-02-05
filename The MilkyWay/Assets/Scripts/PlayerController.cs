using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float YSpeed = 10;
    public float XSpeed = 2;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            MakeTheObjectsGoUp();
        }
    }
    private void FixedUpdate()
    {

    }
    //move in X direction
    void MoveInX()
    {
        transform.position += new Vector3(Time.deltaTime * XSpeed, 0, 0);
    }
    void MoveInY()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, YSpeed);
    }
    public void MakeTheObjectsGoUp()
    {
        Physics.gravity = new Vector3(0f, 1f, 0f);
    }

    bool TouchOrClick()
    {
        if (Input.GetButtonUp("Jump") || Input.GetMouseButtonDown(0) ||
                (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended))
            return true;
        else
            return false;
    }
}
