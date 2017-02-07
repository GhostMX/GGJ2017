using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shout : MonoBehaviour {
    AudioSource MyAudio;
    public float ShoutCooldown;
    public float FinalShoutCooldown;
	// Use this for initialization
	void Start () {
        MyAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ShoutCooldown -= Time.deltaTime;
        if (Input.GetAxis("Jump") > 0f && ShoutCooldown<0)
        {
            MyAudio.Play();
            ShoutCooldown = FinalShoutCooldown;
        }
    }
}
