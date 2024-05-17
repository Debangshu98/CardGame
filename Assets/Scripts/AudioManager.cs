using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;
    [SerializeField] private AudioClip audioClip;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    /// <summary>
    /// this function plays the background music
    /// </summary>
    public void PlayBgMusic()
    {
        instance.GetComponent<AudioSource>().Play();
    }

    /// <summary>
    /// this function pauses the background music
    /// </summary>
    public void StopBgMusic()
    {
        instance.GetComponent<AudioSource>().Stop();
    }


    /// <summary>
    /// this function plays the audioclip music
    /// </summary>
    public void PlayAudioClip()
    {

        instance.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }
}
