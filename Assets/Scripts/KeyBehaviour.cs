using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KeyBehaviour : MonoBehaviour
{
    GameObject[] list;
    RunControl runControl;

    GameObject empty;
    // Use this for initialization
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

    private void OnMouseDown()
    {

        if(list!=null)
        {
            empty = new GameObject();
            if(this.gameObject.tag == "luckyKey")
            {

                empty.tag = "luckyKey";
                empty.name = "Lucky Key";

            }

            else if(this.gameObject.tag == "openRailKey")
            {
                empty.tag = "openRailKey";
                empty.name = "Open Rail Key";
            }

            empty.transform.SetParent(list[list.Length - 1].transform);

            SceneManager.LoadScene(runControl.scenes[0]);
            //SceneManager.LoadScene("Moving Ball");
        }
    }


}
