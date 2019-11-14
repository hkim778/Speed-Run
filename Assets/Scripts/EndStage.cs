using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStage : MonoBehaviour
{
    private GameObject stageName;
    private StartStage startStage;

    // Start is called before the first frame update
    void Start()
    {
        stageName = GameObject.Find(this.gameObject.transform.parent.name);
        startStage = stageName.gameObject.GetComponentInChildren<StartStage>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player"){
            if (this.gameObject.transform.parent.tag == "rollingBallPlayField")
            {
                startStage.rollenter = false;
            }

        }
    }
}
