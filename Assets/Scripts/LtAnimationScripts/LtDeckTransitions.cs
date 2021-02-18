using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtDeckTransitions : MonoBehaviour
{
    [Space]
    [Header("Global deck object and transforms")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject deck;
    public Transform trans0; // Universe idle down. RP
    public Transform trans1; // Universe idle up. RP
    public Transform trans2; // Start for transition to Departments. RP

    /// <summary>
    /// ///////////////////////////////////////////////////////////////
    /// </summary>

    [Space]
    [Header("VK deck objects and transforms")]
    public GameObject viskomDeck;
    public Transform vkOriginTrans0; // origin. chosen. RP
    public Transform vkDepsTrans1; // department separated. RP
    public Transform vkUnchosTrans2; // unchosen, flies away. P

    [Space]
    [Header("BT deck objects and transforms")]
    public GameObject btDeck;
    public Transform btOriginTrans0; // origin. chosen. RP
    public Transform btDepsTrans1; // department separated. RP
    public Transform btUnchosTrans2; // unchosen, flies away. P

    [Space]
    [Header("SI deck objects and transforms")]
    public GameObject siDeck;
    public Transform siOriginTrans0; // origin. chosen. RP
    public Transform siDepsTrans1; // department separated. RP
    public Transform siUnchosTrans2; // unchosen, flies away. P

    [Space]
    [Header("MRM deck objects and transforms")]
    public GameObject mrmDeck;
    public Transform mrmOriginTrans0; // origin. chosen. RP
    public Transform mrmDepsTrans1; // department separated. RP
    public Transform mrmUnchosTrans2; // unchosen, flies away. P

    /// <summary>
    /// //////////////////////////////////////////////////////////
    /// </summary>

    [Space]
    [Header("VK cards objects and transforms")]
    public GameObject[] vkCards;
    public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
    public Transform[] vkCardsSpreadTrans1; // spread. P
    public Transform[] vkCardsFlipTrans2; // flip. R
    public Transform[] vkCardsAwayTrans3; // fly below. P
    public Transform vkCardWithMediaTrans4; // position to share screen with media. P

    [Space]
    [Header("BT cards objects and transforms")]
    public GameObject[] btCards;
    public Transform[] btCardsOriginTrans0; // origin and chosen card. P
    public Transform[] btCardsSpreadTrans1; // spread. P
    public Transform[] btCardsFlipTrans2; // flip. R
    public Transform[] btCardsAwayTrans3; // fly below. P
    public Transform btCardWithMediaTrans4; // position to share screen with media. P

    [Space]
    [Header("SI cards objects and transforms")]
    public GameObject[] siCards;
    public Transform[] siCardsOriginTrans0; // origin and chosen card. P
    public Transform[] siCardsSpreadTrans1; // spread. P
    public Transform[] siCardsFlipTrans2; // flip. R
    public Transform[] siCardsAwayTrans3; // fly below. P
    public Transform siCardWithMediaTrans4; // position to share screen with media. P

    [Space]
    [Header("MRM cards objects and transforms")]
    public GameObject[] mrmCards;
    public Transform[] mrmCardsOriginTrans0; // origin and chosen card. P
    public Transform[] mrmCardsSpreadTrans1; // spread. P
    public Transform[] mrmCardsFlipTrans2; // flip. R
    public Transform[] mrmCardsAwayTrans3; // fly below. P
    public Transform mrmCardWithMediaTrans4; // position to share screen with media. P

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    [Space]
    [Header("Hidden Vectors")]
    // These vectors are assigned on Start.

    // Global deck vectors. /////////////////////////////////////////////////////////////////////
    private Vector3 pos0;
    private Vector3 pos1;
    private Vector3 pos2;

    private Vector3 rot0;
    private Vector3 rot1;
    private Vector3 rot2;

    // VK deck vectors. /////////////////////////////////////////////////////////////////////////
    //public Transform vkOriginTrans0; // origin. chosen. RP
    //public Transform vkDepsTrans1; // department separated. RP
    //public Transform vkUnchosTrans2; // unchosen, flies away. P
    private Vector3 vkoPos0;
    private Vector3 vkdPos1;
    private Vector3 vkuPos2;

    private Vector3 vkoRot0;
    private Vector3 vkdRot1;
    //private Vector3 vkuRot2;

    // BT deck vectors.
    private Vector3 btoPos0;
    private Vector3 btdPos1;
    private Vector3 btuPos2;

    private Vector3 btoRot0;
    private Vector3 btdRot1;

    // SI deck vectors.
    private Vector3 sioPos0;
    private Vector3 sidPos1;
    private Vector3 siuPos2;

    private Vector3 sioRot0;
    private Vector3 sidRot1;

    // MRM deck vectors.
    private Vector3 mrmoPos0;
    private Vector3 mrmdPos1;
    private Vector3 mrmuPos2;

    private Vector3 mrmoRot0;
    private Vector3 mrmdRot1;

    // VK card vectors. ////////////////////////////////////////////////////////////
    //public GameObject[] vkCards;
    //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
    //public Transform[] vkCardsSpreadTrans1; // spread. P
    //public Transform[] vkCardsFlipTrans2; // flip. R
    //public Transform[] vkCardsAwayTrans3; // fly below. P
    //public Transform vkCardWithMediaTrans4; // position to share screen with media. P
    private Vector3[] vkcoPos0;
    private Vector3[] vkcsPos1;
    private Vector3[] vkcfRot2;
    private Vector3[] vkcaPos3;
    private Vector3 vkcwmPos4;

    // BT card vectors.
    private Vector3[] btcoPos0;
    private Vector3[] btcsPos1;
    private Vector3[] btcfRot2;
    private Vector3[] btcaPos3;
    private Vector3 btcwmPos4;

    // SI card vectors.
    private Vector3[] sicoPos0;
    private Vector3[] sicsPos1;
    private Vector3[] sicfRot2;
    private Vector3[] sicaPos3;
    private Vector3 sicwmPos4;

    // MRM card vectors.
    private Vector3[] mrmcoPos0;
    private Vector3[] mrmcsPos1;
    private Vector3[] mrmcfRot2;
    private Vector3[] mrmcaPos3;
    private Vector3 mrmcwmPos4;

    [Space]
    [Header("Animation times")]
    // These establish how much time animations take.
    public float timeAnim1; // FOR IDLE OF GLOBAL DECK.
    public float timeAnim2; // FOR THE REST OF ANIMATIONS (for now).
    //public float timeAnim3UnivTransit;

    [Space]
    [Header("Animation loops")]
    // These establish how much time animations take.
    public int loopAnim1;

    [Space]
    [Header("Delay for animations")]
    // These delay the animation from starting.
    public float delayTid; // MARKER 1. START
    public float delBeforeGlobalSpread; // Deps Norm, 0 chosen - 1 deps
    public float delWhileUnchosenDecksFlyAway; // MARKER 2. Deps Norm, 2 unchosen fly away
    public float delWhileCardsSpread; // Deps Norm, 0 chosen dep - Inside Dep norm Cards, pos0 - pos1 spread
    public float delBeforeFlip; // MARKER 3.
    public float delBeforeSpreadGoesAway;
    public float delBeforeSelectedCardAndMediaGetInPlace; // MARKER 4.

    public AnimationCurve animCurve;

    public void Start() // Starting Universe idle animation.
    {
        // Record vectors of Global deck.

        pos0 = new Vector3(trans0.localPosition.x, trans0.localPosition.y, trans0.localPosition.z);
        rot0 = new Vector3(trans0.localEulerAngles.x, trans0.localEulerAngles.y, trans0.localEulerAngles.z);

        pos1 = new Vector3(trans1.localPosition.x, trans1.localPosition.y, trans1.localPosition.z);
        rot1 = new Vector3(trans1.localEulerAngles.x, trans1.localEulerAngles.y, trans1.localEulerAngles.z);

        pos2 = new Vector3(trans2.localPosition.x, trans2.localPosition.y, trans2.localPosition.z);
        rot2 = new Vector3(trans2.localEulerAngles.x, trans2.localEulerAngles.y, trans2.localEulerAngles.z);

        // Record vectors of Dep Decks.

        //[Space]
        //[Header("BT deck objects and transforms")]
        //public GameObject btDeck;
        //public Transform btOriginTrans0; // origin. chosen. RP
        //public Transform btDepsTrans1; // department separated. RP
        //public Transform btUnchosTrans2; // unchosen, flies away. P

        //[Space]
        //[Header("SI deck objects and transforms")]
        //public GameObject siDeck;
        //public Transform siOriginTrans0; // origin. chosen. RP
        //public Transform siDepsTrans1; // department separated. RP
        //public Transform siUnchosTrans2; // unchosen, flies away. P

        //[Space]
        //[Header("MRM deck objects and transforms")]
        //public GameObject mrmDeck;
        //public Transform mrmOriginTrans0; // origin. chosen. RP
        //public Transform mrmDepsTrans1; // department separated. RP
        //public Transform mrmUnchosTrans2; // unchosen, flies away. P

        
        //// BT deck vectors.
        //private Vector3 btoPos0;
        //private Vector3 btdPos1;
        //private Vector3 btuPos2;

        //private Vector3 btoRot0;
        //private Vector3 btdRot1;

        //// SI deck vectors.
        //private Vector3 sioPos0;
        //private Vector3 sidPos1;
        //private Vector3 siuPos2;

        //private Vector3 sioRot0;
        //private Vector3 sidRot1;

        //// MRM deck vectors.
        //private Vector3 mrmoPos0;
        //private Vector3 mrmdPos1;
        //private Vector3 mrmuPos2;

        //private Vector3 mrmoRot0;
        //private Vector3 mrmdRot1;

        // VK.

        vkoPos0 = new Vector3(vkOriginTrans0.localPosition.x, vkOriginTrans0.localPosition.y, vkOriginTrans0.localPosition.z);
        vkdPos1 = new Vector3(vkDepsTrans1.localPosition.x, vkDepsTrans1.localPosition.y, vkDepsTrans1.localPosition.z);
        vkuPos2 = new Vector3(vkUnchosTrans2.localPosition.x, vkUnchosTrans2.localPosition.y, vkUnchosTrans2.localPosition.z);

        vkoRot0 = new Vector3(vkOriginTrans0.localEulerAngles.x, vkOriginTrans0.localEulerAngles.y, vkOriginTrans0.localEulerAngles.z);
        vkdRot1 = new Vector3(vkDepsTrans1.localEulerAngles.x, vkDepsTrans1.localEulerAngles.y, vkDepsTrans1.localEulerAngles.z);

        // BT

        btoPos0 = new Vector3(btOriginTrans0.localPosition.x, btOriginTrans0.localPosition.y, btOriginTrans0.localPosition.z);
        btdPos1 = new Vector3(btDepsTrans1.localPosition.x, btDepsTrans1.localPosition.y, btDepsTrans1.localPosition.z);
        btuPos2 = new Vector3(btUnchosTrans2.localPosition.x, btUnchosTrans2.localPosition.y, btUnchosTrans2.localPosition.z);

        btoRot0 = new Vector3(btOriginTrans0.localEulerAngles.x, btOriginTrans0.localEulerAngles.y, btOriginTrans0.localEulerAngles.z);
        btdRot1 = new Vector3(btDepsTrans1.localEulerAngles.x, btDepsTrans1.localEulerAngles.y, btDepsTrans1.localEulerAngles.z);

        // SI

        sioPos0 = new Vector3(siOriginTrans0.localPosition.x, siOriginTrans0.localPosition.y, siOriginTrans0.localPosition.z);
        sidPos1 = new Vector3(siDepsTrans1.localPosition.x, siDepsTrans1.localPosition.y, siDepsTrans1.localPosition.z);
        siuPos2 = new Vector3(siUnchosTrans2.localPosition.x, siUnchosTrans2.localPosition.y, siUnchosTrans2.localPosition.z);

        sioRot0 = new Vector3(siOriginTrans0.localEulerAngles.x, siOriginTrans0.localEulerAngles.y, siOriginTrans0.localEulerAngles.z);
        sidRot1 = new Vector3(siDepsTrans1.localEulerAngles.x, siDepsTrans1.localEulerAngles.y, siDepsTrans1.localEulerAngles.z);

        // MRM

        mrmoPos0 = new Vector3(mrmOriginTrans0.localPosition.x, mrmOriginTrans0.localPosition.y, mrmOriginTrans0.localPosition.z);
        mrmdPos1 = new Vector3(mrmDepsTrans1.localPosition.x, mrmDepsTrans1.localPosition.y, mrmDepsTrans1.localPosition.z);
        mrmuPos2 = new Vector3(mrmUnchosTrans2.localPosition.x, mrmUnchosTrans2.localPosition.y, mrmUnchosTrans2.localPosition.z);

        mrmoRot0 = new Vector3(mrmOriginTrans0.localEulerAngles.x, mrmOriginTrans0.localEulerAngles.y, mrmOriginTrans0.localEulerAngles.z);
        mrmdRot1 = new Vector3(mrmDepsTrans1.localEulerAngles.x, mrmDepsTrans1.localEulerAngles.y, mrmDepsTrans1.localEulerAngles.z);

        // Record vectors of Cards.

        // VKcard vectors.
        //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
        //public Transform[] vkCardsSpreadTrans1; // spread. P
        //public Transform[] vkCardsFlipTrans2; // flip. R
        //public Transform[] vkCardsAwayTrans3; // fly below. P
        //public Transform vkCardWithMediaTrans4; // position to share screen with media. P

        //////for (int i = 0; i < vkCardsOriginTrans0.Length; i++)
        //////{
        //////    vkcoPos0[i] = new Vector3(vkCardsOriginTrans0[i].localPosition.x, 
        //////        vkCardsOriginTrans0[i].localPosition.y, vkCardsOriginTrans0[i].localPosition.z);

        //////}

        //////for (int i = 0; i < vkCardsSpreadTrans1.Length; i++)
        //////{
        //////    vkcsPos1[i] = new Vector3(vkCardsSpreadTrans1[i].localPosition.x,
        //////        vkCardsSpreadTrans1[i].localPosition.y, vkCardsSpreadTrans1[i].localPosition.z);

        //////}

        //////for (int i = 0; i < vkCardsFlipTrans2.Length; i++)
        //////{
        //////    vkcfRot2[i] = new Vector3(vkCardsFlipTrans2[i].localEulerAngles.x,
        //////        vkCardsFlipTrans2[i].localEulerAngles.y, vkCardsFlipTrans2[i].localEulerAngles.z);

        //////}

        //////for (int i = 0; i < vkCardsAwayTrans3.Length; i++)
        //////{
        //////    vkcaPos3[i] = new Vector3(vkCardsAwayTrans3[i].localPosition.x,
        //////        vkCardsAwayTrans3[i].localPosition.y, vkCardsAwayTrans3[i].localPosition.z);

        //////}

        //////vkcwmPos4 = new Vector3(vkCardWithMediaTrans4.localPosition.x, vkCardWithMediaTrans4.localPosition.y, vkCardWithMediaTrans4.localPosition.z);


        // START IDLE ANIMATION OF GLOBAL DECK:

        LeanTween.rotateLocal(deck, rot0, 0f);
        LeanTween.moveLocal(deck, pos0, 0f);

        LeanTween.moveLocal(deck, pos1, timeAnim1).setDelay(delayTid).setEase(animCurve).setLoopPingPong(/*loopAnim1*/);

    }

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            TransitToDepartments();
        }
    }

    public void TransitToDepartments()
    {
        //int cancelId = LeanTween.move(deck, pos1, timeAnim1).setDelay(delayTid).setEase(animCurve).setLoopPingPong(-1).id;
        LeanTween.rotateLocal(deck, rot2, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(deck, pos2, timeAnim2).setEase(animCurve);

        LeanTween.rotateLocal(viskomDeck, vkdRot1, timeAnim2).setDelay(timeAnim2 * 2.5f).setEase(animCurve);
        LeanTween.moveLocal(viskomDeck, vkdPos1, timeAnim2).setDelay(timeAnim2 * 2.5f).setEase(animCurve);

        LeanTween.rotateLocal(btDeck, btdRot1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btdPos1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);

        LeanTween.rotateLocal(siDeck, sidRot1, timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sidPos1, timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);

        LeanTween.rotateLocal(mrmDeck, mrmdRot1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
    }

    //public void ZSwipeOut()
    //{
    //    LeanTween.move(contentPrnt, v0, timeAnim)/*.setDelay(delayTidPrim)*/.setEase(animCurve);
    //}
}
