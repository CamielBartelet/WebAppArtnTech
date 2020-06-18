using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerWeb : MonoBehaviour
{


    // Update is called once per frame
    // void GoToSite()
    // {
    //     Application.OpenURL("http://www.example.com");
    // }

    public GameObject buttonPush;


    private bool isItTriggered = false;

    void OnTriggerEnter() {
        Debug.Log("hi");
        if(isItTriggered == false && buttonPush.GetComponent<dropDown>().GiveIT == true){
            Application.OpenURL("http://i313818.hera.fhict.nl/WebApp/imageindex.html");
            isItTriggered = true;
        }
    }
}
