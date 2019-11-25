using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGameController : MonoBehaviour
{
    GameObject GameControl;

    public Canvas PauseMenu;
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

        Instantiate(PauseMenu);


        PauseMenu.transform.SetParent(GameControl.transform);


        DontDestroyOnLoad(GameControl);
    }
}
