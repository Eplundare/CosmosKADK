using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentInfo : MonoBehaviour
{
    public string studentName;
    public GameObject illustration;
    //public GameObject description;

    //[Space]
    //[Header("Only if card illustration has animation, add a VideoPlayerManager component to this game object and fill these:")]
    [Header("Only if card illustration has animation,", order=0)]
    [Space(-10, order=1)]
    [Header("add a VideoPlayerManager component to this", order = 2)]
    [Space(-10, order=3)]
    [Header("game object and fill in these:", order = 4)]

    public bool cardHasAnimation;
    public YoutubePlayer cardYtPlayer;
    public string cardYoutubeUrl;
    //public string artifactUrl;
    //public YoutubePlayer artifYtPlayer;

}
