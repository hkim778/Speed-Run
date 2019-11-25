using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    GameObject[] list;
    RunControl runControl;

    public GameObject panel;
    bool stopped;

    // Start is called before the first frame update
    void Start()
    {
        stopped = false;
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            list = GameObject.FindGameObjectsWithTag("gameControl");
            runControl = list[list.Length - 1].GetComponent<RunControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            for (int i = 0; i < runControl.scenes.Length; i++)
            {
                if (SceneManager.GetActiveScene().name == runControl.scenes[i])
                {
                    if (Input.GetKeyDown(KeyCode.Escape) && !stopped)
                    {
                        //Debug.Log("hi");
                        panel.SetActive(true);
                        Time.timeScale = 0;
                        stopped = true;
                    }

                    else if (Input.GetKeyDown(KeyCode.Escape) && stopped)
                    {
                        panel.SetActive(false);
                        Time.timeScale = 1;
                        stopped = false;
                    }
                }
            }
        }
    }
}
