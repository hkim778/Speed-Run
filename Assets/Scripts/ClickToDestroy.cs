using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToDestroy : MonoBehaviour
{

    GameObject[] list;
    RunControl runControl;


    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            list = GameObject.FindGameObjectsWithTag("gameControl");
            runControl = list[0].GetComponent<RunControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            //go to next
            if(runControl != null)
            {
                SceneManager.LoadScene(runControl.scenes[0]);
            }



        }
    }


}
