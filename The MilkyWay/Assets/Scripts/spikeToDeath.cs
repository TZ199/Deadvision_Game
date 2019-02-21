using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeToDeath : MonoBehaviour
{
    public GameObject gameover;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("circle player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameover.SetActive(true);
            player.dead = true;

        }
    }
}
