using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1,sfx2;


    public void WalkSFX()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void RunSFX()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void JumpSFX()
    {
        src.clip = sfx2;
        src.Play();
    }

}
