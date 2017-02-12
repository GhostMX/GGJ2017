using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour {

    AudioSource MyAudio;

    // Use this for initialization
    void Start(){
        MyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == ("Player")){
            MyAudio.Play();
        }
    }
}
