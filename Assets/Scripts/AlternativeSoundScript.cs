using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeSoundScript : MonoBehaviour
{
    [SerializeField]
    AudioSource audioSource;
    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
    public void StopSound()
    {
        audioSource.Stop();
    }
}
