using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject cam00;
    public GameObject cam01;
    public GameObject cam02;
    public GameObject cam03;
    public GameObject cam04;
    public GameObject cam05;
    public GameObject cam06;
    public GameObject cam07;
    public GameObject cam08;
    public GameObject cam09;
    public GameObject cam10;

    public void CamOn00()
    {
        cam00.SetActive(true);
        cam01.SetActive(false);
        //cam02.SetActive(false);
        //cam03.SetActive(false);
        //cam04.SetActive(false);
        //cam05.SetActive(false);
        //cam06.SetActive(false);
        //cam07.SetActive(false);
        //cam08.SetActive(false);
        //cam09.SetActive(false);
        //cam10.SetActive(false);

    }

    public void CamOn01()
    {
        cam00.SetActive(false);
        cam01.SetActive(true);
        //cam02.SetActive(false);
        //cam03.SetActive(false);
        //cam04.SetActive(false);
        //cam05.SetActive(false);
        //cam06.SetActive(false);
        //cam07.SetActive(false);
        //cam08.SetActive(false);
        //cam09.SetActive(false);
        //cam10.SetActive(false);
    }

}
