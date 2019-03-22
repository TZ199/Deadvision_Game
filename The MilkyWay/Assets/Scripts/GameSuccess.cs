using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSuccess : MonoBehaviour
{
    public PlyaerController player;
    public GameObject success;
    public GameObject fail;
    public int totalStar;
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
        if (col.gameObject.tag == "Player"&&!player.dead)
        {
            if (player.count == totalStar)
            {
                success.SetActive(true);
            }
            else
            {
                fail.SetActive(true);
            }

        }
    }
}
