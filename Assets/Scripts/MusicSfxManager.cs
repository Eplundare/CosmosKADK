using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSfxManager : MonoBehaviour
{
    public AudioSource boom;
    public AudioSource crystalBall;
    public AudioSource genericClick;
    public AudioSource deal;
    public AudioSource whoosh1;
    public AudioSource whoosh2;
    public AudioSource whoosh3;
    public AudioSource whoosh4;
    public AudioSource cardsVk;
    public AudioSource cardsBt;
    public AudioSource cardsSi;
    public AudioSource cardsMrm;

    public void PlayBoom()
    {
        boom.Play();
    }

    public void PlayCrystalBallSfx()
    {
        crystalBall.Play();
    }

    public void PlayGenericClick()
    {
        genericClick.Play();
    }

    public void PlayDealVk()
    {
        deal.Play();
        whoosh1.Play();
    }

    public void PlayDealBt()
    {
        deal.Play();
        whoosh2.Play();
    }

    public void PlayDealSi()
    {
        deal.Play();
        whoosh3.Play();
    }

    public void PlayDealMrm()
    {
        deal.Play();
        whoosh4.Play();
    }

    public void PlayCardsVk()
    {
        cardsVk.Play();
    }

    public void PlayCardsBt()
    {
        cardsBt.Play();
    }

    public void PlayCardsSi()
    {
        cardsSi.Play();
    }

    public void PlayCardsMrm()
    {
        cardsMrm.Play();
    }
}
