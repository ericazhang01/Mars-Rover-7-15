using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockexperiment : MonoBehaviour 
{
    public int rockNum; // each special rock has a different rockNum. 
    private ExperimentImage experimentButton; // Reference to the Experiment Image class. 


    void Start() {
        experimentButton = GameObject.Find("ExperimentImage").GetComponent<ExperimentImage>(); // finds the ExperimentImage gameobject that contains the Experiment Image + script.
    }
    private void OnTriggerEnter2D(Collider2D x) {

        
        experimentButton.ChangeImage(rockNum); // Changes the run experiment data. 
    }

    private void OnTriggerExit2D(Collider2D y) {
        experimentButton.ResetImage();
    }

    
}
