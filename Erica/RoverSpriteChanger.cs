using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverSpriteChanger : MonoBehaviour
{

    // This is the script being used in the scene "The real 1", to change the color of the rover to the one set in the customization scene. 

    public Sprite[] roverSprites; // an array carrying all the different rover color options. 
    public GameObject rover1; // the main character rover that is being changed. 
   
    void Start()
    {
        int selectedSprite = PlayerPrefs.GetInt("selectedCharacter"); // this is the int set in the script "ChracterSelection".
        rover1.GetComponent<SpriteRenderer>().sprite = roverSprites[selectedSprite]; // Changes the sprite component on the rover to the designated one found in the roverSprites array. 
    }

    
}
