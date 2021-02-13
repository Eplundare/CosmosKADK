using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoutubeTrigger : MonoBehaviour
{
    public Student studentObj;

    //public void Update()
    //{
    //    if (Input.GetKeyDown("space"))
    //    {
    //        StartYTP();
    //    }
    //}

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Camera trigger has entered");

        StartYTP();
        studentObj.studentUi.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Camera trigger has exited");

        StopYTP();
        studentObj.studentUi.SetActive(false);

    }

    public void StartYTP()
    {
        studentObj.ytPlayer.Play(studentObj.url);
    }

    public void StopYTP()
    {
        studentObj.ytPlayer.Stop();
    }


}
