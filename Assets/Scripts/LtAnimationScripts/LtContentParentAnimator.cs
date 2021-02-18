using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LtContentParentAnimator : MonoBehaviour
{

    [Space]
    [Header("Objects and transforms")]
    // Game objects of Primary and Secondary graphics, as well as their Pos (position) pivots.
    public GameObject contentPrnt;
    //public Transform cntTrans0; // Start idle position
    //public Transform cntTrans1; // Stop idle position
    public float unit = 1f;
    public float centena = 100f;

    [Space]
    [Header("Hidden Vectors")]
    // This vectors are assigned on Start.

    private Vector3 cntScale0; // Super big scale.
    private Vector3 cntScale1; // Normal 1 scale.

    [Space]
    [Header("Delay for animations")]
    // These delay the animation from starting.
    public float delayCnt;

    public void Awake()
    {
        cntScale0 = new Vector3(100f, 100f, 1f);
        cntScale1 = new Vector3(1f, 1f, 1f);

        LeanTween.scale(contentPrnt, cntScale0, 0f);


    }

    public void Start() // Starting Universe idle animation.
    {
        // Sets vectors for background rotations.
        //cntScale0 = new Vector3(cntTrans0.localScale.x, cntTrans0.localScale.y, cntTrans0.localScale.z);
        //cntScale1 = new Vector3(cntTrans1.localScale.x, cntTrans1.localScale.y, cntTrans1.localScale.z);

        cntScale0 = new Vector3(100f, 100f, 1f);
        cntScale1 = new Vector3(1f, 1f, 1f);

        // Starts scale animation.
        LeanTween.scale(contentPrnt, cntScale1, 0f).setDelay(delayCnt);

    }

}
