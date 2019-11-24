using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFalling : MonoBehaviour
{
    public GameObject fallingWall;

    float difference;

    // Start is called before the first frame update
    void Start()
    {
        difference = -0.33f;
        for (int i = 0; i < 7; i++)
        {
            Instantiate(fallingWall, new Vector3(0, 4.6f, difference), Quaternion.identity);
            difference -= 3;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
