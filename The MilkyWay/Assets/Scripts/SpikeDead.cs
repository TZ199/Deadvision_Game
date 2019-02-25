using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDead : MonoBehaviour
{
    public PlyaerController player;
    public GameObject gameover;
    public GameObject restart;
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
            player.dead = true;
            gameover.SetActive(true);
            restart.SetActive(true);
        }



    }
}
