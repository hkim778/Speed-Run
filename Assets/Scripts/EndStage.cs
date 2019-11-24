using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EndStage : MonoBehaviour
{

    private RunControl runControl;
    GameObject[] controlList;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl") != null)
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
                    if (i == 4)
                    {
                        SceneManager.LoadScene("Leader Board");
                    }
                    else
                    {
                        runControl.clearTime[i] = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
                        SceneManager.LoadScene(runControl.scenes[i + 1]);
                    }



                }


            }
            //record each stage time 

        }
    }
}
