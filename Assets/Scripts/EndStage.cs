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
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
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
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            if (other.gameObject.tag == "player")
            {

                //load the next randomize
                for (int i = 0; i < runControl.scenes.Length; i++)
                {


                    if (SceneManager.GetActiveScene().name == runControl.scenes[i])
                    {
                        int keyGenerate = Random.Range(1, 5);

                        GameObject empty = new GameObject();
                        if (keyGenerate == 1)
                        {
                            //25percent chance
                            empty.tag = "luckyKey";
                            empty.name = "Lucky Key";

                        }

                        else if (keyGenerate == 2)
                        {
                            //25percent chance
                            empty.tag = "openRailKey";
                            empty.name = "Open Rail Key";
                        }
                        else
                        {
                            Debug.Log("No Keys");
                        }

                        empty.transform.SetParent(controlList[controlList.Length - 1].transform);


                        if (i == 0)
                        {
                            runControl.clearTime[i] = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
                            runControl.tempM = runControl.minutes;
                            runControl.tempS = runControl.seconds;
                            SceneManager.LoadScene(runControl.scenes[i + 1]);
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
                            //record each stage time 

                            //find the difference between each stage so they can measure the actual time it took
                            runControl.clearTime[i] = string.Format("{0:00} : {1:00}", m, s);
                            runControl.tempM = runControl.minutes;
                            runControl.tempS = runControl.seconds;
                            if (i == 4)
                            {
                                for (int j = 0; j < controlList[controlList.Length-1].transform.childCount; j++)
                                {
                                    if (controlList[controlList.Length - 1].transform.GetChild(i).tag == "pauseMenu")
                                    {
                                        Destroy(controlList[controlList.Length - 1].transform.GetChild(i));
                                    }
                                }
                                runControl.finalTime = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
                                SceneManager.LoadScene("Leader Board");
                            }
                            else
                            {
                                SceneManager.LoadScene(runControl.scenes[i + 1]);
                            }
                        }
                    }
                }

            }


        }

    }
}

