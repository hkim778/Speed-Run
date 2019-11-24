using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChaser : MonoBehaviour
{
    StartChasing StartChasing;

    public GameObject ball;
    float randomX;
    Vector3 chasingPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartChasing = GameObject.Find("Starting Point").GetComponent<StartChasing>();

        InvokeRepeating("SpawnChasingBall", 0.5f, 1f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnChasingBall()
    {
        if (StartChasing.chasing == true)
        {

            randomX = Random.Range(0.9f, -3.59f);
            chasingPosition = new Vector3(randomX, 4.656f, 12.29f);
            Instantiate(ball,chasingPosition,Quaternion.identity);
        }
    }

}
