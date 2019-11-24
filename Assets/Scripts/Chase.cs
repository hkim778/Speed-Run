﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System;

public class Chase : MonoBehaviour
{
    //The target
    Transform towards;

    //To increase the movement
    [SerializeField]
    float fspeed;

    Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        //When the spawners spawn the enemy ball, the gameobject assigned to it
        //disappears, so by code, it has to be added
        if (towards == null)
        {
            towards = GameObject.FindWithTag("player").transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < towards.position.z)
        {
            //in case of when the ball outruns the player
            Destroy(this.gameObject);
        }
        else
        {
            rigid.velocity += (towards.position - transform.position).normalized * fspeed * Time.deltaTime;

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chasingBall")
        {
            Destroy(this.gameObject);
        }
    }


}