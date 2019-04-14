using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSuccess : MonoBehaviour
{
    public PlyaerController player;
    public GameObject success;
    public GameObject fail;
    public bool ended;
    public int totalStar;
    // Start is called before the first frame update
    void Start()
    {
        ended = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"&&!player.dead)
        {
            ended = true;

        }
    }
}
