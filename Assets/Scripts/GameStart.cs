﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

using UnityEditor;




public class GameStart : MonoBehaviour
{
    public TMP_InputField user_name;

    private GameObject[] controlList;

    private RunControl runControl;
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

    public void StartGame()
    {
        if(user_name.text.Length == 3)
        {
            if (GameObject.FindGameObjectsWithTag("gameControl") != null)
            {
                runControl.userName = user_name.text;
            }

            if (SceneManager.GetActiveScene().name == "Main Start")
            {
                //go to the next scene
                SceneManager.LoadScene(runControl.scenes[0]);
            }


        }

        else
        {
            EditorUtility.DisplayDialog("Invalid", "Pleae type in 3 characters letter", "Ok");
        }






    }
}