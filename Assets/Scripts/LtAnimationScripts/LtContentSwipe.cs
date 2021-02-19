using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtContentSwipe : MonoBehaviour
{
    public string VideoOrDescription;
    public VideoPlayerManager vidPlayerManager; // REMOVE?

    //public StudentInfo studInfo;
    //public bool thereIsCardVid;
    public VideoPlayerManager cardVidManager;

    [Space]
    [Header("Content PARENT and Position pivots here:")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject contentPrnt;
    public Transform pos0; // This will be out of camera.
    public Transform pos1; // This will be in camera.

    [Space]
    [Header("Ignore these. Script manages them in Start.")]
    // This vectors are assigned on Start.
    public Vector3 v0;
    public Vector3 v1;

    public string Description;
    //public VideoPlayerManager vidPlayerManager; // REMOVE?

    [Space]
    [Header("Content PARENT and Position pivots here:")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject descrContentPrnt;
    public Transform descrPos0; // This will be out of camera.
    public Transform descrPos1; // This will be in camera.

    [Space]
    [Header("Ignore these. Script manages them in Start.")]
    // This vectors are assigned on Start.
    public Vector3 descrV0;
    public Vector3 descrV1;


    [Space]
    [Header("Animation time:")]
    // These establish how much time animations take.
    public float timeAnim;

    [Space]
    [Header("Delay for animations:")]
    // These delay the animation from starting.
    public float delayTid;

    public AnimationCurve animCurve;

    public void Start()
    {
        v0 = new Vector3(pos0.position.x, pos0.position.y, pos0.position.z);
        v1 = new Vector3(pos1.position.x, pos1.position.y, pos1.position.z);

        descrV0 = new Vector3(descrPos0.position.x, descrPos0.position.y, descrPos0.position.z);
        descrV1 = new Vector3(descrPos1.position.x, descrPos1.position.y, descrPos1.position.z);
    }

    //public void Update()
    //{
    //    if (Input.GetKeyDown("c"))
    //    {
    //        ZSwipeIn();
    //    }
    //}

    public void ZSwipeIn()
    {
        LeanTween.move(contentPrnt, v1, timeAnim).setDelay(delayTid).setEase(animCurve);
        LeanTween.move(descrContentPrnt, descrV1, timeAnim).setDelay(delayTid).setEase(animCurve);

        vidPlayerManager.StartPresentation();

        if (cardVidManager != null)
        {
            cardVidManager.StartCardVideo();
        }

        //if (studInfo.cardHasAnimation == true)
        //{
        //    cardVidManager.StartCardVideo();
        //}

        //CardEventsManager.OnClicked += vidPlayerManager.StopCardVideo;
        //CardEventsManager.OnClicked += vidPlayerManager.StopCardVideo;

    }

    public void ZSwipeOut()
    {
        LeanTween.move(contentPrnt, v0, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);
        LeanTween.move(descrContentPrnt, descrV0, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);

        vidPlayerManager.StopPresOrArtifact();


        if (cardVidManager != null)
        {
            cardVidManager.StopCardVideo();
        }

    }
}
