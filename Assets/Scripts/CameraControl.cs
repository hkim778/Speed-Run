
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CameraControl : MonoBehaviour
{

    //public GameObject player;

    private GameObject rollingBall;
    private StartStage rollBall;



    GameObject character;


    GameObject hi;

    //offset from the player to camera
    public Vector3 offset;

    private void Start()
    {
        character = GameObject.FindWithTag("player");
        //rollingBall = GameObject.FindWithTag("rollingBallPlayField");
        //rollBall = rollingBall.GetComponentInChildren<StartStage>();

    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Floor is lava")
        {
            offset = new Vector3(0, 1f, -2f);
        }
        else if (SceneManager.GetActiveScene().name == "Moving Ball")
        {
            offset = new Vector3(0, 1f, -3f);
        }
        else if(SceneManager.GetActiveScene().name == "Rolling Ball")
        {
            offset = new Vector3(0, 1.5f, -3f);
        }
        else if (SceneManager.GetActiveScene().name == "Chasing Ball")
        {
            offset = new Vector3(0, 10f, -4f);
        }




    }


    private void LateUpdate()
    {
        //TransformPoint uses the offset position from the player Gameobject
        transform.position = character.transform.TransformPoint(offset);

        //camera will look at the player wherever it is located at
        transform.LookAt(character.transform);
    }
}
