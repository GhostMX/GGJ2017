using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisaoScript : MonoBehaviour {

    private GameObject Player;
	CircleCollider2D MyCollider;
	PlayerInputController Playerinput;
	public float AlinhamentoY;
	public int VisaoRadiusMin;
	public int VisaoRadiusMax;
	public GameObject Sensor;
	SonarCode ThisSonarCode;
	public float VelocidadeCrescimentoVisao;
	// Use this for initialization
	void Start () {
        this.Player = GameObject.FindGameObjectWithTag("Player");
		MyCollider = GetComponent<CircleCollider2D> ();
		Playerinput = Player.GetComponent<PlayerInputController>();
		//Sensor = GameObject.Find ("Light");
		ThisSonarCode = Sensor.GetComponent<SonarCode>();
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y + AlinhamentoY, Player.transform.position.z);

		if (Playerinput.LandingState == false && ThisSonarCode.GritoAtivo == false) {
			MyCollider.radius -= Time.deltaTime * VelocidadeCrescimentoVisao;
		}else{
			MyCollider.radius += Time.deltaTime * VelocidadeCrescimentoVisao;
		}

		if (MyCollider.radius < VisaoRadiusMin) {
			MyCollider.radius = VisaoRadiusMin;
		}

		if (MyCollider.radius > VisaoRadiusMax) {

			MyCollider.radius = VisaoRadiusMax;
		}
	}
}
