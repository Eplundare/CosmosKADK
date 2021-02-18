using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimation : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("OnClick",true);
        } else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("OnClick",false);
        }
    }
}
