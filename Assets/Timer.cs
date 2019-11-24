using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        timerUI = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl") != null)
        {
            GameObject[] controlList = GameObject.FindGameObjectsWithTag("gameControl");

            GameObject temp = controlList[controlList.Length - 1];

            //controls the time and display
            RunControl runControl = temp.GetComponent<RunControl>();

            timerUI.text = string.Format("{0:00} : {1:00}", runControl.minutes, runControl.seconds);
        }
    }
}
