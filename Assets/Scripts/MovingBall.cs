using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingBall : MonoBehaviour
{
    Vector3 pointA; 
    Vector3 pointB;

    float random;

    private void Start()
    {
       pointA= new Vector3(2f, -0.926f, transform.position.z);
       pointB= new Vector3(-2f, -0.926f, transform.position.z);
       random = Random.Range(1.3f, 1.8f);
    }

    private void Update()
    {

        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time*random,1f));    
    }


}
