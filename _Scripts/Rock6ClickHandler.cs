using UnityEngine;

public class Rock6ClickHandler : MonoBehaviour
{
    public GameObject popupPanel; // Reference to the popup panel
    private bool isPopupOpen = false;
    private PopUpCycle cycler;
    

    void Start()
    {
        ClosePopup();
    }

    void OnMouseDown()
    {
        if (isPopupOpen)
        {
            ClosePopup();
        }
        else
        {
            OpenPopup();
        }
    }

    void OpenPopup()
    {
        popupPanel.SetActive(true);
        isPopupOpen = true;
        //popupPanel.GetComponent<Image>().color.a = 1.00f;
        //cycler.ShowPopup(0);
        // You can add additional logic here based on the specific rock prefab
    }

    void ClosePopup()
    {
        popupPanel.SetActive(false);
        //cycler.HidePopup(0);
        isPopupOpen = false;
    }
}
