using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lava" || collision.gameObject.tag=="rollingBall"||collision.gameObject.tag == "movingBall" || collision.gameObject.tag == "chasingBall")
        {
            //for testing, it will be commented out and just restart
            //SceneManager.LoadScene("End Screen");

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
