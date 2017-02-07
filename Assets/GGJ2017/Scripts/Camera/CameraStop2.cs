/*
using UnityEngine;
using System.Collections;

public class CameraStop2 : MonoBehaviour {
	public GameObject CameratoStop;
	public bool Ativar;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			CameratoStop.GetComponent<CameraFollow>().Ativar = false;
			CameratoStop.GetComponent<CameraFollow>().CamTrigger = 2;
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			CameratoStop.GetComponent<CameraFollow>().Ativar = false;
			CameratoStop.GetComponent<CameraFollow>().CamTrigger = 2;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			CameratoStop.GetComponent<CameraFollow>().Ativar = true;
			CameratoStop.GetComponent<CameraFollow>().CamTrigger = 0;
		}
	}
}*/