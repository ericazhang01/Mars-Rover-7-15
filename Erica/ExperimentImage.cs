using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ExperimentImage : MonoBehaviour
{
    public GameObject[] rockList; // list of rocks in the experiment popup.
    public GameObject defaultImage;// The default white popup that appears when there are no special rocks in the area. 
    

    void Start() {
        ResetImage();
    }

    public void ChangeImage(int num) { // Called when the Child trigger attached to the particular rock comes in contact with the rover. 

        defaultImage.SetActive(false); 
        for(int i = 0; i < rockList.Length; i++) {
            if (i == num) {
                rockList[i].SetActive(true); // only sets the rock with the index the same as the one in the parameter that is called by a specific rock. 
               
            }
        }
    }

    public void ResetImage() {
       
        for(int i = 0; i < rockList.Length; i++) {
            rockList[i].SetActive(false); // goes through the list setting them to false. 
        }
        defaultImage.SetActive(true); // Sets the main white screen to active again. 
    }
}

