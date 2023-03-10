using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribbit : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void PlayRibbit ()
    {
        audioSource.PlayOneShot(clip);
    }
    
    void Start()
    {
        
    }
}
