using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalBallTextManager : MonoBehaviour
{
    public Image sogTxt;
    public Image hjemTxt;
    public Image tilbageTxt;
    public Image cardsButtonImage;

    public void TurnOnSog()
    {
        sogTxt.enabled = true;
        //cardsButtonImage.enabled = false;
        var tempColor = cardsButtonImage.color;
        tempColor.a = 0f;
        cardsButtonImage.color = tempColor;
    }

    public void TurnOnHjem()
    {
        hjemTxt.enabled = true;
        cardsButtonImage.enabled = false;
    }

    public void TurnOnTilbage()
    {
        tilbageTxt.enabled = true;
        cardsButtonImage.enabled = false;
    }

    public void TurnOnCardsButtonImage()
    {
        cardsButtonImage.enabled = true;
        var tempColor = cardsButtonImage.color;
        tempColor.a = 255f;
        cardsButtonImage.color = tempColor;

        tilbageTxt.enabled = false;
        hjemTxt.enabled = false;
        sogTxt.enabled = false;
    }

    public void TurnOffTilbage()
    {
        tilbageTxt.enabled = false;
    }

}
