using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmaudio : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] AudioClip bgmClip;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void bgmPlay()
    {
        audioSource.clip = bgmClip;
        audioSource.loop = true;
        audioSource.Play();
    }
  

}
