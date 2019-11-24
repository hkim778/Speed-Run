using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
