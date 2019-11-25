using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour
{
    Rigidbody rb;

    private RunControl runControl;
    GameObject[] controlList;

    GameObject control;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {
            controlList = GameObject.FindGameObjectsWithTag("gameControl");

            control = controlList[controlList.Length - 1];

            runControl = controlList[controlList.Length - 1].GetComponent<RunControl>();

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F)&& GameObject.FindGameObjectWithTag("luckyKey")!=null)
        {
            //with the key obtained and the key pressing down,
            if(other.gameObject.tag == "movingBall")
            {
                other.gameObject.GetComponent<MovingBall>().movement = false;
            }

            if(other.gameObject.tag == "rollingBall")
            {
                other.gameObject.GetComponent<Roll>().movement = false;
            }

            if (other.gameObject.tag == "chasingBall")
            {
                other.gameObject.GetComponent<Chase>().movement = false;
            }

            if(other.gameObject.tag == "fallingWall")
            {
                other.gameObject.GetComponent<ReturnToStart>().movement = false;
            }

            //key is one use
            Destroy(GameObject.FindGameObjectWithTag("luckyKey"));

        }

        if (Input.GetKeyDown(KeyCode.H) && GameObject.FindGameObjectWithTag("openRailKey") != null)
        {
            if(other.gameObject.tag == "disappearingWall")
            {
                other.GetComponent<MeshRenderer>().enabled = false;
                Destroy(GameObject.FindGameObjectWithTag("openRailKey"));
            }
        }


    }
}
