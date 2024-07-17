using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHelp : MonoBehaviour
{
    private GameManagerScore gameManagerScore;
    private bool stop = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManagerScore = GameObject.Find("GameManagerScore").GetComponent<GameManagerScore>(); // finds the game object that holds the GameManagerScore script. 
        
    }

    private void OnMouseDown() {
        if (stop) {
            return;
        }
        gameManagerScore.UpdateScore(1); // if the mouse clicks on this particular rock, the score will add 1 to it, and then this method will not work anymore (boolean stop is permanently set to true).
        stop = true;

    } 
}