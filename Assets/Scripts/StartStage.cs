using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStage : MonoBehaviour
{

    public bool rollenter = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {

            if (this.gameObject.transform.parent.tag == "rollingBallPlayField")
            {
                rollenter = true;
            }


        }

        if(other.tag == "rollingBall")
        {
            if (this.gameObject.transform.parent.tag == "rollingBallPlayField")
            {
                Destroy(other.gameObject);
            }

        }
    }

}
