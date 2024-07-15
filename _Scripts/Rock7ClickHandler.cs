using UnityEngine;

public class Rock7ClickHandler : MonoBehaviour
{
    public GameObject popupPanel1; // Reference to the popup panel
    private bool isPopupOpen = false;

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
        popupPanel1.SetActive(true);
        isPopupOpen = true;
        // You can add additional logic here based on the specific rock prefab
    }

    void ClosePopup()
    {
        popupPanel1.SetActive(false);
        isPopupOpen = false;
    }
}
