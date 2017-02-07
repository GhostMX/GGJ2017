using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonarRatScript : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Rigidbody2D>().velocity *= 0.9f;

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0f);
    }
}
