using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStart : MonoBehaviour
{
    Vector3 startPosition, secondPosition;
    Quaternion startRotation, secondRotation;


    public float moveSeconds;
    private float moveTimer = 0;

    private bool isMoving;

    public bool movement;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        movement = true;
        moveSeconds = Random.Range(1, 5);
        startPosition = transform.position;
        startRotation = transform.rotation;

        rb = gameObject.GetComponent<Rigidbody>();

       
    }

    void StartMoving()
    {
        isMoving = true;
        moveTimer = 0;

        secondPosition = transform.position;
        secondRotation = transform.rotation;


        if(rb != null)
        {
            rb.velocity = Vector3.zero;

        }
    }

    void StopMoving()
    {
        isMoving = false;
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            if (isMoving)
            {
                moveTimer += Time.deltaTime;
                if (moveTimer > moveSeconds)
                {
                    StopMoving();
                }
                else
                {
                    float ratio = moveTimer / moveSeconds;
                    transform.position = Vector3.Lerp(secondPosition, startPosition, ratio);
                    transform.rotation = Quaternion.Slerp(secondRotation, startRotation, ratio);
                }
            }
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = false;

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            if (movement)
            {
                StartMoving();
            }


        }
    }

}
