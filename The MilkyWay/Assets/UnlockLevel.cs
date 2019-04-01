﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockLevel : MonoBehaviour
{
    public Button level2;
    public Button level3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlyaerController.totalcount < 2)
        {
            level2.interactable = false;
        }
        if (PlyaerController.totalcount < 4)
        {
            level3.interactable = false;
        }
    }
}
