using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrowserManager : MonoBehaviour
{
    public GameObject browseNav;
    
    public bool btIsActive;
    public Image btArrowLeft;
    public Image btArrowDown;
    public GameObject[] studentsBt;

    public bool mrmIsActive;
    public Image mrmArrowLeft;
    public Image mrmArrowDown;
    public GameObject[] studentsMrm;

    public bool siIsActive;
    public Image siArrowLeft;
    public Image siArrowDown;
    public GameObject[] studentsSi;

    public bool vkIsActive;
    public Image vkArrowLeft;
    public Image vkArrowDown;
    public GameObject[] studentsVk;

    //public void Start()
    //{
    //    browseNav.SetActive(false);
    //}

    public void yActivateBrowser()
    {
        browseNav.SetActive(true);

        btIsActive = false;
        mrmIsActive = false;
        siIsActive = false;
        vkIsActive = false;
    }

    public void yDeactivateBrowser()
    {
        browseNav.SetActive(false);

        btIsActive = false;
        mrmIsActive = false;
        siIsActive = false;
        vkIsActive = false;
    }

    public void zToggleBt()
    {
        btIsActive = !btIsActive;

        if (btIsActive == true)
        {
            for (int i = 0; i < studentsBt.Length; i++)
            {
                studentsBt[i].SetActive(true);
            }
            btArrowDown.enabled = true;
            btArrowLeft.enabled = false;
        }

        else if (btIsActive == false)
        {
            for (int i = 0; i < studentsBt.Length; i++)
            {
                studentsBt[i].SetActive(false);
            }
            btArrowDown.enabled = false;
            btArrowLeft.enabled = true;

        }
    }

    public void zToggleMrm()
    {
        mrmIsActive = !mrmIsActive;

        if (mrmIsActive == true)
        {
            for (int i = 0; i < studentsMrm.Length; i++)
            {
                studentsMrm[i].SetActive(true);
            }
            mrmArrowDown.enabled = true;
            mrmArrowLeft.enabled = false;
        }

        else if (mrmIsActive == false)
        {
            for (int i = 0; i < studentsMrm.Length; i++)
            {
                studentsMrm[i].SetActive(false);
            }
            mrmArrowDown.enabled = false;
            mrmArrowLeft.enabled = true;
        }
    }

    public void zToggleSi()
    {
        siIsActive = !siIsActive;

        if (siIsActive == true)
        {
            for (int i = 0; i < studentsSi.Length; i++)
            {
                studentsSi[i].SetActive(true);
            }
            siArrowDown.enabled = true;
            siArrowLeft.enabled = false;
        }

        else if (siIsActive == false)
        {
            for (int i = 0; i < studentsSi.Length; i++)
            {
                studentsSi[i].SetActive(false);
            }
            siArrowDown.enabled = false;
            siArrowLeft.enabled = true;
        }
    }

    public void zToggleVk()
    {
        vkIsActive = !vkIsActive;

        if (vkIsActive == true)
        {
            for (int i = 0; i < studentsVk.Length; i++)
            {
                studentsVk[i].SetActive(true);
            }
            vkArrowDown.enabled = true;
            vkArrowLeft.enabled = false;
        }

        else if (vkIsActive == false)
        {
            for (int i = 0; i < studentsVk.Length; i++)
            {
                studentsVk[i].SetActive(false);
            }
            vkArrowDown.enabled = false;
            vkArrowLeft.enabled = true;
        }
    }

}
