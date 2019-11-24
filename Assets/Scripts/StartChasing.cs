using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChasing : MonoBehaviour
{
    public bool chasing;
    // Start is called before the first frame update
    void Start()
    {
        chasing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            chasing = true;
        }
    }
}
