using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class CreateGameController : MonoBehaviour
{
    GameObject GameControl;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "End Screen")
        {
            if (GameObject.FindGameObjectsWithTag("pauseMenu").Length > 0)
            {
                GameObject[] list = GameObject.FindGameObjectsWithTag("pauseMenu");
                for (int i = 0; i < list.Length; i++)
                {
                    list[i].gameObject.SetActive(false);
                }
            }
        }

    }

    private void Awake()
    {

        GameControl = new GameObject();
        GameControl.tag = "gameControl";
        if(GameObject.FindGameObjectsWithTag("gameControl") != null)
        {
            GameObject[] gameControlList = GameObject.FindGameObjectsWithTag("gameControl");
            GameControl.name = "gameControl " + (gameControlList.Length);
        }

        GameControl.AddComponent<RunControl>();

        DontDestroyOnLoad(GameControl);
    }
}
