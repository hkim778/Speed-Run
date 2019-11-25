using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KeyCheck : MonoBehaviour
{
    public TMP_Text keyCheckUI;
    GameObject temp;

    int luckyKey;
    int railKey;
    // Start is called before the first frame update
    void Start()
    {
        luckyKey = 0;
        railKey = 0;
        StartCoroutine(CheckForKeys());

        //timerUI = gameObject.GetComponent<TMP_Text>();

    }

    IEnumerator CheckForKeys()
    {

        keyCheckUI.text = SceneManager.GetActiveScene().name + " RUNNN";
        yield return new WaitForSeconds(3);
        if (GameObject.FindGameObjectsWithTag("gameControl").Length > 0)
        {

            GameObject[] controlList = GameObject.FindGameObjectsWithTag("gameControl");

            temp = controlList[controlList.Length - 1];

            for (int i = 0; i < temp.transform.childCount; i++)
            {
                if (temp.transform.GetChild(i).tag == "luckyKey")
                {
                    luckyKey++;
                }
                else if (temp.transform.GetChild(i).tag == "openRailKey")
                {
                    railKey++;
                }
            }

            keyCheckUI.text = "Lucky Key: " + luckyKey + " Rail Key: " + railKey;



        }
    }

}
