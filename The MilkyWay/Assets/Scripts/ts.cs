using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ts : MonoBehaviour
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
            player.transform.Translate(new Vector3(0.0f, -2.7f, 0.0f), Space.Self);
        }



    }
}
