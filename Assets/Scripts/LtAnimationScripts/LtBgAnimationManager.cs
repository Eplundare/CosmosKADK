using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtBgAnimationManager : MonoBehaviour
{
    [Space]
    [Header("Objects and transforms")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject bgObj;
    public Transform bgTrans0; // Start idle position
    public Transform bgTrans1; // Stop idle position

    public GameObject nightObj;
    public Transform nightTrans0; //Start position of stars
    public Transform nightTrans1; //Dep1 rot
    public Transform nightTrans2; //Dep2 rot...
    public Transform nightTrans3;
    public Transform nightTrans4;

    [Space]
    [Header("Hidden Vectors")]
    // This vectors are assigned on Start.

    private Vector3 rotBg0;
    private Vector3 rotBg1;
    private Vector3 rotNight0;
    private Vector3 rotNight1;
    private Vector3 rotNight2;
    private Vector3 rotNight3;
    private Vector3 rotNight4;

    [Space]
    [Header("Animation times")]
    // These establish how much time animations take.
    public float timeBg;
    public float timeNights;

    //[Space]
    //[Header("Animation loops")]
    //// These establish how much time animations take.
    //public int loopAnim1;

    [Space]
    [Header("Delay for animations")]
    // These delay the animation from starting.
    public float delayBg;
    public float delayNights;

    public AnimationCurve animCurve;

    public void Start() // Starting Universe idle animation.
    {
        // Sets vectors for background rotations.
        rotBg0 = new Vector3(bgTrans0.localEulerAngles.x, bgTrans0.localEulerAngles.y, bgTrans0.localEulerAngles.z);
        rotBg1 = new Vector3(bgTrans1.localEulerAngles.x, bgTrans1.localEulerAngles.y, bgTrans1.localEulerAngles.z);

        // Sets vectors for nights rotations.
        rotNight0 = new Vector3(nightTrans0.localEulerAngles.x, nightTrans0.localEulerAngles.y, nightTrans0.localEulerAngles.z);
        rotNight1 = new Vector3(nightTrans1.localEulerAngles.x, nightTrans1.localEulerAngles.y, nightTrans1.localEulerAngles.z);
        rotNight2 = new Vector3(nightTrans2.localEulerAngles.x, nightTrans2.localEulerAngles.y, nightTrans2.localEulerAngles.z);
        rotNight3 = new Vector3(nightTrans3.localEulerAngles.x, nightTrans3.localEulerAngles.y, nightTrans3.localEulerAngles.z);
        rotNight4 = new Vector3(nightTrans4.localEulerAngles.x, nightTrans4.localEulerAngles.y, nightTrans4.localEulerAngles.z);

        // Starts slightly rotating bg.
        LeanTween.rotateLocal(bgObj, rotBg1, timeBg).setDelay(delayBg).setEase(animCurve).setLoopPingPong(/*loopAnim1*/);

    }

    public void Update()
    {
        // These are just for testing purposes.
        if (Input.GetKeyDown("6"))
        {
            RotateNightToOrigin();
        }
        else if (Input.GetKeyDown("7"))
        {
            RotateNightToDep1();
        }
        else if (Input.GetKeyDown("8"))
        {
            RotateNightToDep2();
        }
        else if (Input.GetKeyDown("9"))
        {
            RotateNightToDep3();
        }
        else if (Input.GetKeyDown("0"))
        {
            RotateNightToDep4();
        }
    }

    public void RotateNightToOrigin()
    {
        LeanTween.rotateLocal(nightObj, rotNight0, timeBg).setDelay(delayNights).setEase(animCurve);

    }

    public void RotateNightToDep1()
    {
        LeanTween.rotateLocal(nightObj, rotNight1, timeBg).setDelay(delayNights).setEase(animCurve);

    }

    public void RotateNightToDep2()
    {
        LeanTween.rotateLocal(nightObj, rotNight2, timeBg).setDelay(delayNights).setEase(animCurve);

    }

    public void RotateNightToDep3()
    {
        LeanTween.rotateLocal(nightObj, rotNight3, timeBg).setDelay(delayNights).setEase(animCurve);

    }

    public void RotateNightToDep4()
    {
        LeanTween.rotateLocal(nightObj, rotNight4, timeBg).setDelay(delayNights).setEase(animCurve);

    }
}
