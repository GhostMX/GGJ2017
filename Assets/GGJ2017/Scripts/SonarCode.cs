using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarCode : MonoBehaviour {
    private GameObject Player;
    PlayerInputController Playerinput;
    Light Mylight;
    public int VisionFlying;
    public int LandingVision;
    public int RaioSpd; 
	public int RaioSpdNegativo;
	AudioSource MyAudio;
	public float ShoutCooldown;
	public float FinalShoutCooldown;
	public bool GritoAtivo;


	public bool PressedActionButton;
	public float TimetoReset;
	public float TempodaLuz;


    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerinput = Player.GetComponent<PlayerInputController>();
        Mylight = GetComponent<Light>();
		PressedActionButton = false;
		MyAudio = GetComponent<AudioSource>();
		GritoAtivo = false;
		TimetoReset = TempodaLuz;
    }
	
	// Update is called once per frame
	void Update () {



		ShoutCooldown -= Time.deltaTime;
		if (Input.GetAxis ("Jump") > 0f && ShoutCooldown < 0 && Playerinput.LandingState == false) {
			MyAudio.Play ();
			ShoutCooldown = FinalShoutCooldown;
			PressedActionButton = true;
			TimetoReset = TempodaLuz;

		} 

		if (PressedActionButton == true) {
		
			TimetoReset -= Time.deltaTime;
			Mylight.spotAngle += Time.deltaTime * RaioSpd;
			GritoAtivo = true;

		}

		if (TimetoReset > TempodaLuz/2) {

		
	//		TimetoReset = TimetoReset2;
			Mylight.spotAngle += Time.deltaTime * RaioSpd;

		}
		if (TimetoReset < TempodaLuz / 2) {

			Mylight.spotAngle -= Time.deltaTime * RaioSpd;

		}

		if (TimetoReset < 0) {
		
			TimetoReset = TempodaLuz;	
			PressedActionButton = false;
			GritoAtivo = false;
		}

				if (Playerinput.LandingState == true) {
					Mylight.range = 1000;
					Mylight.spotAngle += Time.deltaTime * RaioSpd;

				}
				if (Mylight.spotAngle > LandingVision) {

					Mylight.spotAngle = LandingVision - 1;
					;

				}
		if (Playerinput.LandingState == false && PressedActionButton==false) {
					Mylight.range = 1000;
					// Mylight.spotAngle = VisionFlying;
			Mylight.spotAngle -= Time.deltaTime * RaioSpdNegativo ;
				}
				if (Mylight.spotAngle > VisionFlying && Playerinput.LandingState == false) {
			Mylight.spotAngle -= Time.deltaTime * RaioSpdNegativo;
					//Mylight.spotAngle = VisionFlying + 1;
				}
				if (Mylight.spotAngle < VisionFlying) {
					Mylight.spotAngle = VisionFlying;

				}

		
			}
		

		}
	