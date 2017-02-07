using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarCodeRat : MonoBehaviour {
    private GameObject Player;
    PlayerInputController Playerinput;
    Light Mylight;
    public int VisionFlying;
    public int LandingVision;
    public int RaioSpd; 
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerinput = Player.GetComponent<PlayerInputController>();
        Mylight = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Playerinput.LandingState == true) {
            Mylight.range = 1000;
            Mylight.spotAngle += Time.deltaTime * RaioSpd;

        }
        if (Mylight.spotAngle > LandingVision)
        {

            Mylight.spotAngle = LandingVision - 1; ;

        }
        if (Playerinput.LandingState == false)
        {
            Mylight.range = 500;
            // Mylight.spotAngle = VisionFlying;
            Mylight.spotAngle -= Time.deltaTime * RaioSpd;
        }
        if (Mylight.spotAngle >VisionFlying && Playerinput.LandingState==false) {
            Mylight.spotAngle -= Time.deltaTime * 10;
            //Mylight.spotAngle = VisionFlying + 1;
        }
        if (Mylight.spotAngle < VisionFlying) {
            Mylight.spotAngle = VisionFlying;

        }

		
	}
}
