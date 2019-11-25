using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public Vector3 rolling;

    public bool movement;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        movement = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(rolling);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "lava")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "rollingBall")
        {
            Destroy(this.gameObject);
        }
    }

}
