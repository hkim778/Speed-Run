using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{

    public GameObject bonusBall;

    Vector3 positionBall;

    bool spawned;



    float randomX;


    // Start is called before the first frame update
    void Start()
    {

        spawned = false;

        //start coroutine
        StartCoroutine(Timer());


    }


    //function that instantiates the balls
    void SpawnBonusBall()
    {
        randomX = Random.Range(-13.36f, 13.36f);
        positionBall = new Vector3(randomX, 21.49f, 1.45f);
        Instantiate(bonusBall, positionBall, Quaternion.identity);
    }


    //providign time delay in the instantiation
    IEnumerator Timer()
    {
        if (!spawned)
        {
            for (int i = 0; i < 5; i++)
            {
                SpawnBonusBall();
                yield return new WaitForSeconds(1);
            }

            spawned = true;
        }


    }


}
