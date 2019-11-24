using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EndStage : MonoBehaviour
{

    private RunControl runControl;
    GameObject[] controlList;

    private float m=0;
    private float s=0;

    private float stageTime;


    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl") == null)
        {
            controlList = GameObject.FindGameObjectsWithTag("gameControl");

            runControl = controlList[controlList.Length - 1].GetComponent<RunControl>();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "chasingBall")
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag  == "player")
        {

            //load the next randomize
            for (int i = 0; i < runControl.scenes.Length; i++)
            {


                if (SceneManager.GetActiveScene().name == runControl.scenes[i])
                {
 

                    if (i == 0)
                    {
                        runControl.clearTime[i] = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
                        runControl.tempM = runControl.minutes;
                        runControl.tempS = runControl.seconds;
                    }
                    else if (i > 0)
                    {
                        stageTime = (runControl.minutes * 60 + runControl.seconds) - (runControl.tempM * 60 + runControl.tempS); 

                        //bigger than one min
                        if (stageTime >= 60)
                        {
                            m = stageTime / 60;
                            s = stageTime % 60;
                        }
                        else
                        {
                            s = stageTime % 60;
                        }

                        //find the difference between each stage so they can measure the actual time it took
                        runControl.clearTime[i] = string.Format("{0:00} : {1:00}", m, s);
                        runControl.tempM = runControl.minutes;
                        runControl.tempS = runControl.seconds;
                        if (i == 4)
                        {

                            runControl.finalTime = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
                            SceneManager.LoadScene("Leader Board");
                        }
                    }
                        SceneManager.LoadScene(runControl.scenes[i + 1]);
                }



            }


        }
            //record each stage time 

    }
}

