using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerManager : MonoBehaviour
{
    public Student studentObj;

    public void Update()
    {
        if (Input.GetKeyDown("space")) // THIS IS FOR TESTING ONLY. COMMENT THIS CONDITION WITH Ctrl+K+C AFTER TESTS.
        {
            StartYTP();
        }

        if (Input.GetKeyDown("s")) // THIS IS FOR TESTING ONLY. COMMENT THIS CONDITION WITH Ctrl+K+C AFTER TESTS.
        {
            StopYTP();
        }
    }

    public void StartYTP()
    {
        studentObj.ytPlayer.Play(studentObj.url);
    }

    public void StopYTP()
    {
        studentObj.ytPlayer.Stop();
    }

    public void SloopYTP()
    {
        //StopYTP(); // THIS IS NOT NEEDED APPARENTLY.
        StartYTP();
    }
}
