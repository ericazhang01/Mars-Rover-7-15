using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpCycle : MonoBehaviour
{
    public GameObject[] popupArray;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < popupArray.Length; i++) {
            popupArray[i].SetActive(false);
        }
    }

    public void ShowPopup(int x) {
        popupArray[x].SetActive(true);
        Debug.Log("Accessed ShowPopup method");

    }

    public void HidePopup(int x) {
        popupArray[x].SetActive(false);
        Debug.Log("Accessed HidePopup method");
    }
}
