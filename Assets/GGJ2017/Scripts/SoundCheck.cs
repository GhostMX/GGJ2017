using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCheck : MonoBehaviour
{
    private GameObject Player;
    PlayerInputController Playerinput;
    AudioSource MyAudioSorce;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerinput = Player.GetComponent<PlayerInputController>();
        MyAudioSorce = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Playerinput.LandingState == false)
        {
            MyAudioSorce.mute = false;
            //   MyAudioSorce.Play();

        }
        else
        {

            MyAudioSorce.mute = true;
        }
    }
}
