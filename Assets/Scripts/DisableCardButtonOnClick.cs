using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCardButtonOnClick : MonoBehaviour
{
    public Button butt;
    public Image buttImage;

    public bool enablesOtherButt;
    public Button otherButt;
    public Image otherButtImage;

    // Start is called before the first frame update
    public void DisableButton()
    {
        if (Input.GetMouseButtonUp(0))
        {
            butt.interactable = false;
            buttImage.raycastTarget = false;

            if (enablesOtherButt == true)
            {
                otherButt.interactable = true;
                otherButtImage.raycastTarget = true;

            }
        }
    }

    public void EnableButton()
    {
        butt.interactable = true;
        buttImage.raycastTarget = true;

    }
}
