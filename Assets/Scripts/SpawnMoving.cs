﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoving : MonoBehaviour
{
    public GameObject movingBall;

    float difference;
    // Start is called before the first frame update
    void Start()
    {
        difference = -1.47f;
        for(int i = 0; i<7; i++)
        {
            Instantiate(movingBall, new Vector3(-2.1f, -0.926f, difference),Quaternion.identity);
            difference -= 3;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}