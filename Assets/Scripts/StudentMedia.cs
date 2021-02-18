using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMedia : MonoBehaviour
{
    public string studentName;
    //public GameObject illustration;
    //public GameObject description;

    //[Space]
    //[Header("If the presentation video is horizontal, uncheck 'isVertical'. If the pres. video is vertical, check 'isVertical':")]
    [Header("If the presentation video is horizontal,", order = 0)]
    [Space(-10, order = 1)]
    [Header("uncheck 'isVertical'. If the pres. video", order = 2)]
    [Space(-10, order = 3)]
    [Header("is vertical, check 'isVertical':", order = 4)]

    public bool isVertical;

    //[Space]
    //[Header("If the presentation video is horizontal, uncheck 'isVertical'. If the pres. video is vertical, check 'isVertical':")]
    [Header("These bools only work if the,", order = 0)]
    [Space(-10, order = 1)]
    [Header("video IS NOT VERTICAL.", order = 2)]
    [Space(-10, order = 3)]
    [Header("Also, if the presentation video has", order = 4)]
    [Space(-10, order = 5)]
    [Header("a ratio DIFFERENT FROM 16:9,", order = 6)]
    [Space(-10, order = 7)]
    [Header("only check the right bool:", order = 8)]
    public bool presentationIs1x1Square;
    public bool presentationIs4x3ShortRectangl;
    public bool presentationIs21x9LongRectangl;

    public YoutubePlayer horizontalMediaYtPlayer;
    public Transform horizontalVideoRenderArea;
    public YoutubePlayer verticalMediaYtPlayer;
    public string presentationUrl;
    public string artifactUrl;

    
}
