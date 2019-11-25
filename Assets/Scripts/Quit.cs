using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ToLast()
    {

        //Debug.Log(this.gameObject.transform.parent.gameObject.transform.parent);
        SceneManager.LoadScene("End Screen");
        //Destroy(this.gameObject.transform.parent.gameObject.transform.parent);
    }
}
