using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaVisao : MonoBehaviour {
    private bool ativaVisao = false;
    private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
        sr = this.GetComponent<SpriteRenderer>();
        sr.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Sensor")){
			sr.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.CompareTag("Sensor")){
			sr.enabled = false;
        }
    }
}
