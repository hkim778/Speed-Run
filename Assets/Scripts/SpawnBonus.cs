using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnBonus : MonoBehaviour
{

    public GameObject bonusBall;

    Vector3 positionBall;

    bool spawned;
    bool spawnKey;




    float randomX;

    public TMP_Text instruction;
    public TMP_Text details;

    float summon;
    float destroyed;

    public GameObject key1;
    public GameObject key2;


    // Start is called before the first frame update
    void Start()
    {

        spawned = false;
        spawnKey = false;

        summon = 0;
        destroyed = 0;

        //start coroutine
        StartCoroutine(Timer());

        


    }

    private void Update()
    {

        if (!spawnKey && spawned && GameObject.FindGameObjectsWithTag("bonusBall").Length == 0)
        {
            var rand = Random.Range(1, 3);
            //var rand = 2;
            GameObject temp;
            if(rand == 1)
            {
                temp = key1;
                details.text = "If you get Close to a moving object, Press F to stop its movement. One use";
                instruction.text = "Lucky Key!";
            }
            else
            {
                temp = key2;
                details.text = "Only avaialbe in moving balls. Press H to open the rail so the ball will disappear";
                instruction.text = "Key To Open up Rail!";
            }

            instruction.text += " Click It";
            Instantiate(temp, new Vector3(-0.4965789f, 2f, -2.9f), Quaternion.identity);

            spawnKey = true;
        }
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
        instruction.text = "Click the falling Balls for Bonus!";
        yield return new WaitForSeconds(3);
        instruction.text = "";
        for (int i = 0; i < 5; i++)
        {
            summon++;
            SpawnBonusBall();
            yield return new WaitForSeconds(1);

        }

        spawned = true;
        //Debug.Log(spawned);




    }


}



