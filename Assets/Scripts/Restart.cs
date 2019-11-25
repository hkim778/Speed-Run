using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    GameObject[] list;
    RunControl runControl;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            list = GameObject.FindGameObjectsWithTag("gameControl");
            runControl = list[list.Length - 1].GetComponent<RunControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToStartOfTheGame()
    {
        SceneManager.LoadScene(runControl.scenes[0]);
    }
}
