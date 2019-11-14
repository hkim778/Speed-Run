
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;

    private GameObject rollingBall;
    private StartStage rollBall;



    GameObject character;


    GameObject hi;

    //offset from the player to camera
    public Vector3 offset;

    private void Start()
    {
        character = GameObject.FindWithTag("player");
        rollingBall = GameObject.FindWithTag("rollingBallPlayField");
        rollBall = rollingBall.GetComponentInChildren<StartStage>();

    }

    private void Update()
    {

        if(rollBall.rollenter)
        {
            offset = new Vector3(0f, 2f, -3f);
        }
        else
        {
            offset = new Vector3(0, 1f, -2f);
        }

    }


    private void LateUpdate()
    {
        //TransformPoint uses the offset position from the player Gameobject
        transform.position = player.transform.TransformPoint(offset);

        //camera will look at the player wherever it is located at
        transform.LookAt(player.transform);
    }
}
