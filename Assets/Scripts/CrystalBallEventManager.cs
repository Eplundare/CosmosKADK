using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CrystalBallEventManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Space]
    [Header("This Component should only go on UI images")]

    public CrystalBallTextManager CBallTxtManager;

    public bool isSog;
    public bool isHjem;
    public bool isTilbage;


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isSog == true)
        {
            CBallTxtManager.TurnOnSog();

        }
        else if (isHjem == true)
        {
            CBallTxtManager.TurnOnHjem();

        }
        else if (isTilbage == true)
        {
            CBallTxtManager.TurnOnTilbage();

        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CBallTxtManager.TurnOnCardsButtonImage();

    }

}
