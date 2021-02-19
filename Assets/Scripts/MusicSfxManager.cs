using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSfxManager : MonoBehaviour
{
    public AudioSource crystalBall;
    public AudioSource genericClick;

    public void PlayCrystalBallSfx()
    {
        crystalBall.Play();
    }

    public void PlayGenericClick()
    {
        genericClick.Play();
    }
}
