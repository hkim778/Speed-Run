using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject rollingBalls;
    private GameObject stageName;

    private StartStage startStage;

    Vector3 rollingPosition;

    private Roll roll;
    float randomP;

    private GameObject rollingBall;
    private StartStage rollBall;




    // Start is called before the first frame update
    void Start()
    {


        rollingBall = GameObject.FindWithTag("rollingBallPlayField");
        rollBall = rollingBall.GetComponentInChildren<StartStage>();

        roll =rollingBalls.GetComponent<Roll>();

        InvokeRepeating("SpawnBall",0.1f,0.5f);



    }

    void SpawnBall()
    {


        if(rollBall.rollenter)
        {
            randomP = Random.Range(-3.84f, 1.16f);
            rollingPosition = new Vector3(randomP, 4.767f, -7.494f);
            roll.rolling = new Vector3(0, 0, 10);
            Instantiate(rollingBalls, rollingPosition, Quaternion.identity);


        }
            }

}
