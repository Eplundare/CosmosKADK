using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtDeckTransitions : MonoBehaviour
{
    [Space]
    [Header("Deck Bools")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    private bool vkDeckIsSelected;
    private bool btDeckIsSelected;
    private bool siDeckIsSelected;
    private bool mrmDeckIsSelected;


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
    private Vector3 rotateTo0;

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

    public void Awake()
    {
        {
            vkcoPos0 = new Vector3[vkCards.Length];
            vkcsPos1 = new Vector3[vkCards.Length];
            vkcfRot2 = new Vector3[vkCards.Length];
            vkcaPos3 = new Vector3[vkCards.Length];

            btcoPos0 = new Vector3[btCards.Length];
            btcsPos1 = new Vector3[btCards.Length];
            btcfRot2 = new Vector3[btCards.Length];
            btcaPos3 = new Vector3[btCards.Length];

            sicoPos0 = new Vector3[siCards.Length];
            sicsPos1 = new Vector3[siCards.Length];
            sicfRot2 = new Vector3[siCards.Length];
            sicaPos3 = new Vector3[siCards.Length];

            mrmcoPos0 = new Vector3[mrmCards.Length];
            mrmcsPos1 = new Vector3[mrmCards.Length];
            mrmcfRot2 = new Vector3[mrmCards.Length];
            mrmcaPos3 = new Vector3[mrmCards.Length];
        }
    }

    public void Start() // Starting Universe idle animation.
    {
        // Record vectors of Global deck.

        rotateTo0 = new Vector3(0f, 0f, 0f);

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

        for (int i = 0; i < vkCards.Length; i++)
        {
            vkcoPos0[i] = new Vector3(vkCardsOriginTrans0[i].localPosition.x,
                vkCardsOriginTrans0[i].localPosition.y, vkCardsOriginTrans0[i].localPosition.z);

        }



        for (int i = 0; i < vkCards.Length; i++)
        {
            vkcsPos1[i] = new Vector3(vkCardsSpreadTrans1[i].localPosition.x,
                vkCardsSpreadTrans1[i].localPosition.y, vkCardsSpreadTrans1[i].localPosition.z);

        }

        for (int i = 0; i < vkCards.Length; i++)
        {
            vkcfRot2[i] = new Vector3(vkCardsFlipTrans2[i].localEulerAngles.x,
                vkCardsFlipTrans2[i].localEulerAngles.y, vkCardsFlipTrans2[i].localEulerAngles.z);

        }

        for (int i = 0; i < vkCards.Length; i++)
        {
            vkcaPos3[i] = new Vector3(vkCardsAwayTrans3[i].localPosition.x,
                vkCardsAwayTrans3[i].localPosition.y, vkCardsAwayTrans3[i].localPosition.z);

        }

        vkcwmPos4 = new Vector3(vkCardWithMediaTrans4.localPosition.x, vkCardWithMediaTrans4.localPosition.y, vkCardWithMediaTrans4.localPosition.z);

        // BT

        for (int i = 0; i < btCards.Length; i++)
        {
            btcoPos0[i] = new Vector3(btCardsOriginTrans0[i].localPosition.x,
                btCardsOriginTrans0[i].localPosition.y, btCardsOriginTrans0[i].localPosition.z);

        }



        for (int i = 0; i < btCards.Length; i++)
        {
            btcsPos1[i] = new Vector3(btCardsSpreadTrans1[i].localPosition.x,
                btCardsSpreadTrans1[i].localPosition.y, btCardsSpreadTrans1[i].localPosition.z);

        }

        for (int i = 0; i < btCards.Length; i++)
        {
            btcfRot2[i] = new Vector3(btCardsFlipTrans2[i].localEulerAngles.x,
                btCardsFlipTrans2[i].localEulerAngles.y, btCardsFlipTrans2[i].localEulerAngles.z);

        }

        for (int i = 0; i < btCards.Length; i++)
        {
            btcaPos3[i] = new Vector3(btCardsAwayTrans3[i].localPosition.x,
                btCardsAwayTrans3[i].localPosition.y, btCardsAwayTrans3[i].localPosition.z);

        }

        btcwmPos4 = new Vector3(btCardWithMediaTrans4.localPosition.x, btCardWithMediaTrans4.localPosition.y, btCardWithMediaTrans4.localPosition.z);

        // SI

        for (int i = 0; i < siCards.Length; i++)
        {
            sicoPos0[i] = new Vector3(siCardsOriginTrans0[i].localPosition.x,
                siCardsOriginTrans0[i].localPosition.y, siCardsOriginTrans0[i].localPosition.z);

        }



        for (int i = 0; i < siCards.Length; i++)
        {
            sicsPos1[i] = new Vector3(siCardsSpreadTrans1[i].localPosition.x,
                siCardsSpreadTrans1[i].localPosition.y, siCardsSpreadTrans1[i].localPosition.z);

        }

        for (int i = 0; i < siCards.Length; i++)
        {
            sicfRot2[i] = new Vector3(siCardsFlipTrans2[i].localEulerAngles.x,
                siCardsFlipTrans2[i].localEulerAngles.y, siCardsFlipTrans2[i].localEulerAngles.z);

        }

        for (int i = 0; i < siCards.Length; i++)
        {
            sicaPos3[i] = new Vector3(siCardsAwayTrans3[i].localPosition.x,
                siCardsAwayTrans3[i].localPosition.y, siCardsAwayTrans3[i].localPosition.z);

        }

        sicwmPos4 = new Vector3(siCardWithMediaTrans4.localPosition.x, siCardWithMediaTrans4.localPosition.y, siCardWithMediaTrans4.localPosition.z);

        // MRM

        for (int i = 0; i < mrmCards.Length; i++)
        {
            mrmcoPos0[i] = new Vector3(mrmCardsOriginTrans0[i].localPosition.x,
                mrmCardsOriginTrans0[i].localPosition.y, mrmCardsOriginTrans0[i].localPosition.z);

        }



        for (int i = 0; i < mrmCards.Length; i++)
        {
            mrmcsPos1[i] = new Vector3(mrmCardsSpreadTrans1[i].localPosition.x,
                mrmCardsSpreadTrans1[i].localPosition.y, mrmCardsSpreadTrans1[i].localPosition.z);

        }

        for (int i = 0; i < mrmCards.Length; i++)
        {
            mrmcfRot2[i] = new Vector3(mrmCardsFlipTrans2[i].localEulerAngles.x,
                mrmCardsFlipTrans2[i].localEulerAngles.y, mrmCardsFlipTrans2[i].localEulerAngles.z);

        }

        for (int i = 0; i < mrmCards.Length; i++)
        {
            mrmcaPos3[i] = new Vector3(mrmCardsAwayTrans3[i].localPosition.x,
                mrmCardsAwayTrans3[i].localPosition.y, mrmCardsAwayTrans3[i].localPosition.z);

        }

        mrmcwmPos4 = new Vector3(mrmCardWithMediaTrans4.localPosition.x, mrmCardWithMediaTrans4.localPosition.y, mrmCardWithMediaTrans4.localPosition.z);


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

    public void BackToHome()
    {
        LeanTween.rotateLocal(deck, rot0, timeAnim2).setDelay(timeAnim2 * 2.5f).setEase(animCurve);
        LeanTween.moveLocal(deck, pos0, timeAnim2).setDelay(timeAnim2 * 2.5f).setEase(animCurve);

        LeanTween.rotateLocal(viskomDeck, vkoRot0, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(viskomDeck, vkoPos0, timeAnim2).setEase(animCurve);

        LeanTween.rotateLocal(btDeck, btoRot0, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btoPos0, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        LeanTween.rotateLocal(siDeck, sioRot0, timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sioPos0, timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);

        LeanTween.rotateLocal(mrmDeck, mrmoRot0, timeAnim2).setDelay(timeAnim2*2f).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmoPos0, timeAnim2).setDelay(timeAnim2*2f).setEase(animCurve);
    }

    public void TransitToSpreadVk()
    {
        //    [Header("VK deck objects and transforms")]
        //    public GameObject viskomDeck;
        //public Transform vkOriginTrans0; // origin. chosen. RP
        //public Transform vkDepsTrans1; // department separated. RP
        //public Transform vkUnchosTrans2; // unchosen, flies away. P

        //public GameObject[] vkCards;
        //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
        //public Transform[] vkCardsSpreadTrans1; // spread. P
        //public Transform[] vkCardsFlipTrans2; // flip. R
        //public Transform[] vkCardsAwayTrans3; // fly below. P
        //public Transform vkCardWithMediaTrans4; // position to share screen with media. P

        // SET VK DECK AS SELECTED
        vkDeckIsSelected = true;
        btDeckIsSelected = false;


        // THE DEP DECK IS CENTERED
        LeanTween.rotateLocal(viskomDeck, vkoRot0, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(viskomDeck, vkoPos0, timeAnim2).setEase(animCurve);

        // OTHER DECKS MOVE AWAY
        LeanTween.moveLocal(btDeck, btuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, siuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // CHOSEN DECK STARTS TO SPREAD
        for (int i = 0; i < vkCards.Length; i++)
        {
            LeanTween.moveLocal(vkCards[i], vkcsPos1[i], timeAnim2).setDelay(timeAnim2*1.5f).setEase(animCurve);

        }

        // VK CARDS FLIP
        for (int i = 0; i < vkCards.Length; i++)
        {
            LeanTween.rotateLocal(vkCards[i], vkcfRot2[i], timeAnim2).setDelay(timeAnim2 + (timeAnim2 * 1.5f)).setEase(animCurve);

        }
    }

    public void TransitToSpreadBt()
    {
        //    [Header("VK deck objects and transforms")]
        //    public GameObject viskomDeck;
        //public Transform vkOriginTrans0; // origin. chosen. RP
        //public Transform vkDepsTrans1; // department separated. RP
        //public Transform vkUnchosTrans2; // unchosen, flies away. P

        //public GameObject[] vkCards;
        //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
        //public Transform[] vkCardsSpreadTrans1; // spread. P
        //public Transform[] vkCardsFlipTrans2; // flip. R
        //public Transform[] vkCardsAwayTrans3; // fly below. P
        //public Transform vkCardWithMediaTrans4; // position to share screen with media. P

        //// SET VK DECK AS SELECTED
        //vkDeckIsSelected = true;
        //btDeckIsSelected = false;


        // THE DEP DECK IS CENTERED
        LeanTween.rotateLocal(btDeck, btoRot0, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btoPos0, timeAnim2).setEase(animCurve);

        // OTHER DECKS MOVE AWAY
        LeanTween.moveLocal(viskomDeck, vkuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, siuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // CHOSEN DECK STARTS TO SPREAD
        for (int i = 0; i < btCards.Length; i++)
        {
            LeanTween.moveLocal(btCards[i], btcsPos1[i], timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);

        }

        // VK CARDS FLIP
        for (int i = 0; i < btCards.Length; i++)
        {
            LeanTween.rotateLocal(btCards[i], btcfRot2[i], timeAnim2).setDelay(timeAnim2 + (timeAnim2 * 1.5f)).setEase(animCurve);

        }
    }

    public void TransitToSpreadSi()
    {
        //    [Header("VK deck objects and transforms")]
        //    public GameObject viskomDeck;
        //public Transform vkOriginTrans0; // origin. chosen. RP
        //public Transform vkDepsTrans1; // department separated. RP
        //public Transform vkUnchosTrans2; // unchosen, flies away. P

        //public GameObject[] vkCards;
        //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
        //public Transform[] vkCardsSpreadTrans1; // spread. P
        //public Transform[] vkCardsFlipTrans2; // flip. R
        //public Transform[] vkCardsAwayTrans3; // fly below. P
        //public Transform vkCardWithMediaTrans4; // position to share screen with media. P

        //// SET VK DECK AS SELECTED
        //vkDeckIsSelected = true;
        //btDeckIsSelected = false;


        // THE DEP DECK IS CENTERED
        LeanTween.rotateLocal(siDeck, sioRot0, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sioPos0, timeAnim2).setEase(animCurve);

        // OTHER DECKS MOVE AWAY
        LeanTween.moveLocal(viskomDeck, vkuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // CHOSEN DECK STARTS TO SPREAD
        for (int i = 0; i < siCards.Length; i++)
        {
            LeanTween.moveLocal(siCards[i], sicsPos1[i], timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);

        }

        // VK CARDS FLIP
        for (int i = 0; i < siCards.Length; i++)
        {
            LeanTween.rotateLocal(siCards[i], sicfRot2[i], timeAnim2).setDelay(timeAnim2 + (timeAnim2 * 1.5f)).setEase(animCurve);

        }
    }

    public void TransitToSpreadMrm()
    {
        //    [Header("VK deck objects and transforms")]
        //    public GameObject viskomDeck;
        //public Transform vkOriginTrans0; // origin. chosen. RP
        //public Transform vkDepsTrans1; // department separated. RP
        //public Transform vkUnchosTrans2; // unchosen, flies away. P

        //public GameObject[] vkCards;
        //public Transform[] vkCardsOriginTrans0; // origin and chosen card. P
        //public Transform[] vkCardsSpreadTrans1; // spread. P
        //public Transform[] vkCardsFlipTrans2; // flip. R
        //public Transform[] vkCardsAwayTrans3; // fly below. P
        //public Transform vkCardWithMediaTrans4; // position to share screen with media. P

        //// SET VK DECK AS SELECTED
        //vkDeckIsSelected = true;
        //btDeckIsSelected = false;


        // THE DEP DECK IS CENTERED
        LeanTween.rotateLocal(mrmDeck, mrmoRot0, timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmoPos0, timeAnim2).setEase(animCurve);

        // OTHER DECKS MOVE AWAY
        LeanTween.moveLocal(viskomDeck, vkuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, siuPos2, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // CHOSEN DECK STARTS TO SPREAD
        for (int i = 0; i < mrmCards.Length; i++)
        {
            LeanTween.moveLocal(mrmCards[i], mrmcsPos1[i], timeAnim2).setDelay(timeAnim2 * 1.5f).setEase(animCurve);

        }

        // VK CARDS FLIP
        for (int i = 0; i < mrmCards.Length; i++)
        {
            LeanTween.rotateLocal(mrmCards[i], mrmcfRot2[i], timeAnim2).setDelay(timeAnim2 + (timeAnim2 * 1.5f)).setEase(animCurve);

        }
    }

    public void BackToSeparateDepsFromVk()
    {
        // VK CARDS FLIP BACK
        for (int i = 0; i < vkCards.Length; i++)
        {
            LeanTween.rotateY(vkCards[i], 0f, timeAnim2).setDelay(0f).setEase(animCurve);
            
            // VK CARDS GATHER
            LeanTween.moveLocal(vkCards[i], vkcoPos0[i], timeAnim2).setDelay(timeAnim2 /** 1.5f*/).setEase(animCurve);

        }

        // OTHER DECKS COME BACK
        LeanTween.moveLocal(btDeck, btdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sidPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // THE DEP DECK GOES BACK TO SEPARATED POSITION
        LeanTween.rotateLocal(viskomDeck, vkdRot1, timeAnim2).setDelay(timeAnim2*2f).setEase(animCurve);
        LeanTween.moveLocal(viskomDeck, vkdPos1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);

    }

    public void BackToSeparateDepsFromBt()
    {
        // VK CARDS FLIP BACK
        for (int i = 0; i < btCards.Length; i++)
        {
            LeanTween.rotateY(btCards[i], 0f, timeAnim2).setDelay(0f).setEase(animCurve);

            // VK CARDS GATHER
            LeanTween.moveLocal(btCards[i], btcoPos0[i], timeAnim2).setDelay(timeAnim2 /** 1.5f*/).setEase(animCurve);

        }

        // OTHER DECKS COME BACK
        LeanTween.moveLocal(viskomDeck, vkdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sidPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // THE DEP DECK GOES BACK TO SEPARATED POSITION
        LeanTween.rotateLocal(btDeck, btdRot1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btdPos1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);

    }

    public void BackToSeparateDepsFromSi()
    {
        // VK CARDS FLIP BACK
        for (int i = 0; i < siCards.Length; i++)
        {
            LeanTween.rotateY(siCards[i], 0f, timeAnim2).setDelay(0f).setEase(animCurve);

            // VK CARDS GATHER
            LeanTween.moveLocal(siCards[i], sicoPos0[i], timeAnim2).setDelay(timeAnim2 /** 1.5f*/).setEase(animCurve);

        }

        // OTHER DECKS COME BACK
        LeanTween.moveLocal(viskomDeck, vkdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // THE DEP DECK GOES BACK TO SEPARATED POSITION
        LeanTween.rotateLocal(siDeck, sidRot1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sidPos1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);

    }

    public void BackToSeparateDepsFromMrm()
    {
        // VK CARDS FLIP BACK
        for (int i = 0; i < mrmCards.Length; i++)
        {
            LeanTween.rotateY(mrmCards[i], 0f, timeAnim2).setDelay(0f).setEase(animCurve);

            // VK CARDS GATHER
            LeanTween.moveLocal(mrmCards[i], mrmcoPos0[i], timeAnim2).setDelay(timeAnim2 /** 1.5f*/).setEase(animCurve);

        }

        // OTHER DECKS COME BACK
        LeanTween.moveLocal(viskomDeck, vkdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(btDeck, btdPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);
        LeanTween.moveLocal(siDeck, sidPos1, timeAnim2).setDelay(timeAnim2).setEase(animCurve);

        // THE DEP DECK GOES BACK TO SEPARATED POSITION
        LeanTween.rotateLocal(mrmDeck, mrmdRot1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);
        LeanTween.moveLocal(mrmDeck, mrmdPos1, timeAnim2).setDelay(timeAnim2 * 2f).setEase(animCurve);

    }

    public void TransitToVkCard0()
    {
        LeanTween.moveLocal(vkCards[0], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 0) continue;
            else if (i != 0)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2*2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard1()
    {
        LeanTween.moveLocal(vkCards[1], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 1) continue;
            else if (i != 1)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard2()
    {
        LeanTween.moveLocal(vkCards[2], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 2) continue;
            else if (i != 2)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard3()
    {
        LeanTween.moveLocal(vkCards[3], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 3) continue;
            else if (i != 3)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard4()
    {
        LeanTween.moveLocal(vkCards[4], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 4) continue;
            else if (i != 4)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard5()
    {
        LeanTween.moveLocal(vkCards[5], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 5) continue;
            else if (i != 5)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard6()
    {
        LeanTween.moveLocal(vkCards[6], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 6) continue;
            else if (i != 6)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard7()
    {
        LeanTween.moveLocal(vkCards[7], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 7) continue;
            else if (i != 7)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard8()
    {
        LeanTween.moveLocal(vkCards[8], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 8) continue;
            else if (i != 8)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard9()
    {
        LeanTween.moveLocal(vkCards[9], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 9) continue;
            else if (i != 9)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard10()
    {
        LeanTween.moveLocal(vkCards[10], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 10) continue;
            else if (i != 10)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard11()
    {
        LeanTween.moveLocal(vkCards[11], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 11) continue;
            else if (i != 11)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard12()
    {
        LeanTween.moveLocal(vkCards[12], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 12) continue;
            else if (i != 12)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard13()
    {
        LeanTween.moveLocal(vkCards[13], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 13) continue;
            else if (i != 13)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard14()
    {
        LeanTween.moveLocal(vkCards[14], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 14) continue;
            else if (i != 14)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard15()
    {
        LeanTween.moveLocal(vkCards[15], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 15) continue;
            else if (i != 15)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard16()
    {
        LeanTween.moveLocal(vkCards[16], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 16) continue;
            else if (i != 16)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard17()
    {
        LeanTween.moveLocal(vkCards[17], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 17) continue;
            else if (i != 17)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard18()
    {
        LeanTween.moveLocal(vkCards[18], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 18) continue;
            else if (i != 18)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard19()
    {
        LeanTween.moveLocal(vkCards[19], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 19) continue;
            else if (i != 19)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToVkCard20()
    {
        LeanTween.moveLocal(vkCards[20], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 20) continue;
            else if (i != 20)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    

    public void TransitToVkCard21()
    {
        LeanTween.moveLocal(vkCards[21], vkcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < vkCards.Length; i++)
        {
            if (i == 21) continue;
            else if (i != 21)
            {
                LeanTween.moveLocal(vkCards[i], vkcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard0()
    {
        LeanTween.moveLocal(btCards[0], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 0) continue;
            else if (i != 0)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard1()
    {
        LeanTween.moveLocal(btCards[1], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 1) continue;
            else if (i != 1)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard2()
    {
        LeanTween.moveLocal(btCards[2], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 2) continue;
            else if (i != 2)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard3()
    {
        LeanTween.moveLocal(btCards[3], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 3) continue;
            else if (i != 3)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard4()
    {
        LeanTween.moveLocal(btCards[4], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 4) continue;
            else if (i != 4)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard5()
    {
        LeanTween.moveLocal(btCards[5], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 5) continue;
            else if (i != 5)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard6()
    {
        LeanTween.moveLocal(btCards[6], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 6) continue;
            else if (i != 6)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard7()
    {
        LeanTween.moveLocal(btCards[7], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 7) continue;
            else if (i != 7)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard8()
    {
        LeanTween.moveLocal(btCards[8], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 8) continue;
            else if (i != 8)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard9()
    {
        LeanTween.moveLocal(btCards[9], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 9) continue;
            else if (i != 9)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard10()
    {
        LeanTween.moveLocal(btCards[10], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 10) continue;
            else if (i != 10)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard11()
    {
        LeanTween.moveLocal(btCards[11], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 11) continue;
            else if (i != 11)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard12()
    {
        LeanTween.moveLocal(btCards[12], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 12) continue;
            else if (i != 12)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard13()
    {
        LeanTween.moveLocal(btCards[13], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 13) continue;
            else if (i != 13)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToBtCard14()
    {
        LeanTween.moveLocal(btCards[14], btcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < btCards.Length; i++)
        {
            if (i == 14) continue;
            else if (i != 14)
            {
                LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    //public void TransitToBtCard15()
    //{
    //    LeanTween.moveLocal(btCards[1], btcwmPos4, timeAnim2).setEase(animCurve);

    //    for (int i = 0; i < btCards.Length; i++)
    //    {
    //        if (i == 15) continue;
    //        else if (i != 15)
    //        {
    //            LeanTween.moveLocal(btCards[i], btcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

    //        }

    //    }

    //}

    public void TransitToSiCard0()
    {
        LeanTween.moveLocal(siCards[0], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 0) continue;
            else if (i != 0)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard1()
    {
        LeanTween.moveLocal(siCards[1], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 1) continue;
            else if (i != 1)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard2()
    {
        LeanTween.moveLocal(siCards[2], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 2) continue;
            else if (i != 2)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard3()
    {
        LeanTween.moveLocal(siCards[3], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 3) continue;
            else if (i != 3)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard4()
    {
        LeanTween.moveLocal(siCards[4], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 4) continue;
            else if (i != 4)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard5()
    {
        LeanTween.moveLocal(siCards[5], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 5) continue;
            else if (i != 5)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard6()
    {
        LeanTween.moveLocal(siCards[6], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 6) continue;
            else if (i != 6)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard7()
    {
        LeanTween.moveLocal(siCards[7], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 7) continue;
            else if (i != 7)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard8()
    {
        LeanTween.moveLocal(siCards[8], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 8) continue;
            else if (i != 8)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard9()
    {
        LeanTween.moveLocal(siCards[9], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 9) continue;
            else if (i != 9)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard10()
    {
        LeanTween.moveLocal(siCards[10], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 10) continue;
            else if (i != 10)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToSiCard11()
    {
        LeanTween.moveLocal(siCards[11], sicwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < siCards.Length; i++)
        {
            if (i == 11) continue;
            else if (i != 11)
            {
                LeanTween.moveLocal(siCards[i], sicaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard0()
    {
        LeanTween.moveLocal(mrmCards[0], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 0) continue;
            else if (i != 0)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard1()
    {
        LeanTween.moveLocal(mrmCards[1], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 1) continue;
            else if (i != 1)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard2()
    {
        LeanTween.moveLocal(mrmCards[2], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 2) continue;
            else if (i != 2)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard3()
    {
        LeanTween.moveLocal(mrmCards[3], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 3) continue;
            else if (i != 3)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard4()
    {
        LeanTween.moveLocal(mrmCards[4], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 4) continue;
            else if (i != 4)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard5()
    {
        LeanTween.moveLocal(mrmCards[5], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 5) continue;
            else if (i != 5)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard6()
    {
        LeanTween.moveLocal(mrmCards[6], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 6) continue;
            else if (i != 6)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard7()
    {
        LeanTween.moveLocal(mrmCards[7], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 7) continue;
            else if (i != 7)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard8()
    {
        LeanTween.moveLocal(mrmCards[8], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 8) continue;
            else if (i != 8)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard9()
    {
        LeanTween.moveLocal(mrmCards[9], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 9) continue;
            else if (i != 9)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard10()
    {
        LeanTween.moveLocal(mrmCards[10], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 10) continue;
            else if (i != 10)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard11()
    {
        LeanTween.moveLocal(mrmCards[11], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 11) continue;
            else if (i != 11)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard12()
    {
        LeanTween.moveLocal(mrmCards[12], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 12) continue;
            else if (i != 12)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard13()
    {
        LeanTween.moveLocal(mrmCards[13], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 13) continue;
            else if (i != 13)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard14()
    {
        LeanTween.moveLocal(mrmCards[14], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 14) continue;
            else if (i != 14)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard15()
    {
        LeanTween.moveLocal(mrmCards[15], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 15) continue;
            else if (i != 15)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard16()
    {
        LeanTween.moveLocal(mrmCards[16], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 16) continue;
            else if (i != 16)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard17()
    {
        LeanTween.moveLocal(mrmCards[17], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 17) continue;
            else if (i != 17)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard18()
    {
        LeanTween.moveLocal(mrmCards[18], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 18) continue;
            else if (i != 18)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard19()
    {
        LeanTween.moveLocal(mrmCards[19], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 19) continue;
            else if (i != 19)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard20()
    {
        LeanTween.moveLocal(mrmCards[20], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 20) continue;
            else if (i != 20)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard21()
    {
        LeanTween.moveLocal(mrmCards[21], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 21) continue;
            else if (i != 21)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void TransitToMrmCard22()
    {
        LeanTween.moveLocal(mrmCards[22], mrmcwmPos4, timeAnim2).setEase(animCurve);

        for (int i = 0; i < mrmCards.Length; i++)
        {
            if (i == 22) continue;
            else if (i != 22)
            {
                LeanTween.moveLocal(mrmCards[i], mrmcaPos3[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void BackVkCardsSpread()
    {

        for (int i = 0; i < vkCards.Length; i++)
        {

            {
                LeanTween.moveLocal(vkCards[i], vkcsPos1[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void BackSiCardsSpread()
    {

        for (int i = 0; i < siCards.Length; i++)
        {

            {
                LeanTween.moveLocal(siCards[i], sicsPos1[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void BackBtCardsSpread()
    {

        for (int i = 0; i < btCards.Length; i++)
        {

            {
                LeanTween.moveLocal(btCards[i], btcsPos1[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

    public void BackMrmCardsSpread()
    {

        for (int i = 0; i < mrmCards.Length; i++)
        {

            {
                LeanTween.moveLocal(mrmCards[i], mrmcsPos1[i], timeAnim2 * 2f).setDelay(0f).setEase(animCurve);

            }

        }

    }

}
