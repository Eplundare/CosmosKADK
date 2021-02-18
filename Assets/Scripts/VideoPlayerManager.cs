using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoPlayerManager : MonoBehaviour
{
    public StudentInfo studInfo;
    public StudentMedia studMedia;

    private bool nextVideoIsArtifact;

    private Vector3 presRendOriginalScale;
    private Vector3 presRendHorizScale1x1;
    private Vector3 presRendHorizScale4x3;
    private Vector3 presRendHorizScale21x9;

    public void Start()
    {
        presRendOriginalScale = new Vector3(4.34f, 3.108173e-07f, 3.75f);
        presRendHorizScale1x1 = new Vector3(2.2f, 3.108173e-07f, 3.75f);
        presRendHorizScale4x3 = new Vector3(2.92f, 3.108173e-07f, 3.75f);
        presRendHorizScale21x9 = new Vector3(4.34f, 3.108173e-07f, 3.06f);

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
        if (studMedia.isVertical == false) // ONLY HERE WE CAN PLAY DIFFERENT RATIO PRESENTATION VIDEOS.
        {
            //studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
            if (studMedia.presentationIs1x1Square == false 
                && studMedia.presentationIs4x3ShortRectangl == false 
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
            }

            else if (studMedia.presentationIs1x1Square == true
                && studMedia.presentationIs4x3ShortRectangl == false
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendHorizScale1x1;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
            }

            else if (studMedia.presentationIs1x1Square == false
                && studMedia.presentationIs4x3ShortRectangl == true
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendHorizScale4x3;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
            }

            else if (studMedia.presentationIs1x1Square == false
               && studMedia.presentationIs4x3ShortRectangl == false
               && studMedia.presentationIs21x9LongRectangl == true)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendHorizScale21x9;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.presentationUrl);
            }
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
        if (studMedia.isVertical == false) // HERE WE ARE READJUSTING ASPECT RATIO, IF THE PRES. VIDEO HAD A DIFFERENT RATIO.
        {
            //studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);

            if (studMedia.presentationIs1x1Square == false
                && studMedia.presentationIs4x3ShortRectangl == false
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);
            }

            else if (studMedia.presentationIs1x1Square == true
                && studMedia.presentationIs4x3ShortRectangl == false
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendOriginalScale;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);
            }

            else if (studMedia.presentationIs1x1Square == false
                && studMedia.presentationIs4x3ShortRectangl == true
                && studMedia.presentationIs21x9LongRectangl == false)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendOriginalScale;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);
            }

            else if (studMedia.presentationIs1x1Square == false
               && studMedia.presentationIs4x3ShortRectangl == false
               && studMedia.presentationIs21x9LongRectangl == true)
            {
                studMedia.horizontalVideoRenderArea.localScale = presRendOriginalScale;
                studMedia.horizontalMediaYtPlayer.Play(studMedia.artifactUrl);
            }
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
