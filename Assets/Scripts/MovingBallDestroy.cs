using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBallDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (!this.gameObject.GetComponent<MeshRenderer>().enabled && other.gameObject.tag == "movingBall")
        {
            Destroy(other.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;

        }
    }
}
