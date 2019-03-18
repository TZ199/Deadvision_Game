using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform3 : MonoBehaviour
{
    public GameObject player;
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
        if (col.gameObject.tag == "Player")
        {

            player.transform.Translate(new Vector3(3.2f, -9f, 0.0f) * 0.5f, Space.World);
        }



    }
}
