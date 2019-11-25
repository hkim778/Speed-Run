using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBallDestroy : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (!this.gameObject.GetComponent<MeshRenderer>().enabled && collision.gameObject.tag == "movingBall")
        {
            Destroy(collision.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;



        }
    }
}
