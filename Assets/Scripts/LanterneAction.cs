﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanterneAction : MonoBehaviour
{
    private Animator myAnims;
    private bool isLighting = false;

    // Start is called before the first frame update
    void Start()
    {
        myAnims = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && !isLighting)
        {
            myAnims.SetTrigger("ActiveMouvementLight");
            isLighting = true;
        }
        if (Input.GetKeyDown(KeyCode.A) && isLighting == true)
        {
            myAnims.SetTrigger("StayLight");
        }
    }

    public void StopLighting()
    {
        isLighting = false;
    }
}
