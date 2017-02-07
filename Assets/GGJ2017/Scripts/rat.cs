using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat : MonoBehaviour {
    Rigidbody2D rgb;
    public float spd;
    public bool AwakeRat;
	AudioSource MyAudio;
	Animator anim;
	public bool Damage = false;

	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
        AwakeRat = false;
		MyAudio = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () {
		
		anim.SetBool("Damage", Damage);
        if (AwakeRat == true) {
            rgb.velocity = new Vector3(spd, 0, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == ("Player")){
            AwakeRat = true;
		}
		if (col.gameObject.tag == "Spike") {
			Damage = true;
			Destroy(gameObject, 0.5f);
			MyAudio.Play();
		}
    }
}
