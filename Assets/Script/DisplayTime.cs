using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayTime : MonoBehaviour
{
    public GameObject theDisplay;
    int hour;
    int minutes;
    // Start is called before the first frame update
    void Start()
    {
      /*  hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        theDisplay.GetComponent<TextMeshPro>().text = "" + hour + ":" + minutes;
      */
    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        if(minutes < 10)
        {
            theDisplay.GetComponent<TextMeshPro>().text = "" + hour + ":0" + minutes;
        }
        else theDisplay.GetComponent<TextMeshPro>().text = "" + hour + ":" + minutes;
    }
}
