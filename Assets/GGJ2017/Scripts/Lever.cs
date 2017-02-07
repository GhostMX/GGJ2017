using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {
    PlayerInputController Playerinput;
    private GameObject Player;
    BoxCollider2D MyCollider;
    public float Valor2DoorTimer;
    public float TimeToDoorBack;
    public float timer;
    AudioSource MyAudio;
    


    public float spd; 
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerinput = Player.GetComponent<PlayerInputController>();
        MyCollider = GetComponent<BoxCollider2D>();
        MyAudio = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {

        if (Playerinput.LeverOn==true) {
            TimeToDoorBack -= Time.deltaTime;
            MyAudio.Play();
        }

        
        if (timer <TimeToDoorBack/2 && Playerinput.LeverOn == true)
        {
            transform.Translate(new Vector2(0, spd));
            
           
           
        }
        if (timer >= TimeToDoorBack/2 && Playerinput.LeverOn == true)
        {
            transform.Translate(new Vector2(0, -spd));
        
        }
        if (TimeToDoorBack <= -2)
        {
            TimeToDoorBack = 2f;
        } 
        //  if (gameObject.transform.position.y >HighVector)  {

        //  spd = spd * -1;    

        //  }
        //   if (gameObject.transform.position.y < LowVector) {
        //     transform.position = new Vector3(22.4f, -2, 0);

        //   }



    }

   
}
