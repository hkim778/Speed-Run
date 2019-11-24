using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunControl : MonoBehaviour
{

    public string userName;


    public float minutes;
    public float seconds;

    private bool finishRun;



    private string scene1;
    private string scene2;
    private string scene3;
    private string scene4;
    private string scene5;

    public string[] scenes;
    public string[] clearTime;


    // Start is called before the first frame update
    void Start()
    {


        scene1 = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(2));
        scene2 = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(3));
        scene3 = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(4));
        scene4 = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(5));
        scene5 = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(6));


        scenes = new string[] { scene1, scene2,scene3,scene4,scene5 };
        clearTime = new string[5];

        finishRun = false;

        //randomize
        Shuffle(scenes);


    }

    // Update is called once per frame
    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Main Start"|| SceneManager.GetActiveScene().name == "Bonus" || SceneManager.GetActiveScene().name == "End Screen")
        {
            //does nothing for the timer
        }

        else
        {
            //to see if the user has reached it's limit
            if (!finishRun)
            {
                seconds += Time.deltaTime;
                if (seconds >= 60)
                {
                    minutes++;
                    seconds = 0;
                }
            }
            //separate timer for each controller

        }
    }

    void Shuffle(string[] arr)
    {
        //randomize the order of the scene order
        for(int i = 0; i <arr.Length; i++)
        {
            string temp = arr[i];

            int randNumber = Random.Range(0, arr.Length - 1);

            arr[i] = arr[randNumber];
            arr[randNumber] = temp;
        }




    }
}
