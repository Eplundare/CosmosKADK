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
            StartPresentation();
        }

        if (Input.GetKeyDown("s")) // THIS IS FOR TESTING ONLY. COMMENT THIS CONDITION WITH Ctrl+K+C AFTER TESTS.
        {
            StopPresentation();
        }
    }

    // METHODS FOR PRESENTATION PLAYBACK
    public void StartPresentation()
    {
        studentObj.presYtPlayer.Play(studentObj.presentationUrl);
    }

    public void StopPresentation()
    {
        studentObj.presYtPlayer.Stop();
    }

    public void SloopPresentation()
    {
        StartPresentation();
    }

    //METHODS FOR ARTIFACT PLAYBACK
    public void StartArtifact()
    {
        studentObj.artifYtPlayer.Play(studentObj.artifactUrl);
    }

    public void StopArtifact()
    {
        studentObj.artifYtPlayer.Stop();
    }

    public void SloopArtifact()
    {
        StartArtifact();
    }

}
