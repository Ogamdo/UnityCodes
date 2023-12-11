
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVoice : MonoBehaviour
{
    public static EnemyVoice instance;

    AudioSource audio;

    void start()
    {
        //audio = GetComponent<AudioSource>();

    }
    /* void OnCollisionEnter()
    {
        audio.Play();
    } */
}
