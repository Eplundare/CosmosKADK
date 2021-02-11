using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtCardElement : MonoBehaviour
{
    [Space]
    [Header("Card graphics and position objects here:")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject objPrimary;
    public Transform posPrim0;
    public Transform posPrim1;
    public GameObject objSecondary;
    public Transform posSecond0;
    public Transform posSecond1;

    [Space]
    [Header("Put Animators here:")]
    public Animator primAnimator;
    public Animator secondAnimator;

    [Space]
    [Header("Ignore these. Script manages them in Start.")]
    // This vectors are assigned on Start.
    public Vector3 primV0;
    public Vector3 primV1;
    public Vector3 secondV0;
    public Vector3 secondV1;

    [Space]
    [Header("Animation time:")]
    // These establish how much time animations take.
    public float timeAnim;

    [Space]
    [Header("Delay for animations:")]
    // These delay the animation from starting.
    public float delayTidPrim;
    public float delayTidSecond;

    public AnimationCurve animCurve;

    public void Start()
    {
        primV0 = new Vector3 (posPrim0.position.x, posPrim0.position.y, posPrim0.position.z);
        primV1 = new Vector3(posPrim1.position.x, posPrim1.position.y, posPrim1.position.z);
        secondV0 = new Vector3(posSecond0.position.x, posSecond0.position.y, posSecond0.position.z);
        secondV1 = new Vector3(posSecond1.position.x, posSecond1.position.y, posSecond1.position.z);

    }

    public void ZPushPrimary()
    {
        LeanTween.move(objPrimary, primV1, timeAnim).setDelay(delayTidPrim).setEase(animCurve);
    }

    public void ZPullPrimary()
    {
        LeanTween.move(objPrimary, primV0, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);
    }

    public void ZPushSecondary()
    {
        LeanTween.move(objSecondary, secondV1, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);
    }

    public void ZPullSecondary()
    {
        LeanTween.move(objSecondary, secondV0, timeAnim).setDelay(delayTidSecond).setEase(animCurve);
    }

}
