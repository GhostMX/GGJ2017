using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {
    PlayerInputController Playerinput;
    private GameObject Player;
    public float Valor2DoorTimer;
    public float TimeToDoorBack;
    public float timer;
    AudioSource MyAudio;
	public float spd; 

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerinput = Player.GetComponent<PlayerInputController>();
        MyAudio = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Playerinput.LeverOn==true) {
            TimeToDoorBack -= Time.deltaTime;
            MyAudio.Play();
        }

        
        if (timer <TimeToDoorBack/2 && Playerinput.LeverOn == true){
            transform.Translate(new Vector2(0, spd));
        }

        if (timer >= TimeToDoorBack/2 && Playerinput.LeverOn == true){
            transform.Translate(new Vector2(0, -spd));        
        }
        if (TimeToDoorBack <= -2){
            TimeToDoorBack = 2f;
        }
    }
}
