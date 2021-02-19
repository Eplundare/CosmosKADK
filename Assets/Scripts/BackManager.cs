using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackManager : MonoBehaviour
{
    public GameObject homeBack;

    public GameObject depBackfVk;
    public GameObject depBackfBt;
    public GameObject depBackfSi;
    public GameObject depBackfMrm;

    public GameObject vkBack;
    public GameObject btBack;
    public GameObject siBack;
    public GameObject mrmBack;

    public void TurnOffBack() // WHEN YOU RETURN TO START
    {
        homeBack.SetActive(false);
    }

    public void TurnOnHomeBack() // WHEN YOU ARE IN SEPARATE DEPS, WHEN YOU WANT TO EXIT SPREADS
    {
        homeBack.SetActive(true);
        
        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        vkBack.SetActive(false);
        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);


    }

    public void TurnOnDepBackFVk() //WHEN YOU EXIT INDIVIDUAL CARDS.
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(true);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        vkBack.SetActive(false);
        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);

    }

    public void TurnOnDepBackFBt() //WHEN YOU EXIT INDIVIDUAL CARDS.
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(true);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        vkBack.SetActive(false);
        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);

    }

    public void TurnOnDepBackFSi() //WHEN YOU EXIT INDIVIDUAL CARDS.
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(true);
        depBackfMrm.SetActive(false);

        vkBack.SetActive(false);
        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);

    }
    public void TurnOnDepBackFMrm() //WHEN YOU EXIT INDIVIDUAL CARDS.
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(true);

        vkBack.SetActive(false);
        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);

    }

    public void TurnOnBackVK()
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        btBack.SetActive(false);
        siBack.SetActive(false);
        mrmBack.SetActive(false);
        vkBack.SetActive(true);

    }

    public void TurnOnBackBt()
    {

        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        siBack.SetActive(false);
        mrmBack.SetActive(false);
        vkBack.SetActive(false);
        btBack.SetActive(true);

    }

    public void TurnOnBackSi()
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        btBack.SetActive(false);
        mrmBack.SetActive(false);
        vkBack.SetActive(false);
        siBack.SetActive(true);

    }

    public void TurnOnBackMrm()
    {
        homeBack.SetActive(false);

        depBackfVk.SetActive(false);
        depBackfBt.SetActive(false);
        depBackfSi.SetActive(false);
        depBackfMrm.SetActive(false);

        btBack.SetActive(false);
        siBack.SetActive(false);
        vkBack.SetActive(false);
        mrmBack.SetActive(true);

    }

}
