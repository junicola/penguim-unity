﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    float velTransl;
    float velRot;

    void Start()
    {
        this.velRot = 5f;

        this.velTransl = 0.2f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -velTransl);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, velTransl);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-velTransl, 0, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, -velRot, 0);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, velRot, 0);
        }
        

        if(transform.position.z > 6 && transform.position.z < 7.9 && transform.position.x > 18 && transform.position.x < 20) {
            if (Input.GetKey(KeyCode.F))
            {
            transform.localScale += new Vector3(0.01f,0.01f,0.01f);
            transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
            }

            if (Input.GetKey(KeyCode.G))
            {
            transform.localScale -= new Vector3(0.01f,0.01f,0.01f);
            transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
            }
        }

        if(this.transform.position.y <= -1.40){
            this.transform.position = new Vector3(transform.position.x, -1.40f, transform.position.z);

        }    
        

    }



    
}