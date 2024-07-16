using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHelp : MonoBehaviour
{
    public GameObject specialRock;
    // Start is called before the first frame update
    void Start()
    {
        //specialRock = GameObject.Find("rock 6(Clone)");
        transform.position = new Vector3(specialRock.transform.position.x, specialRock.transform.position.y, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
