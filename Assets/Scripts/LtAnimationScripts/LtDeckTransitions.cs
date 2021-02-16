using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtDeckTransitions : MonoBehaviour
{
    [Space]
    [Header("Objects and transforms")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject deck;
    public Transform trans0; // Universe idle down
    public Transform trans1; // Universe idle up
    public Transform trans2; // Start for transition to Departments
    public GameObject viskomDeck;
    public Transform viskomTrans1;
    public GameObject fashionDeck;
    public Transform fashionTrans1;
    public GameObject gameDeck;
    public Transform gameTrans1;
    public GameObject rumDeck;
    public Transform rumTrans1;

    [Space]
    [Header("Hidden Vectors")]
    // This vectors are assigned on Start.
    private Vector3 pos0;
    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 viskomPos1;
    private Vector3 fashionPos1;
    private Vector3 gamePos1;
    private Vector3 rumPos1;

    private Vector3 rot0;
    private Vector3 rot1;
    private Vector3 rot2;
    private Vector3 viskomRot1;
    private Vector3 fashionRot1;
    private Vector3 gameRot1;
    private Vector3 rumRot1;

    [Space]
    [Header("Animation times")]
    // These establish how much time animations take.
    public float timeAnim1;
    public float timeAnim2;
    public float timeAnim3UnivTransit;

    [Space]
    [Header("Animation loops")]
    // These establish how much time animations take.
    public int loopAnim1;

    [Space]
    [Header("Delay for animations")]
    // These delay the animation from starting.
    public float delayTid;
    public float delayTidUniverseTransit;

    public AnimationCurve animCurve;

    public void Start() // Starting Universe idle animation.
    {
        pos0 = new Vector3(trans0.localPosition.x, trans0.localPosition.y, trans0.localPosition.z);
        rot0 = new Vector3(trans0.localEulerAngles.x, trans0.localEulerAngles.y, trans0.localEulerAngles.z);

        pos1 = new Vector3(trans1.localPosition.x, trans1.localPosition.y, trans1.localPosition.z);
        rot1 = new Vector3(trans1.localEulerAngles.x, trans1.localEulerAngles.y, trans1.localEulerAngles.z);

        pos2 = new Vector3(trans2.localPosition.x, trans2.localPosition.y, trans2.localPosition.z);
        rot2 = new Vector3(trans2.localEulerAngles.x, trans2.localEulerAngles.y, trans2.localEulerAngles.z);

        viskomPos1 = new Vector3(viskomTrans1.localPosition.x, viskomTrans1.localPosition.y, viskomTrans1.localPosition.z);
        viskomRot1 = new Vector3(viskomTrans1.localEulerAngles.x, viskomTrans1.localEulerAngles.y, viskomTrans1.localEulerAngles.z);

        fashionPos1 = new Vector3(fashionTrans1.localPosition.x, fashionTrans1.localPosition.y, fashionTrans1.localPosition.z);
        fashionRot1 = new Vector3(fashionTrans1.localEulerAngles.x, fashionTrans1.localEulerAngles.y, fashionTrans1.localEulerAngles.z);

        gamePos1 = new Vector3(gameTrans1.localPosition.x, gameTrans1.localPosition.y, gameTrans1.localPosition.z);
        gameRot1 = new Vector3(gameTrans1.localEulerAngles.x, gameTrans1.localEulerAngles.y, gameTrans1.localEulerAngles.z);

        rumPos1 = new Vector3(rumTrans1.localPosition.x, rumTrans1.localPosition.y, rumTrans1.localPosition.z);
        rumRot1 = new Vector3(rumTrans1.localEulerAngles.x, rumTrans1.localEulerAngles.y, rumTrans1.localEulerAngles.z);

        LeanTween.rotateLocal(deck, rot0, 0f);
        LeanTween.moveLocal(deck, pos0, 0f);

        LeanTween.moveLocal(deck, pos1, timeAnim1).setDelay(delayTid).setEase(animCurve).setLoopPingPong(/*loopAnim1*/);

    }

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            TransitDepartments();
        }
    }

    public void TransitDepartments()
    {
        //int cancelId = LeanTween.move(deck, pos1, timeAnim1).setDelay(delayTid).setEase(animCurve).setLoopPingPong(-1).id;
        LeanTween.rotateLocal(deck, rot2, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(deck, pos2, timeAnim2).setEase(animCurve);

        LeanTween.rotateLocal(viskomDeck, viskomRot1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);
        LeanTween.moveLocal(viskomDeck, viskomPos1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);

        LeanTween.rotateLocal(fashionDeck, fashionRot1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);
        LeanTween.moveLocal(fashionDeck, fashionPos1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);

        LeanTween.rotateLocal(gameDeck, gameRot1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);
        LeanTween.moveLocal(gameDeck, gamePos1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);

        LeanTween.rotateLocal(rumDeck, rumRot1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);
        LeanTween.moveLocal(rumDeck, rumPos1, timeAnim3UnivTransit).setDelay(delayTidUniverseTransit).setEase(animCurve);
    }

    //public void ZSwipeOut()
    //{
    //    LeanTween.move(contentPrnt, v0, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);
    //}
}
