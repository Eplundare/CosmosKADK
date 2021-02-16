using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerManager : MonoBehaviour
{
    public StudentInfo studInfo;
    public StudentMedia studMedia;

    private bool nextVideoIsArtifact;

    public void Start()
    {
        nextVideoIsArtifact = true;
    }

    //public void Update()
    //{
    //    if (Input.GetKeyDown("space")) // THIS IS FOR TESTING ONLY. COMMENT THIS CONDITION WITH Ctrl+K+C AFTER TESTS.
    //    {
    //        StartPresentation();
    //    }

    //    if (Input.GetKeyDown("s")) // THIS IS FOR TESTING ONLY. COMMENT THIS CONDITION WITH Ctrl+K+C AFTER TESTS.
    //    {
    //        StopPresOrArtifact();
    //    }
    //}

    // METHODS FOR sCARD PLAYBACK

    public void StartCardVideo()
    {
        studInfo.cardYtPlayer.Play(studInfo.cardYoutubeUrl);
    }

    public void StopCardVideo()
    {
        studInfo.cardYtPlayer.Stop();
    }

    public void SloopCardVideo()
    {

        StartCardVideo();
    }

    // METHODS FOR PRESENTATION PLAYBACK
    public void StartPresentation()
    {
        if (studMedia.isVertical == false)
        {
            studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
        }

        else if (studMedia.isVertical == true)
        {
            studMedia.verticalMediaYtPlayer.Play(studMedia.presentationUrl);
            //studMedia.testYtSimp.autoPlay(studMedia.presentationUrl);
        }
    }

    public void StopPresOrArtifact()
    {
        if (studMedia.isVertical == false)
        {
            studMedia.horizontalMediaYtPlayer.Stop();
        }

        else if (studMedia.isVertical == true)
        {
            studMedia.verticalMediaYtPlayer.Stop();
        }
        
    }

    public void SloopPresOrArtifact()
    {
        if (nextVideoIsArtifact == true)
        {
            StartArtifact();
            nextVideoIsArtifact = false;
        }
        else if (nextVideoIsArtifact == false)
        {
            StartPresentation();
            nextVideoIsArtifact = true;
        }
    }

    //METHODS FOR ARTIFACT PLAYBACK
    public void StartArtifact()
    {
        if (studMedia.isVertical == false)
        {
            studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);
        }

        else if (studMedia.isVertical == true)
        {
            studMedia.verticalMediaYtPlayer.Play(studMedia.artifactUrl);
        }
        
    }

    //public void StopArtifact()
    //{
    //    studentMedia.mediaYtPlayer.Stop();
    //}



}
