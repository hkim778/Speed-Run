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


    // Start is called before the first frame update
    void Start()
    {
        moveSeconds = Random.Range(1, 5);
        startPosition = transform.position;
        startRotation = transform.rotation;


       // StartCoroutine(Delay());
    }

    void StartMoving()
    {
        isMoving = true;
        moveTimer = 0;

        secondPosition = transform.position;
        secondRotation = transform.rotation;

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {

            StartMoving();
        }
    }

}
