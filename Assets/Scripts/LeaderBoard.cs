using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LeaderBoard : MonoBehaviour
{
    public TMP_Text first;
    public TMP_Text second;
    public TMP_Text third;
    public TMP_Text fourth;
    public TMP_Text fifth;

    public TMP_Text instruction;

    TMP_Text[] order;

    GameObject[] scoreLists;
    RunControl runControl, secondControl;
    // Start is called before the first frame update
    void Start()
    {
        order = new TMP_Text[] { first, second, third, fourth, fifth };
        if (GameObject.FindGameObjectsWithTag("gameControl").Length>0)
        {
            scoreLists = GameObject.FindGameObjectsWithTag("gameControl");
            for (int i = 0; i<scoreLists.Length; i++)
            {
                runControl = scoreLists[i].GetComponent<RunControl>();
                if(runControl.userName == ""||(runControl.minutes*60 + runControl.seconds) <= 0)
                {
                    Destroy(scoreLists[i]);
                }
            }


            OrderRank(scoreLists);

            //generate the list
            GenerateScoreList(scoreLists);
        }

        StartCoroutine(MoveOnToNext());

    }

    IEnumerator MoveOnToNext()
    {

        yield return new WaitForSeconds(5);
        instruction.text = "To be continued...";
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("End Screen");

    }

    //order the list depending on the time
    void OrderRank(GameObject[] list)
    {
        for (int i = 0; i<list.Length; i++)
        {
            runControl = list[i].GetComponent<RunControl>();

            float firstTime = runControl.minutes * 60 + runControl.seconds;

            for(int j = (i+1); j<list.Length; j++)
            {
                secondControl = list[j].GetComponent<RunControl>();
                float secondTime = secondControl.minutes * 60 + secondControl.seconds;

                if (firstTime > secondTime)
                {
                    GameObject temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
    }

    void GenerateScoreList(GameObject[] list)
    {
        for (int i = 0; i<list.Length; i ++)
        {
            order[i].text = EachRank(list[i], (i+1));
        }

    }

    string EachRank(GameObject game, int rank)
    {
        RunControl control = game.GetComponent<RunControl>();

        if(control.userName == ""||(control.minutes*60 + control.seconds) <= 0)
        {
            return "";
        }
        
        return rank + ". "+ control.userName + " Time: " + string.Format("{0:00} : {1:00}", control.minutes, control.seconds);

    }
}
