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
    public YoutubePlayer horizontalMediaYtPlayer;
    public YoutubePlayer verticalMediaYtPlayer;
    public string presentationUrl;
    public string artifactUrl;

    
}
