using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFuegote : MonoBehaviour
{
    public AudioSource fuegoteS;
    public AudioClip bfff;

    public void FuegoteSound()
    {

        fuegoteS.PlayOneShot(bfff);
    }

    
}
