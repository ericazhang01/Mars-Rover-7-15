using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScore : MonoBehaviour
{

    public TextMeshProUGUI mainText; // text found in Menu Button/PopUpMenu2/View Objectives/ObjectivePopUp/ScoreText.
    public int score = 0; 
   

    void Start() {
        mainText.text = "Rocks Found: " + score + "/8"; // Sets the text to Rocks Found: 0/6
    }
    public void UpdateScore(int s) {
        score += s; 
        mainText.text = "Rocks Found: " + score + "/8"; // changes the score.
    }

}


