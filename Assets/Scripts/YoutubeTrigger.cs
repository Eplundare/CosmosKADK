using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoutubeTrigger : MonoBehaviour
{
    public Student studentObj;

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartYTP();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Camera trigger has entered");

        StartYTP();
    }

    public void OnTriggerExit(Collider other)
    {
        StopYTP();

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
