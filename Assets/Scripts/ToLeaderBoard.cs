using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLeaderBoard : MonoBehaviour
{
    private GameObject[] controlList;

    private RunControl runControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLeaderBoard()
    {

        SceneManager.LoadScene("Leader Board");
    }
}
